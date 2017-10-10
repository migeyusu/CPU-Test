using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Diagnostics;


namespace CPUTest
{
    internal class CSolution
    {
        [DllImport("Solution.dll")]
        public  static extern void Insert_Sort(int[] ary1, int size);//size为完整长度
        [DllImport("Solution.dll")]
        public static extern int Mid_Search(int[] ary1, int size, int num1);
        [DllImport("Solution.dll")]
        public static extern void AryBuild(int[] ary1, int len1, int[] ary2, int len2, int[] ary3);
        [DllImport("Solution.dll")]
        public static extern void Merge_Sort(int[] ary1, int size);
        [DllImport("Solution.dll")]
        public static extern int   Int_Test(int times,out int usedTime);//int32随机整数测试;
        [DllImport("Solution.dll")]
        public static extern double  Float_Test(int times, out int usedTime);//double/float随机浮点测试
        [DllImport("Solution.dll")]
        public static extern double  Newton_Sqrt(double x, int y);//牛顿公式开方
        [DllImport("Solution.dll")]
        public static extern  double T_Sqrt(double x);//Talor多项式
        [DllImport("Solution.dll")]
        public static extern int   SuperPi(int[] ary1, int size);//整数求PI
        [DllImport("Solution.dll")]
        public static extern int   Int_MatrixMulti(int[] Lary, int m, int n, int[] Rary, int p, int[] Ary);//整数矩阵乘法
        [DllImport("Solution.dll")]
        public static extern int   Double_MatrixMulti(double[] Lary, int m, int n, double[] Rary, int p, double[] Ary);//浮点矩阵乘法
        [DllImport("Solution.dll")]
        public static extern void IssueTest(int[] resultAry);//issue测试,1-40
        [DllImport("Solution.dll")]
        public static extern void CacheTest(int[] resultAry);//缓存测试,1-21
       [DllImport("Solution.dll")]
        public static extern void List_Test(int[] resultAry);//链表访存
        [DllImport("Solution.dll")]
        public static extern int renderTest(int size);//渲染
        [DllImport("Solution.dll")]
        public static extern int imageDeal(int x, int y);//2d图像（原始边长*300，变换倍数*1.5）
        
        //b树操作——————————————————————————   
        [DllImport("Solution.dll")]
        public static extern void   Btree_Sort(int[] ary1,int size,bool keep);
        [DllImport("Solution.dll")]
        public static extern void   Btree_Create(int[] ary1, int size);
        [DllImport("Solution.dll")]
        public static extern void   Btree_Insert(int seeds);
        [DllImport("Solution.dll")]
        public static extern bool   Btree_Find(int field);
        [DllImport("Solution.dll")]
        public static extern int    Btree_Count();
        [DllImport("Solution.dll")]
        public static extern void   Btree_Clean();
        [DllImport("Solution.dll")]
        public static extern void   Btree_Print(int[] ary1);
        [DllImport("Solution.dll")]
        public static extern bool   Btree_Delete(int x);
        [DllImport("Solution.dll")]
        public static extern int TalorSeries_Test(int times);

        //单链表操作————————————————————————————————
        [DllImport("Solution.dll")]
        public static extern void   Create_List(int[] ary, int size);
        [DllImport("Solution.dll")]
        public static extern void   List_Append(int x);
        [DllImport("Solution.dll")]
        public static extern void   List_Insert(int preNode, int nextNode);
        [DllImport("Solution.dll")]
        public static extern int    List_Count();
        [DllImport("Solution.dll")]
        public static extern void   List_Print(int[] ary, int size);
        [DllImport("Solution.dll")]
        public static extern void   List_Search(int x);
        [DllImport("Solution.dll")]
        public static extern void   List_Delete(int delenode);
        [DllImport("Solution.dll")]
        public static extern void   List_Clean();

