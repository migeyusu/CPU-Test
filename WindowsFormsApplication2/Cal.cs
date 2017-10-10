using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTest
{
    internal class AryDeal
    //所有数组默认从1开始起，最后为length+1
    {
        public static int[] intBuild(int start,int end)
        {
            var rnd=new Random();
            var ary1=new int[end];
            for(var i=start;i<end;i++)
            {
                ary1[i]=rnd.Next(10000);
            }
            return ary1; 
        }
        public static double[] floatBuild(int start, int end)
        {
            var rnd = new Random();
            var ary1 = new double[end + 1];
            for (var i = start; i <= end; i++)
            {
                ary1[i] = rnd.Next(10000)+0.1;
            }
            return ary1;
        }
        public static int[] insertSort(int[] ary1)  //从小到大排序
        {
            int ade, vals;
            for(var i=1;i<=ary1.Length-1;i++)
            {
                vals = ary1[i];
                ade = i;
                for(var j=i+1;j<=ary1.Length-1;j++)
                {
                    if (ary1[j]<vals)
                    {
                        vals = ary1[j];
                        ade = j;
                    }
                }
                ary1[ade] = ary1[i];
                ary1[i] = vals;
            }
            return ary1;
        }
        public static int[] quickSort(int[] ary1 )
        {

            return ary1;
        }
        public static int[] comSort(int [] ary1)  //从小到大排序
        {
            int j, i=2, hand1, hand2, hand3, hand4;
            var ary2=new int[ary1.Length];
            while(i<ary1.Length-1)
            {
                j = 1;//起始循环点
                while ((j+i-1)<=ary1.Length-1) //j+i/2表示左边位顶峰
                {
                   // int[] ary2 = new int[i+1];
                    hand1=j;   //左边位
                    hand2=j+i/2;//右边位
                    hand3=j;//复数组位
                    do
                    {
                 
                        if(ary1[hand1]>=ary1[hand2]) //依次赋值
                        {
                            ary2[hand3] = ary1[hand2];
                            hand2 += 1;
                            hand3 += 1;
                         
                        }
                        else
                        {
                            ary2[hand3] = ary1[hand1];
                            hand1 += 1;
                            hand3 += 1;
                        }
                    }while(hand1<=(j+i/2-1) && hand2<=(j+i-1));
                    if(hand2<=j+i-1)//表示右边仍然有值，返回原数组,如果左边没有值，就直接插回原数组
                    {
                        for(var s=j;s<=hand3-1;s++)
                        {
                            ary1[s] = ary2[s];
                        }                
                    }
                    else//左边有剩余值，右边没有
                    {
                        hand4 = hand3;//转移指针
                        for(var s=hand1;s<=j+i/2-1;s++)
                        {
                            ary1[hand4] = ary1[s];
                            hand4 += 1;
                        }
                       for(var s=j;s<=hand3-1;s++)
                       {
                           ary1[s] = ary2[s];
                       }
                    }
                    j = j + i;

                }
                i *= 2;
            }
            i = i / 2;
            hand1 = 1;
            hand2 = 1 + i;
            hand3=1;
            do
            {
                if (ary1[hand1] >= ary1[hand2]) //依次赋值
                {
                    ary2[hand3] = ary1[hand2];
                    hand2 += 1;
                    hand3 += 1;

                }
                else
                {
                    ary2[hand3] = ary1[hand1];
                    hand1 += 1;
                    hand3 += 1;
                }
            } while (hand1 <= i && hand2 <= ary1.Length-1);
            if(hand1>i)  //左边无值，将右边剩余值放入ary2
            {
               for(var s=hand3;s<=ary1.Length-1;s++)
               {
                   ary2[s] = ary1[s];
               }
            }
            else
            {
                for(var s=hand1;s<=i;s++)
                {
                    ary2[hand3] = ary1[s];
                    hand3=hand3+1;
                }
            }
           
            return ary2;
        }
        public static int midSearch(int num1, int[] ary1)
        {
            var len1 = ary1.Length;
            var upBorder = len1;
            var downBorder = 1;
            var mid = (upBorder + downBorder) / 2;
            do
            {
                if (ary1[mid] == num1)
                {
                    return mid;
                }
                else
                {
                    if (ary1[mid] > num1)
                    {
                        upBorder = mid;
                    }
                    else
                    {
                        downBorder = mid;
                    }
                    mid = (upBorder + downBorder) / 2;
                }

            } while ((upBorder - downBorder) > 1);
            return 0;
        }
    }
    
}

