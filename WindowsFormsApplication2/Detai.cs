using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace CPUTest
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Detai_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked || radioButton2.Checked)
            {
                MessageBox.Show("未选定");
                return;
            }
            Form1.Turbo();
            int a, b, c, d;
            long resulttime;
            if (radioButton1.Checked)
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox4.Text);
                c = int.Parse(textBox2.Text);
                d = int.Parse(textBox3.Text);
                resulttime = Ctest.Stack_Test(a, b, c, d);
            }
            else
            {
                a = int.Parse(textBox8.Text);
                b = int.Parse(textBox5.Text);
                c = int.Parse(textBox7.Text);
                d = int.Parse(textBox6.Text);
                resulttime = Ctest.Btree_Test(a, b, c, d);
            }
            label53.Text = resulttime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            int a, b, c, d, f, g, h,i;
            long resulttime;
            a = int.Parse(textBox24.Text);
            b = int.Parse(textBox23.Text);
            c = int.Parse(textBox22.Text);
            d = int.Parse(textBox10.Text);
            f = int.Parse(textBox18.Text);
            g = int.Parse(textBox29.Text);
            h = int.Parse(textBox28.Text);
            i = int.Parse(textBox27.Text);
            resulttime= Ctest.Twowaychainlist_Test(a, b, c, d, f, g, h, i);
            label50.Text=resulttime.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            int a, b, c, d, f, g,h,i;
            long tt;
            a = int.Parse(textBox11.Text);
            b = int.Parse(textBox12.Text);
            c = int.Parse(textBox14.Text);
            d = int.Parse(textBox17.Text);
            f = int.Parse(textBox15.Text);
            g = int.Parse(textBox21.Text);
            h = int.Parse(textBox20.Text);
            i = int.Parse(textBox19.Text);
            if(radioButton3.Checked)
            {    
                tt=Ctest.Onewaychainlist_Test(a,b,c,d,f);
            }
            else
            {
                tt=Ctest.Queue_Test(g,h,i);
            }
            label51.Text = tt.ToString();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            long tt;
            int a = int.Parse(textBox9.Text);
            double[] ary1 = AryDeal.floatBuild(0, a * a);
            double[] ary2 = AryDeal.floatBuild(0, a * a);
            double[] ary3 = AryDeal.floatBuild(0, a * a);
            for (int i = 0; i < a * a; ++i)
                ary3[i] = 0;
            tt = CSolution.Double_MatrixMulti(ary1, a, a, ary2, a, ary3);
            label41.Text = tt.ToString();
            
        }

        private void label38_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            long tt;
            int a = int.Parse(textBox16.Text);
            int[] ary1 = AryDeal.intBuild(0, a * a);
            int[] ary2 = AryDeal.intBuild(0, a * a);
            int[] ary3 = new int[a * a];
            for (int i = 0; i < a * a; ++i)
                ary3[i] = 0;
            tt = CSolution.Int_MatrixMulti(ary1, a, a, ary2, a, ary3);
            label47.Text = tt.ToString();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            int tt;
            CSolution.Int_Test(2, out tt);
            label46.Text = tt.ToString();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            long tt;
            int[] ary=AryDeal.intBuild(0,500);
            tt=CSolution.SuperPi(ary, ary.Length);
            label45.Text = tt.ToString();
        }

        private void label36_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            int tt;
            CSolution.Float_Test(2, out tt);
            label34.Text = tt.ToString();

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            long tt;
            int a=int.Parse(textBox25.Text);
            int[] ary1 = AryDeal.intBuild(1, a);
            tt = TickCount.GetTickCount();
            CSolution.Merge_Sort(ary1, ary1.Length);
            tt = TickCount.GetTickCount() - tt;
            label28.Text = tt.ToString();

        }

        private void label22_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            long tt;
            int a = int.Parse(textBox25.Text);
            int[] ary1 = AryDeal.intBuild(1, a);
            tt = TickCount.GetTickCount();
            CSolution.Insert_Sort(ary1, ary1.Length);
            tt = TickCount.GetTickCount() - tt;
            label54.Text = tt.ToString();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            int[] ary=new int[22];
            CSolution.CacheTest(ary);
            I_O.Write_In("cachetest", ary);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1.Turbo();
            int[] ary = new int[40];
            CSolution.IssueTest(ary);
            I_O.Write_In("issuetest", ary);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            multiThreadTest.esplisedTime = 0;
            DouthreadTest dtt = new DouthreadTest();
            string str1 = "单项双线程————";
            if (renda.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.renderTest;
                dtt.threadtasks[1] = multiThreadTest.renderTest;
                str1 += "光照渲染器";
            }
            else if (inttest.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.Inttest;
                dtt.threadtasks[1] = multiThreadTest.Inttest;
                str1 += "随机整数";
            }
            else if (floattest.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.Floattest;
                dtt.threadtasks[1] = multiThreadTest.Floattest;
                str1 += "随机浮点";
            }
            else if (rgbinsert.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.RGBInsert;
                dtt.threadtasks[1] = multiThreadTest.RGBInsert;
                str1 += "双线性插值";
            }
            else if (autossedble.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.FloatMax;
                dtt.threadtasks[1] = multiThreadTest.FloatMax;
                str1 += "自动sse浮点矩阵";
            }
            else if (autosseint.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.IntMax;
                dtt.threadtasks[1] = multiThreadTest.IntMax;
                str1 += "自动sse整数矩阵";
            }
            else if (sse4f.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.Double_4SSEMAX;
                dtt.threadtasks[1] = multiThreadTest.Double_4SSEMAX;
                str1 += "四路sse浮点矩阵";
            }
            else if (fourwaysseint.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.Int4SSE_MAX;
                dtt.threadtasks[1] = multiThreadTest.Int4SSE_MAX;
                str1 += "四路sse整数矩阵";
            }
            else if (avx4f.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.Double_4AVXMAX;
                dtt.threadtasks[1] = multiThreadTest.Double_4AVXMAX;
                str1 += "四路avx浮点矩阵";
            }
            else if (ia32dblmaxmul.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.Double_MaMulTest;
                dtt.threadtasks[1] = multiThreadTest.Double_MaMulTest;
                str1 += "ia32浮点矩阵";
            }
            else if (ia32intmaxmul.Checked)
            {
                dtt.threadtasks[0] = multiThreadTest.Int_MaMulTest;
                dtt.threadtasks[1] = multiThreadTest.Int_MaMulTest;
                str1 += "ia32整数矩阵";
            }
            else
            {
                return;
            }
            dtt.Start();
            listBox1.Items.Add(str1+"————"+dtt.eslipsedtimes[0].ToString()+","+dtt.eslipsedtimes[1]);
            multiThreadTest.esplisedTime = 0;
        }

        private void button9_Click(object sender, EventArgs e)   
        {
            multiThreadTest.esplisedTime = 0;
            string str1="单线程————";
            Thread t1;

            if (renda.Checked)
            {
                t1 = new Thread(multiThreadTest.renderTest);
                str1 += "渲染";
            }
            else if (inttest.Checked)
            {
                t1 = new Thread(multiThreadTest.Inttest);
                str1 += "随机整数";
            }
            else if (floattest.Checked)
            {
                t1 = new Thread(multiThreadTest.Floattest);
                str1 += "随机浮点";
            }
            else if (rgbinsert.Checked)
            {
                t1 = new Thread(multiThreadTest.RGBInsert);
                str1 += "双线性插值";
            }
            else if (autossedble.Checked)
            {
                t1 = new Thread(multiThreadTest.FloatMax);
                str1 += "自动sse浮点矩阵";
            }
            else if (autosseint.Checked)
            {
                t1 = new Thread(multiThreadTest.IntMax);
                str1 += "自动sse整数向量";
            }
            else if(sse4f.Checked)
            {
                t1 = new Thread();
                str1 += "四路sse浮点矩阵";
            }
                else if(fourwaysseint.Checked)
            {
                t1 = new Thread(multiThreadTest.Int4SSE_MAX);
                str1 += "四路sse整数矩阵";

            }
                else if(avx4f.Checked)
            {
                t1 = new Thread(multiThreadTest.Double_4AVXMAX);
                str1 += "四路avx浮点矩阵";
            }
                else if(ia32dblmaxmul.Checked)
            {
                t1 = new Thread(multiThreadTest.Double_MaMulTest);
                str1 += "ia32浮点矩阵";
            }
                else if(ia32intmaxmul.Checked)
            {
                t1 = new Thread(multiThreadTest.Int_MaMulTest);
                str1 +="ia32整数矩阵";
            }
            else
            {
                return;
            }
            t1.Start();
            t1.Join();
            listBox1.Items.Add(str1+"————"+multiThreadTest.esplisedTime);
            multiThreadTest.esplisedTime=0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            multiThreadTest.esplisedTime = 0;
            DouthreadTest dtt = new DouthreadTest();
            //dtt.threadtasks[0] = multiThreadTest.Int4SSE_MAX;
            //dtt.threadtasks[1] = multiThreadTest.Double_4SSEMAX;
            dtt.threadtasks[0] = multiThreadTest.Double_MaMulTest;
            dtt.threadtasks[1] = multiThreadTest.Int_MaMulTest;
            dtt.Start();
            listBox1.Items.Add("混合双线程自动sse浮点：" + dtt.eslipsedtimes[0].ToString() + "自动sse整数" + dtt.eslipsedtimes[1].ToString());
        }


        //多线程
        //private void button10_Click(object sender, EventArgs e)
        //{
        //    Thread[] t1=new Thread[6];
        //    if (renda.Checked)
        //    {
        //        for (int i = 0; i < 6;i++)
        //            t1[i] = new Thread(multiThreadTest.renderTest);
        //    }
        //    else if (inttest.Checked)
        //    {
        //        for (int i = 0; i < 6; i++)
        //          t1[i] = new Thread(multiThreadTest.Inttest);
        //    }
        //    else if (floattest.Checked)
        //    {
        //        for (int i = 0; i < 6; i++)
        //        t1[i] = new Thread(multiThreadTest.Floattest);
        //    }
        //    else if (rgbinsert.Checked)
        //    {
        //        for (int i = 0; i < 6; i++)
        //        t1[i] = new Thread(multiThreadTest.RGBInsert);
        //    }
        //    else if (autossedble.Checked)
        //    {
        //        for (int i = 0; i < 6; i++)
        //        t1[i] = new Thread(multiThreadTest.FloatMax);
        //    }
        //    else if (autosseint.Checked)
        //    {
        //        for (int i = 0; i < 6; i++)
        //        t1[i] = new Thread(multiThreadTest.IntMax);
        //    }
        //    else
        //    {
        //        return;
        //    }
        //    for (int i = 0; i < 6; i++)
        //      t1[i].Start();
        //    Thread.Sleep(10000);
        //    listBox1.Items.Add(multiThreadTest.esplisedTime);
        //    multiThreadTest.esplisedTime = 0;
        //}


    }
}