        //双链表操作----------------------------------------
        [DllImport("Solution.dll")]
        public static extern void   TwowayList_Create(int[] ary,int size);
        [DllImport("Solution.dll")]
        public static extern void   TwowayList_Append(int x);
        [DllImport("Solution.dll")]
        public static extern void   TwowayList_Print(int[] ary);
        [DllImport("Solution.dll")]
        public static extern int   TwowayList_Count();
        [DllImport("Solution.dll")]
        public static extern bool   TwowayList_Search(int x);
        [DllImport("Solution.dll")]
        public static extern void   TwowayList_Headin(int x);
        [DllImport("Solution.dll")]
        public static extern void   TwowayList_Headde();
        [DllImport("Solution.dll")]
        public static extern void   TwowayList_Clean();
        [DllImport("Solution.dll")]
        public static extern void   TwowayList_Dele(int x);
        [DllImport("Solution.dll")]
        public static extern  void   TwowayList_Insert(int x1, int x2);
        [DllImport("Solution.dll")]
        public static extern  void   TwowayList_Tailde();

        /*—————————————队列（单链表实现）——————————*/
        [DllImport("Solution.dll")]
        public static extern  void   Queue_Ini();
        [DllImport("Solution.dll")]
        public static extern void   Queue_Push(int x);
        [DllImport("Solution.dll")]
        public static extern bool   Queue_Pop(out int x);
        [DllImport("Solution.dll")]
        public static extern bool   Queue_Peek(out int x);
        [DllImport("Solution.dll")]
        public static extern  void   Queue_Clear();

        /*————————————栈（数组）—————————————*/
        [DllImport("Solution.dll")]
        public static extern void   Stack_Create(int x);
        [DllImport("Solution.dll")]
        public static extern void   Stack_Clear(int x);
        [DllImport("Solution.dll")]
        public static extern void   Stack_Close();
        [DllImport("Solution.dll")]
        public static extern  void   Stack_Push(int x);
        [DllImport("Solution.dll")]
        public static extern bool   Stack_Pop(out int x);
        [DllImport("Solution.dll")]
        public static extern bool   Stack_Peek(out int x);

        /*———————————sseavx测试—————————————————*/

        [DllImport("test1.dll")]
        public static extern long intia32();
        [DllImport("test1.dll")]
        public static extern long doubleia32();
        [DllImport("test1.dll")]
        public static extern long double4sse();
        [DllImport("test1.dll")]
        public static extern long double2sse();
        [DllImport("test1.dll")]
        public static extern long double1sse();
        [DllImport("test1.dll")]
        public static extern long int1sse();
        [DllImport("test1.dll")]
        public static extern long int2sse();
        [DllImport("test1.dll")]
        public static extern long int4sse();
        [DllImport("test1.dll")]
        public static extern long double1avx();
        [DllImport("test1.dll")]
        public static extern long double2avx();
        [DllImport("test1.dll")]
        public static extern long double4avx();
        [DllImport("test1.dll")]
        public static extern long double4fma();
        [DllImport("test1.dll")]
        public static extern long double1fma();
      //[DllImport("test1.dll")]
        //public static extern long Double_4SSEMAX();
    }

    internal class multiThreadTest//多线程测试
    {
        public static long esplisedTime=0;
        private static object locker=new object();
        private static void ValueIn(long x)
        {
            lock(locker)
            {
                esplisedTime += x;
            }
        }
        public static void renderTest()
        {
            long t1 = TickCount.GetTickCount();
            CSolution.renderTest(2);
            t1 = TickCount.GetTickCount() - t1;
            ValueIn(t1);
        }
        public static void RGBInsert()
        {
            long t1 = TickCount.GetTickCount();
            CSolution.imageDeal(1, 1);
            CSolution.imageDeal(1, 1);
            t1 = TickCount.GetTickCount() - t1;
            ValueIn(t1);
        }
        public static void Inttest()
        {
            int x1;
            CSolution.Int_Test(5, out x1);
            ValueIn(x1);
        }
        public static void Floattest()
        {
            int x2;
            CSolution.Float_Test(15, out x2);
            ValueIn(x2);
        }
        public static void IntMax()
        {
            int m = 300, n = 300, p = 300;
            var ary2 = AryDeal.intBuild(0, m * n);
            var ary3 = AryDeal.intBuild(0, n * p);
            var ary4 = new int[m * p];
            long t1 = 0;
            for (var i = 0; i < 120; i++)
                t1 += CSolution.Int_MatrixMulti(ary2, m, n, ary3, p, ary4);
            ValueIn(t1);
        }
        public static void FloatMax()
        {
            int m = 300, n = 300, p = 300;
            var ary2 = AryDeal.floatBuild(0, m * n);
            var ary3 = AryDeal.floatBuild(0, n * p);
            var ary4 = new double[m * p];
            long t1 = 0;
            for (var i = 0; i < 120; i++)
                t1 += CSolution.Double_MatrixMulti(ary2, m, n, ary3, p, ary4);
            ValueIn(t1);
        }
    }

