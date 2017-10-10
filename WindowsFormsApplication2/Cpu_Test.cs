using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CPUTest
{
    internal class CsharpTest
    {
        private struct CacheVol
        {
            public int Steps;
            public string Vol;
        }

        public static void CacheTest()
        {
            var b = new StreamWriter(Application.StartupPath + @"\cacheTest.txt", true);
            var a = new Random();
            var stepAry = new CacheVol[22];
            stepAry[1].Steps = 256;
            stepAry[1].Vol = "1kb";
            stepAry[2].Steps = 2048;
            stepAry[2].Vol = "8kb";
            stepAry[3].Steps = 4096;
            stepAry[3].Vol = "16kb";
            stepAry[4].Steps = 8192;
            stepAry[4].Vol = "32kb";
            stepAry[5].Steps = 16384;
            stepAry[5].Vol = "64kb";
            stepAry[6].Steps = 32768;
            stepAry[6].Vol = "128kb";
            stepAry[7].Steps = 131072;
            stepAry[7].Vol = "512kb";
            stepAry[8].Steps = 262144;
            stepAry[8].Vol = "1mb";
            stepAry[9].Steps = 524288;
            stepAry[9].Vol = "2mb";
            stepAry[10].Steps = 786432;
            stepAry[10].Vol = "3mb";
            stepAry[11].Steps = 1048576;
            stepAry[11].Vol = "4mb";
            stepAry[12].Steps = 1572864;
            stepAry[12].Vol = "6mb";
            stepAry[13].Steps = 2097152;
            stepAry[13].Vol = "8mb";
            stepAry[14].Steps = 2621440;
            stepAry[14].Vol = "10mb";
            stepAry[15].Steps = 3145728;
            stepAry[15].Vol = "12mb";
            stepAry[16].Steps = 3670016;
            stepAry[16].Vol = "14mb";
            stepAry[17].Steps = 4194304;
            stepAry[17].Vol = "16mb";
            stepAry[18].Steps = 5242880;
            stepAry[18].Vol = "20mb";
            stepAry[19].Steps = 7864320;
            stepAry[19].Vol = "30mb";
            stepAry[20].Steps = 10485760;
            stepAry[20].Vol = "40mb";
            stepAry[21].Steps = 13107200;
            stepAry[21].Vol = "50mb";
            for (var j = 1; j <= stepAry.Length - 1; j++)
            {
                var step1 = stepAry[j].Steps;
                var ar1 = new int[step1];
                for (var i = 0; i < ar1.Length; i++)
                {
                    ar1[i] = a.Next(100);
                }
                var t1 = Environment.TickCount;
                for (var k = 0; k < 100; k++)
                {
                    for (var i = 0; i < ar1.Length; i += 16)
                    {
                        ar1[i] = 1;
                    }
                }
                b.WriteLine(stepAry[j].Vol + "," + (System.Environment.TickCount - t1).ToString());
            }
            b.Close();
            return;
        }

        public static void issueTest() 
        {
            var sw = new StreamWriter(Application.StartupPath + @"\issueTest.txt", true);
            int times;
            var resultAry = new string[41];
           int a1=1,a2=2,a3=3,a4=4,a5=5,a6=6,a7=7,a8=8,
               a9=9,a10=0,a11=-1,a12=-2,a13=-3,a14=-4,a15=-5,
               a16=-6,a17=-7,a18=-8,a19=-9,a20=-20;
           times = System.Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//1
           {
               a1 += 1;
      
           }
           resultAry[1] = "1,"+(Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//2
           {
               a1 += 1;
               a1 -= 2;
      
           }
           resultAry[2] = "2," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//3
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;

           }
           resultAry[3] = "3," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//4
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
   
           }
           resultAry[4] = "4," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//5
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
     
           }
           resultAry[5] = "5," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//6
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
  
           }
           resultAry[6] = "6," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//7
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
       
           }
           resultAry[7] = "7," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//8
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
         
           }
           resultAry[8] = "8," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//9
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
       
           }
           resultAry[9] = "9," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//10
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
     
           }
           resultAry[10] = "10," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//11
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
      
           }
           resultAry[11] = "11," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//12
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
               a1 -= 12;
     
           }
           resultAry[12] = "12," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//13
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
               a1 -= 12;
               a1 += 13;
        
           }
           resultAry[13] = "13," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//14
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
               a1 -= 12;
               a1 += 13;
               a1 -= 14;
        
           }
           resultAry[14] = "14," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//15
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
               a1 -= 12;
               a1 += 13;
               a1 -= 14;
               a1 += 15;
         
           }
           resultAry[15] = "15," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//16
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
               a1 -= 12;
               a1 += 13;
               a1 -= 14;
               a1 += 15;
               a1 -= 16;
        
           }
           resultAry[16] = "16," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//17
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
               a1 -= 12;
               a1 += 13;
               a1 -= 14;
               a1 += 15;
               a1 -= 16;
               a1 += 17;
           
           }
           resultAry[17] = "17," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)//18
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
               a1 -= 12;
               a1 += 13;
               a1 -= 14;
               a1 += 15;
               a1 -= 16;
               a1 += 17;
               a1 -= 18;
            
           }
           resultAry[18] = "18," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
           for (var i = 0; i <= 70000000; i++)  //19
           {
               a1 += 1;
               a1 -= 2;
               a1 += 3;
               a1 -= 4;
               a1 += 5;
               a1 -= 6;
               a1 += 7;
               a1 -= 8;
               a1 += 9;
               a1 -= 10;
               a1 += 11;
               a1 -= 12;
               a1 += 13;
               a1 -= 14;
               a1 += 15;
               a1 -= 16;
               a1 += 17;
               a1 -= 18;
               a1 += 19;
           }
           resultAry[19] = "19," + (Environment.TickCount - times).ToString();
           times = Environment.TickCount;
            for(var i=0;i<=70000000;i++)//20
            {
                a1 +=1;
                a1 -=2;
                a1 += 3;
                a1 -= 4;
                a1 += 5;
                a1 -= 6;
                a1 += 7;
                a1 -= 8;
                a1 += 9;
                a1 -= 10;
                a1 += 11;
                a1 -= 12;
                a1 += 13;
                a1 -= 14;
                a1 += 15;
                a1 -= 16;
                a1 += 17;
                a1 -= 18;
                a1 += 19;
                a1 -= 20;
            }
            resultAry[20] = "20," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//1
            {
                a1 += 1;
            }
            resultAry[21] = "new 1," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//2
            {
                a1 += 1;
                a2 -= 2;
            }
            resultAry[22] = "2," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//3
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
            }
            resultAry[23] = "3," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//4
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
            }
            resultAry[24] = "4," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//5
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
            }
            resultAry[25] = "5," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//6
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;  
            }
            resultAry[26] = "6," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//7
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
            }
            resultAry[27] = "7," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//8
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
            }
            resultAry[28] = "8," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//9
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
            }
            resultAry[29] = "19," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//10
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
            }
            resultAry[30] = "10," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//11
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
            }
            resultAry[31] = "11," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//12
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
            }
            resultAry[32] = "12," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//13
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
                a13 += 13;
            }
            resultAry[33] = "13," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//14
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
                a13 += 13;
                a14 -= 14;
            }
            resultAry[34] = "14," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//15
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
                a13 += 13;
                a14 -= 14;
                a15 += 15;
            }
            resultAry[35] = "15," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//16
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
                a13 += 13;
                a14 -= 14;
                a15 += 15;
                a16 -= 16;
            }
            resultAry[36] = "16," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//17
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
                a13 += 13;
                a14 -= 14;
                a15 += 15;
                a16 -= 16;
                a17 += 17;
            }
            resultAry[37] = "17," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//18
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
                a13 += 13;
                a14 -= 14;
                a15 += 15;
                a16 -= 16;
                a17 += 17;
                a18 -= 18;
            }
            resultAry[38] = "18," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//19
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
                a13 += 13;
                a14 -= 14;
                a15 += 15;
                a16 -= 16;
                a17 += 17;
                a18 -= 18;
                a19 += 19;
            }
            resultAry[39] = "19," + (Environment.TickCount - times).ToString();
            times = Environment.TickCount;
            for (var i = 0; i <= 70000000; i++)//20
            {
                a1 += 1;
                a2 -= 2;
                a3 += 3;
                a4 -= 4;
                a5 += 5;
                a6 -= 6;
                a7 += 7;
                a8 -= 8;
                a9 += 9;
                a10 -= 10;
                a11 += 11;
                a12 -= 12;
                a13 += 13;
                a14 -= 14;
                a15 += 15;
                a16 -= 16;
                a17 += 17;
                a18 -= 18;
                a19 += 19;
                a20 -= 20;
            }
            resultAry[40] = "20," + (Environment.TickCount - times).ToString();
            for(var i=1;i<resultAry.Length;i++)
            {
                sw.WriteLine(resultAry[i]);
            }
            sw.Close();
    }
   /*     public static void Issue_Test() //判断cpu的指令级并行，但是对数组的访问时间超过运算时间而失败；
        {
            StreamWriter sw=new StreamWriter(@"F:\Issue_Test.txt");
            int[] ary1 = new int[30];
            int crtTime = Environment.TickCount;
            for (int times = 1; times < 10000000;times++ )
            {
               for (int i = 1; i <= 30; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        ary1[j] += 1;
                    }
                }
            }       
            sw.WriteLine((Environment.TickCount - crtTime).ToString());

            crtTime = Environment.TickCount;
            for (int times = 1; times < 10000000;times++ )
            {
                for (int i = 1; i <= 30; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        ary1[0] -= 1;
                    }
                }
            }
           sw.WriteLine((Environment.TickCount-crtTime).ToString());
           sw.Close();
           return;
        }
   /*     public static double piCalculate(int times)//高斯勒让德算法的原型
        {
   
            double a1 = 1, b1 = 1 / Math.Sqrt(2), t1 = 0.25, p1 = 1;
            double an, bn, tn, pn;
            for (int i = 1; i <= times;i++ )   
            {
                an = (a1 + b1) / 2;
                bn = Math.Sqrt(a1 * b1);
                tn = t1 - p1*(Math.Pow((an - a1),2));
                pn = 2 * p1;
                a1 = an;
                b1 = bn;
                t1 = tn;
                p1 = pn;
            }
            return Math.Pow((a1 + b1), 2) / (4 * t1);
        }
        /*
         long a=10000,b=0,c=2800,d,e,f[2801],g;  
void main()  
{ printf("%d",b);  
for(;b!=c;)  
{  
f[b]=a/5;  
b++;  
}  
for(; d=0,g=c*2; c-=14,printf("%.4d",e+d/a),e=d%a)  
for(b=c;d+=f[b]*a,f[b]=d%--g,d/=g--,--b;d*=b);  
}  
         */
        /*
         * 牛顿法计算开平方：计算公式如下
        Xn+1=1/2(Xn+S/Xn)
         */
        public static double  Newton_Sqrt(double x,int y)
        {
            
            double k = x,l=Math.Pow(10,-y);
            do
            {
               k=(k+x/k)/2;
            }while(Math.Abs(k*k-x)>l);
            return k;
        }
        /*
         * 泰勒级数计算：F(x)=f(a)+f'(a)(x-a)+f"(a)*(x-a)^2/2!+……
         */
        private static double Talor_Sqrt(double x,int y)
        {
            double sum=0, cofffe=1, factorial=1, xpower=1, term=1,l=Math.Pow(10,-y);
            var i = 0;
            do
            {
                sum += term;
                cofffe *= (0.5 - i);
                factorial *= (i + 1);
                xpower *= (x - 1);
                term = cofffe * xpower / factorial;
                i++;
            } while (Math.Abs(term) > l);
            return sum;
        }
        public static double TSqrt(double x)//开方运算
        {
            double cret = 1;
            while(x>=2)
            {
                x /= 4;
                cret *= 2;
            }
            return Talor_Sqrt(x,4) * cret;
        }
        public static void Pi_Caculate(int arysize)//数组大小和位数
        {
            var size = arysize*3;
            var sw = new StreamWriter(@"E:\pi.txt");
            var x = new int[size];
            var z = new int[size];
            int a = 1, b = 3, c, d, run = 1, cnt = 0;
            x[1] = 2;
            z[1] = 2;
            while((run!=0) && (++cnt<size))
            {
                d = 0;
                for(var i=size-1;i>0;i--)
                {
                    c = z[i] * a + d;
                    z[i] =(c % 10);
                    d = c / 10;
                }
                d = 0;
                for(var i=0;i<size;i++)
                {
                    c = z[i] + d * 10;
                    z[i] =(c / b);
                    d = c % b;
                }
                run = 0;
                for(var i=size-1;i>0;i--)
                {
                    c = x[i] + z[i];
                    x[i] =( c % 10);
                    x[i-1] +=(c / 10);
                    run |= z[i];
                }
                a++;
                b += 2;
            }
            for (var i = 1; i < size -1;i++ )
            {
                sw.Write(x[i].ToString());
            }
            sw.WriteLine("计算了" + cnt.ToString() + "次");
            sw.Close();
        }
    }
}
