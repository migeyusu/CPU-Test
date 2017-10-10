using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
namespace CPUTest
{
    internal class ThreadControl
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetCurrentThread();
        [DllImport("kernel32.dll")]
        public static extern UIntPtr SetThreadAffinityMask(IntPtr hThread, UIntPtr dwThreadAffinityMask);
        public static void MyThreadToCore(string cores)//绑定当前线程核心，从1开始计数
        {
                ThreadControl.SetThreadAffinityMask(ThreadControl.GetCurrentThread(),(UIntPtr)Convert.ToInt32(cores,2));    
        }
        public static void MyProcessHigh()//设置本进程优先级最高
        {
            var myProcess =Process.GetCurrentProcess();
            myProcess.PriorityClass = System.Diagnostics.ProcessPriorityClass.High;
        }
    }

    internal class TickCount
    {
        [DllImport("kernel32")]
        public static extern uint GetTickCount();

    }
}