    internal class DouthreadTest//双线程框架
    {
        private ManualResetEvent MRE = new ManualResetEvent(false);
        private AutoResetEvent ARE = new AutoResetEvent(false);
        private static object locker = new object();
        private int OK = 0;
        public delegate void threaddelegate1();
        public delegate long threaddelegate2();
        public threaddelegate2[] threadtask2;
        public threaddelegate1[] threadtasks=new threaddelegate1[2];
        //string[] threadcore=new string[2];//设置核心所在线程
        public long[] eslipsedtimes = new long[2];
        public void Start()
        {
            var t1 = new Thread(fstTask);
            t1.Start();
            var t2 = new Thread(scdTask);
            t2.Start();
            Thread.Sleep(1000);
            MRE.Set();
            ARE.WaitOne();
        }
        public void Start2()
        {
            var t=new Thread[2];
            t[0] = new Thread(tdtk1);
            t[1] = new Thread(tdtk2);
            t[0].Start();
            t[1].Start();
            Thread.Sleep(1000);
            MRE.Set();
            ARE.WaitOne();
        }
        public void reset()
        {
            OK = 0;
        }
        private void fstTask()
        {           
            ThreadControl.MyThreadToCore("010000");
            MRE.WaitOne();
            threadtasks[0]();
            exitSign();
        }
        private void scdTask()
        {
            ThreadControl.MyThreadToCore("100000");
            MRE.WaitOne();
            threadtasks[1]();
            exitSign();
        }
        private void tdtk1()
        {
          ThreadControl.MyThreadToCore("010000");
           MRE.WaitOne();
            eslipsedtimes[0]=threadtask2[0]();
            exitSign();
        }
        private void tdtk2()
        {
            ThreadControl.MyThreadToCore("100000");
            MRE.WaitOne();
            eslipsedtimes[1] = threadtask2[1]();
            exitSign();
        }
        private void exitSign()
        {
            lock(locker)
            {
                OK++;
                if (OK != 2)
                    return;
            ARE.Set();
            OK = 0;
            }
        }
    }

