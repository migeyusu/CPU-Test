using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace CPUTest
{
   
    public partial class Form1 : Form
    {
        private  delegate void UIdelegete();

        private UIdelegete testResult;
        private static int ProcessCount;
        private static int crtFreq;
        private int logicCores;
        private static Boolean go=true;
        private Series brush1 = new Series("frequency");//频率调制
        private static int freqInterval=2500;//频率抓取的间隔
        private  Thread td = new Thread(FreqGet);
        private static Queue<long> resultRecord=new Queue<long>();
       /*   #region//无边框移动
       private Point mouseOff;//鼠标移动位置变量
        private  bool leftFlag;//标记是否为左键
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
     #endregion     */

        public Form1()
        {
            InitializeComponent();
        }  
        public static void Turbo()  //让cpu睿频
        {
            CSolution.imageDeal(1,1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ary = { "Name", "NumberOfCores", 
                               "NumberOfLogicalProcessors" };
            ary = CpuInformation.InfoSearch(ary);
            CPUName.Text = ary[0];
            coreLabel.Text = ary[1];
            logicCores =int.Parse(ary[2]);
            logicCoreLabel.Text =ary[2];
            ProcessCount = int.Parse(ary[2]);
            MuityTestbtn.Text = ProcessCount + "线程测试";
            if (int.Parse(ary[2]) / int.Parse(ary[1]) == 1)
            {
                HTTestbtn.Text = "不支持超线程";
                HTTestbtn.Enabled = false;
            }
            Brush_Ready();
            crtFreq = CpuInformation.ClockSpeed();
            Chart_Draw();
            timer1.Enabled = true;
            td.Start();
            F_version.Text = RuntimeEnvironment.GetSystemVersion().ToString();
        }
        private static void FreqGet()//频率刷新
        {
            while(go)
            {
                crtFreq = CpuInformation.ClockSpeed();
                Thread.Sleep(freqInterval);
            }
            
        }
/*----------------界面更新---------------- */
        private void  Brush_Ready()
        {
            this.chart1.Legends.Clear();
            brush1.ShadowOffset =0;
            brush1.BorderWidth = 2;
            brush1.Color = Color.Blue;
            brush1.ChartType = SeriesChartType.Spline;
            chart1.Series.Add(brush1);
            chart1.ChartAreas[0].Position.Width = 100;
            chart1.ChartAreas[0].Position.Height = 100;
            chart1.ChartAreas[0].Position.X = 0;
            chart1.ChartAreas[0].Position.Y = 0;
        }
        private void Chart_Draw()
         {
             brush1.Points.AddY(crtFreq);
         }
        private void Chart_Reset()
         {
             chart1.Legends.Clear();
             chart1.Series["frequency"].Points.Clear();
             Chart_Draw();
         }
      private void  SinThreadTestResultFlash()
      {
          timer1.Interval = 3000;
          freqInterval = 3000;
          label5.Text=resultRecord.Dequeue().ToString();
          label31.Text=resultRecord.Dequeue().ToString();
          label35.Text = resultRecord.Dequeue().ToString();
          label24.Text = resultRecord.Dequeue().ToString();
          label32.Text = resultRecord.Dequeue().ToString(); 
          label36.Text = resultRecord.Dequeue().ToString();
          label26.Text = resultRecord.Dequeue().ToString();
          label33.Text = resultRecord.Dequeue().ToString();
          label22.Text = resultRecord.Dequeue().ToString(); 
          label67.Text = resultRecord.Dequeue().ToString();
          label60.Text = resultRecord.Dequeue().ToString(); 
          label58.Text = resultRecord.Dequeue().ToString(); 
          label7.Text = resultRecord.Dequeue().ToString(); 
          label51.Text = resultRecord.Dequeue().ToString();
          label3.Text = resultRecord.Dequeue().ToString();
          resultRecord.Clear(); 
          sTestbtn.Text = "单线程测试";
          HTTestbtn.Enabled = true;
          MuityTestbtn.Enabled = true;
          sTestbtn.Enabled = true;
      }
      private void  MulThreadTestResultFlash()
      {
          timer1.Enabled = true;
          //label52.Text=resultRecord.Dequeue().ToString();
          //label53.Text=resultRecord.Dequeue().ToString();
          //label42.Text=resultRecord.Dequeue().ToString();
          //label73.Text=resultRecord.Dequeue().ToString();
          //label43.Text=resultRecord.Dequeue().ToString();
          //label59.Text=resultRecord.Dequeue().ToString();
          resultRecord.Clear(); 
          MuityTestbtn.Text = ProcessCount+"线程测试";
          HTTestbtn.Enabled = true;
          MuityTestbtn.Enabled = true;
          sTestbtn.Enabled = true;
      }
        private void DouThreadtestResultFlash()
      {

          label62.Text =resultRecord.Dequeue().ToString();

           
          label61.Text =  resultRecord.Dequeue().ToString();

          
          label65.Text = resultRecord.Dequeue().ToString();

          label66.Text =  resultRecord.Dequeue().ToString();


          label12.Text =resultRecord.Dequeue().ToString();


          label19.Text =resultRecord.Dequeue().ToString();

           //二次叠加
          label62.Text +="/"+ resultRecord.Dequeue().ToString();


          label61.Text +="/"+ resultRecord.Dequeue().ToString();


          label65.Text += "/" + resultRecord.Dequeue().ToString();

          label66.Text += "/" + resultRecord.Dequeue().ToString();


          label12.Text += "/" + resultRecord.Dequeue().ToString();


          label19.Text += "/" + resultRecord.Dequeue().ToString();

          resultRecord.Clear();

          HTTestbtn.Enabled = true;
          MuityTestbtn.Enabled = true;
          sTestbtn.Enabled =true;
          HTTestbtn.Text = "超线程测试";
      }
      private void timer1_Tick(object sender, EventArgs e)//刷新cpu频率
      {
          Chart_Draw();
      }
/*------------------------测试----------------------- */

      public  void Single_ThreadTest()//单线程主函数
     {
         testResult = new UIdelegete(SinThreadTestResultFlash); 
         var freqRecord=new Queue<int>();
         ThreadControl.MyProcessHigh();
         long gg,t1;//时间记录
         int x1;
          Form1.Turbo();//提高cpu频率
          //栈操作,38mb考验内存和前端总线
         gg=Ctest.Stack_Test();
         resultRecord.Enqueue(gg);
          //树操作，117kb
         gg = Ctest.Btree_Test();
         resultRecord.Enqueue(gg);
          //pi，39kb
          var ary=new int[10000];
          gg = CSolution.SuperPi(ary, 10000);
          ary = null;
          resultRecord.Enqueue(gg);
          //随机整数
          CSolution.Int_Test(1, out x1);
          resultRecord.Enqueue(x1);
          freqRecord.Enqueue(crtFreq);
          //归并排序+二分查找，38mb
          var ary1 = AryDeal.intBuild(1,10000000);
          t1 = TickCount.GetTickCount();
          CSolution.Merge_Sort(ary1, ary1.Length);
          for (var i = 0; i < 100000; ++i)
              CSolution.Mid_Search(ary1, ary1.Length, i);
          t1 = TickCount.GetTickCount()-t1;
          ary1 = null;
          resultRecord.Enqueue(t1);
          freqRecord.Enqueue(crtFreq);
         //泰勒多项式
          gg = CSolution.TalorSeries_Test(100);
          resultRecord.Enqueue(gg);
          freqRecord.Enqueue(crtFreq);
          //随机浮点
          CSolution.Float_Test(3, out x1);
          resultRecord.Enqueue(x1);
          freqRecord.Enqueue(crtFreq);
          //双向链表，78kb
          gg=Ctest.Twowaychainlist_Test();
          resultRecord.Enqueue(gg);
          freqRecord.Enqueue(crtFreq);
          //单向链表，39kb
          gg = Ctest.Onewaychainlist_Test();
          resultRecord.Enqueue(gg);
          freqRecord.Enqueue(crtFreq);
          //队列，156kb
          gg = 0;
          for (var i = 0; i < 101;++i )
              gg += Ctest.Queue_Test();
          resultRecord.Enqueue(gg);
          freqRecord.Enqueue(crtFreq);
          //光照渲染器,2-3mb左右
          gg=CSolution.renderTest(1);
          resultRecord.Enqueue(gg);
          freqRecord.Enqueue(crtFreq);
          //2d图像缩放，1kb
          gg = CSolution.imageDeal(1,1);
          resultRecord.Enqueue(gg);
          freqRecord.Enqueue(crtFreq);
          //矩阵整数,1mb
          int m=300,n=300,p=300;
          var ary2 = AryDeal.intBuild(0,m*n);
          var ary3 = AryDeal.intBuild(0,n*p);
          var ary4 = new int[m*p];
          gg = 0;
          for (var i = 0; i < 30;i++ )
              gg+= CSolution.Int_MatrixMulti(ary2, m, n, ary3, p, ary4);
          ary2=null;
          ary3=null;
          ary4=null;
          resultRecord.Enqueue(gg);
          freqRecord.Enqueue(crtFreq);
          //浮点矩阵
          var ary5 = AryDeal.floatBuild(0, m * n);
          var ary6 = AryDeal.floatBuild(0, n * p);
          var ary7 = new double[m * p];
          gg = 0;
          for (var i = 0; i < 30;i++ )
              gg += CSolution.Double_MatrixMulti(ary5, m, n, ary6, p, ary7);
          resultRecord.Enqueue(gg);
          ary5 = null;
          ary6 = null;
          ary7 = null;
          freqRecord.Enqueue(crtFreq);
          gg=0;
          t1=freqRecord.Count;
          for (var i = 0; i < t1;++i )
          {
              gg += freqRecord.Dequeue();
          }
          resultRecord.Enqueue(gg / t1);
          this.Invoke(testResult);
     }
      public void Sin_Tdtest()//单线程副函数
      {
          multiThreadTest.esplisedTime = 0;
          multiThreadTest.Inttest();
          resultRecord.Enqueue(multiThreadTest.esplisedTime); 
          multiThreadTest.esplisedTime = 0;

          multiThreadTest.Floattest();
          resultRecord.Enqueue(multiThreadTest.esplisedTime); 
          multiThreadTest.esplisedTime = 0;

          multiThreadTest.RGBInsert();
          resultRecord.Enqueue(multiThreadTest.esplisedTime); 
          multiThreadTest.esplisedTime = 0;

          multiThreadTest.renderTest();
          resultRecord.Enqueue(multiThreadTest.esplisedTime); 
          multiThreadTest.esplisedTime = 0;

          multiThreadTest.FloatMax();
          resultRecord.Enqueue(multiThreadTest.esplisedTime); 
          multiThreadTest.esplisedTime = 0;

          multiThreadTest.IntMax();
          resultRecord.Enqueue(multiThreadTest.esplisedTime); 
          multiThreadTest.esplisedTime = 0;

      }

      private void Double_ThreadTest()
      {
          
          testResult = new UIdelegete(DouThreadtestResultFlash);
          var tdsin= new Thread(Sin_Tdtest);
          tdsin.Start();
          tdsin.Join();
          var dtt = new DouthreadTest();
          dtt.threadtasks[0] = multiThreadTest.Inttest;
          dtt.threadtasks[1] = multiThreadTest.Inttest;
          dtt.Start();
          dtt.reset();
          resultRecord.Enqueue(multiThreadTest.esplisedTime / 4);
          multiThreadTest.esplisedTime=0;
          //浮点
          dtt.threadtasks[0] = multiThreadTest.Floattest;
          dtt.threadtasks[1] = multiThreadTest.Floattest;
          dtt.Start();
          dtt.reset();
          resultRecord.Enqueue(multiThreadTest.esplisedTime / 4);
          multiThreadTest.esplisedTime=0;
          //rbg插值
          dtt.threadtasks[0] = multiThreadTest.RGBInsert;
          dtt.threadtasks[1] = multiThreadTest.RGBInsert;
          dtt.Start();
          dtt.reset();
          resultRecord.Enqueue(multiThreadTest.esplisedTime / 4);
          multiThreadTest.esplisedTime = 0;
          //渲染
          dtt.threadtasks[0] = multiThreadTest.renderTest;
          dtt.threadtasks[1] = multiThreadTest.renderTest;
          dtt.Start();
          dtt.reset();
          resultRecord.Enqueue(multiThreadTest.esplisedTime / 4);
          multiThreadTest.esplisedTime = 0;
          //浮点矩阵
          dtt.threadtasks[0] = multiThreadTest.FloatMax;
          dtt.threadtasks[1] = multiThreadTest.FloatMax;
          dtt.Start();
          dtt.reset();
          resultRecord.Enqueue(multiThreadTest.esplisedTime / 4);
          multiThreadTest.esplisedTime = 0;

          //整数矩阵
          dtt.threadtasks[0] = multiThreadTest.IntMax;
          dtt.threadtasks[1] = multiThreadTest.IntMax;
          dtt.Start();
          dtt.reset();
          resultRecord.Enqueue(multiThreadTest.esplisedTime / 4);
          multiThreadTest.esplisedTime = 0;
          this.Invoke(testResult);
      }

      private void MuityTestbtn_Click(object sender, EventArgs e)
      {
          HTTestbtn.Enabled = false;
          MuityTestbtn.Enabled = false;
          sTestbtn.Enabled = false;
          testResult = new UIdelegete(MulThreadTestResultFlash);
          MuityTestbtn.Text = "正在测试...";
          timer1.Enabled = false;
          freqInterval = 10000;
          var Tdk = new ThreadTask(ProcessCount);
          Tdk.ThreadReady();
          intStack.addAction = resultCal;
          var PCS=ProcessCount*ProcessCount;
          var ary1 = new int[ProcessCount];
          for (var i = 0; i < ProcessCount; ++i)
              ary1[i] = Tdk.TaskIn(multiThreadTest.renderTest, false);
          for (var i = 0; i < ProcessCount; ++i)
              Tdk.TaskStart(ary1[i]);
          resultRecord.Enqueue(multiThreadTest.esplisedTime / (PCS));
          multiThreadTest.esplisedTime = 0;

          for (var i = 0; i < ProcessCount; ++i)
              ary1[i] = Tdk.TaskIn(multiThreadTest.RGBInsert, false);
          for (var i = 0; i < ProcessCount; ++i)
              Tdk.TaskStart(ary1[i]);
          resultRecord.Enqueue(multiThreadTest.esplisedTime / (PCS));
          multiThreadTest.esplisedTime = 0;

          for (var i = 0; i < ProcessCount; ++i)
              ary1[i] = Tdk.TaskIn(multiThreadTest.Inttest, false);
          for (var i = 0; i < ProcessCount; ++i)
              Tdk.TaskStart(ary1[i]);
          resultRecord.Enqueue(multiThreadTest.esplisedTime / (PCS));
          multiThreadTest.esplisedTime = 0;

          for (var i = 0; i < ProcessCount; ++i)
              ary1[i] = Tdk.TaskIn(multiThreadTest.Floattest, false);
          for (var i = 0; i < ProcessCount; ++i)
              Tdk.TaskStart(ary1[i]);
          resultRecord.Enqueue(multiThreadTest.esplisedTime / (PCS));
          multiThreadTest.esplisedTime = 0;

          for (var i = 0; i < ProcessCount; ++i)
              ary1[i] = Tdk.TaskIn(multiThreadTest.IntMax, false);
          for (var i = 0; i < ProcessCount; ++i)
              Tdk.TaskStart(ary1[i]);
          resultRecord.Enqueue(multiThreadTest.esplisedTime / (PCS));
          multiThreadTest.esplisedTime = 0;

          for (var i = 0; i < ProcessCount; ++i)
              ary1[i] = Tdk.TaskIn(multiThreadTest.FloatMax, false);
          for (var i = 0; i < ProcessCount; ++i)
              Tdk.TaskStart(ary1[i]);
          resultRecord.Enqueue(multiThreadTest.esplisedTime / (PCS));
          multiThreadTest.esplisedTime = 0;


      }

      private void MultiBtn_Click(object sender, EventArgs e)
      {
          HTTestbtn.Enabled = false;
          MuityTestbtn.Enabled = false;
          sTestbtn.Enabled = false;
          HTTestbtn.Text = "正在测试...";
          var t1 = new Thread(Double_ThreadTest);
          t1.Start();
      }

        

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
          go = false;
          System.Environment.Exit(0);
      }
      private void downbtn1_Click_1(object sender, EventArgs e)
      {
          panel3.Visible = true;
      }

      private void sTestbtn_Click(object sender, EventArgs e)
      {
          HTTestbtn.Enabled = false;
          MuityTestbtn.Enabled = false;
          sTestbtn.Enabled = false;
          sTestbtn.Text = "正在测试....";;
          freqInterval = 500;;
          Chart_Reset();
          timer1.Interval = 500;
          timer1.Enabled = true;
          var t1 = new Thread(Single_ThreadTest);
          t1.Start();
          

      }
      private void resultCal()
      {

          var t1 = multiThreadTest.esplisedTime / (ProcessCount*ProcessCount);
          resultRecord.Enqueue(t1);
          //this.Invoke(testResult);
      }

        private void downbtn2_Click(object sender, EventArgs e)
      {
          panel3.Visible = false;
      }

      private void HTTestbtn_Click(object sender, EventArgs e)
      {

      }




    
    }
   /*
    static class Time_Count
    {
            public static long TC;
            //引用系统API
            [DllImport("Kernel32.dll")]
            private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
            [DllImport("Kernel32.dll")]
            private static extern bool QueryPerformanceFrequency(out long lpFrequency);
            private static long StartTime, StopTime;
            private static long Frequence;
            public static void  ReTime()//初始化
            {
                QueryPerformanceFrequency(out Frequence);
                StartTime = 0;
                StopTime = 0;
            }
            public static void Count_Start()
            {
                QueryPerformanceCounter(out StartTime);
                return;
            }
            public static  void Count_Stop()
            {
                QueryPerformanceCounter(out StopTime);
                return;
            }
            public static long TimeCount()
            {
               TC=Convert.ToInt64(1000 * ((double)(StopTime - StartTime) / (double)Frequence));
                return TC;
            }
    }
    */
}