    internal class Ctest
    {
        public static long Btree_Test()
        {
            long t1;
            var testAry = AryDeal.intBuild(0,30000);
            t1 = TickCount.GetTickCount();
            CSolution.Btree_Create(testAry, testAry.Length);
            for (var i = 0; i < 30000; ++i)
            {
                CSolution.Btree_Insert(10000 - i);
                CSolution.Btree_Find(i);
                CSolution.Btree_Delete(i);
            }
            var rltAry=new int[CSolution.Btree_Count()];
            CSolution.Btree_Print(rltAry);
            CSolution.Btree_Clean();
            return TickCount.GetTickCount() - t1;
        }
        public static long Btree_Test(int arysize,int inserttimes,int findtimes,int deletimes)
        {
            long t1;
            var testAry = AryDeal.intBuild(0, arysize);
            t1 = TickCount.GetTickCount();
            CSolution.Btree_Create(testAry, testAry.Length);
            for (var i = 0; i < inserttimes; ++i)
                CSolution.Btree_Insert(inserttimes - i);
            for (var i = 0; i < findtimes; ++i)
                CSolution.Btree_Find(i);
            for (var i = 0; i < deletimes; ++i)
                CSolution.Btree_Delete(i);
            CSolution.Btree_Clean();
            return TickCount.GetTickCount() - t1;
        }
        public static long Onewaychainlist_Test()
        {
            long t1;
            var testary = AryDeal.intBuild(0,10000);
            t1 = TickCount.GetTickCount();
            CSolution.Create_List(testary, testary.Length);
            for (var i = 0; i < 10000; ++i)
            {
                CSolution.List_Append(i);
                CSolution.List_Search(i);
                CSolution.List_Delete(i);
                CSolution.List_Insert(i, i);
            }
            var rltary = new int[CSolution.List_Count()];
            CSolution.List_Print(rltary, rltary.Length);
            CSolution.List_Clean();
            return TickCount.GetTickCount() - t1; 
        }
        public static long Onewaychainlist_Test(int arysize,int appendtimes,int deletimes,
            int inserttimes,int findtimes)
        {
            long t1;
            var testary = AryDeal.intBuild(0,arysize);
            t1 = TickCount.GetTickCount();
            CSolution.Create_List(testary, testary.Length);
            for (var i = 0; i < appendtimes;++i)
                CSolution.List_Append(i);
            for (var i = 0; i < deletimes; ++i)
                CSolution.List_Delete(i);
            for (var i = 0; i < inserttimes; ++i)
                CSolution.List_Insert(i,i);
            for (var i = 0; i < findtimes; ++i)
                CSolution.List_Search(i);      
            CSolution.List_Clean();
            return TickCount.GetTickCount() - t1; 
        }
        public static long Twowaychainlist_Test()
        {
            long t1;
            var ary1 = AryDeal.intBuild(0,20000);
            t1 = TickCount.GetTickCount();
            CSolution.TwowayList_Create(ary1, ary1.Length);
            for (var i = 0; i <20000; ++i)
            {
                CSolution.TwowayList_Headin(i);
                CSolution.TwowayList_Headde();
                CSolution.TwowayList_Append(i);
                CSolution.TwowayList_Tailde();
                CSolution.TwowayList_Search(i);
                CSolution.TwowayList_Dele(i);
            }
            var rltary = new int[CSolution.TwowayList_Count()];
            CSolution.TwowayList_Print(rltary);
            CSolution.TwowayList_Clean();
            return TickCount.GetTickCount()-t1;
        }
        public static long Twowaychainlist_Test(int arySize,int headdeTimes,int headinTimes,
            int appendTimes,int taildeTimes,int findTimes,int inTimes,int deTimes)
        {
            long ticks;
            var ary1 = AryDeal.intBuild(0, arySize);
            ticks = TickCount.GetTickCount();
            CSolution.TwowayList_Create(ary1, ary1.Length);
            for (var i = 0; i < headdeTimes; ++i)
                CSolution.TwowayList_Headin(i);
            for (var i = 0; i < headinTimes; ++i)
                CSolution.TwowayList_Headde();
            for (var i = 0; i < appendTimes; ++i)
                CSolution.TwowayList_Append(i);
            for (var i = 0; i < taildeTimes; ++i)
                CSolution.TwowayList_Tailde();
            for (var i = 0; i < findTimes; ++i)
                CSolution.TwowayList_Search(i);
            for (var i = 0; i < inTimes; ++i)
                CSolution.TwowayList_Insert(i, i);
            for (var i = 0; i < deTimes; ++i)
                CSolution.TwowayList_Dele(i);
            CSolution.TwowayList_Clean();
            return TickCount.GetTickCount() - ticks;
        }
        public static long Queue_Test()
        {
            long t1;
            int x;
            t1 = TickCount.GetTickCount();
            CSolution.Queue_Ini();
            CSolution.Queue_Push(1);
            for (var i = 0; i < 40000; ++i)
            {
                CSolution.Queue_Push(i);
                CSolution.Queue_Peek(out x);
                CSolution.Queue_Pop(out x);
            }
            CSolution.Queue_Clear();
            return TickCount.GetTickCount() - t1;
        }
        public static long Queue_Test(int t1,int t2,int t3)
        {
            long ticks;
            int x;
            ticks = TickCount.GetTickCount();
            CSolution.Queue_Ini();
            for (var i = 0; i < t1; ++i)
                CSolution.Queue_Push(i);
            for(var i=0;i < t2;++i)
                CSolution.Queue_Pop(out x);
            for (var i = 0; i < t3; ++i)
                CSolution.Queue_Peek(out x);
            CSolution.Queue_Clear();
            return TickCount.GetTickCount() - ticks;

        }
        public static long Stack_Test()
        {
                long t1;
                int x;
                t1 = TickCount.GetTickCount();
                CSolution.Stack_Create(10000000);
                for (var i = 0; i < 10000000; ++i)
                {
                    CSolution.Stack_Push(i);
                    CSolution.Stack_Peek(out x);
                    CSolution.Stack_Pop(out x);
                }
                CSolution.Stack_Close();
                return TickCount.GetTickCount() - t1;
           
        }
        public static long Stack_Test(int stackSize,int pushTimes,int peekTimes,int popTimes)
        {
            long ticks;
            int x;
            ticks = TickCount.GetTickCount();
            CSolution.Stack_Create(stackSize);
            for (var i = 0; i < pushTimes; ++i)
                CSolution.Stack_Push(i);
            for (var i = 0; i < peekTimes; ++i)
                CSolution.Stack_Peek(out x);
            for (var i = 0; i < popTimes; ++i)
                CSolution.Stack_Pop(out x);
            CSolution.Stack_Close();
            return TickCount.GetTickCount() - ticks;
        }
    }
 /*   class aryLocker
    {
        private static object locker = new object();
        private static int[] ary1;
        public aryLocker(int len1)
        {
            ary1 = new int[len1];
        }
        public void WriteIn(int[] childary,int start1)
        {
            lock(locker)
            {
                for(int i=1;i<childary.Length;i++)
                {
                    ary1[start1] = childary[i];
                    ++start1;
                }
            }
        }
        public int[] ReadOut()
        {
            lock(locker)
            {
                return ary1;
            }
        }

    }
    /*
    class MultiThreadSort
    {
        private static int[] BaseAry;
        private static int BaseLength;
        private int[] childary;
        private int childlength;
        private static object locker = new object();
        public MultiThreadSort(int[] ary1,int len1,byte types)
        {
            BaseAry = ary1;
            BaseLength = len1;
            if(types==1)
            {
                childlength=(BaseLength-1)/2+1;
                childary=new int[childlength];
                for(int i=1;i<=childlength-1;i++)
                {
                    childary[i] = BaseAry[i];
                }
            }
            else
            {
                childlength = (BaseLength - (BaseLength - 1) / 2) + 1;
                childary = new int[childlength];
                int start1 = (BaseLength - 1) / 2 + 1;
                for(int i=start1;i<=childlength-1;i++)
                {
                    childary[i] = BaseAry[i];
                }
            }
        }
        public void Sort()
        {
            SortSearch_C.Merge_Sort(childary, childlength);
            lock(locker)
            {

            }
        }
    }
  /*  class Test1//反射调用
    {
       
        public static void Ac(object s1,int[] ary1)
        {
            Type tp = s1.GetType();
            object k1 = Activator.CreateInstance(tp);
            System.Reflection.MethodInfo met = tp.GetMethod("Insert_Sort");
            met.Invoke(k1, new object[] { ary1, ary1.Length });
        }
    }
   */
    //namespace CSharp_002_回调机制
    //{
    //    public partial class frmMain : Form
    //    {
    //        //定义回调
    //        private delegate void delegateA(int value);
    //        //声明回调
    //        private static delegateA deleageB = new delegateA(test2);


    //        private void btnStart_Click(object sender, EventArgs e)
    //        {
    //            //初始化回调
    //            Thread t1 = new Thread(test1);
    //            t1.Start();
    //        }

    //        //设置进度条2的值 的线程
    //        private static void test1()
    //        {
    //                ProgressB2.Invoke(deleageB, i);
    //        }
    //        //设置进度条2的值 被委托的方法
    //        private static void test2(int value)
    //        {
    //            ProgressB2.Value = value;
    //        }

    //    }
    //}
}
