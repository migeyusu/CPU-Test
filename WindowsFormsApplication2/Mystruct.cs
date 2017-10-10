using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUTest
{ 
    //使用数组实现的队列
    internal class iQueue<T>
    {
        //有效队列序号从1开始,默认队列头是空
        private int hand1, hand2;
        private int endHand;
        private T[] queueAry;
        public int waithingLength
        {
            get
            {
                if (hand1 <= hand2)
                {
                    return hand2 - hand1;
                }
                else
                {
                    return endHand - hand1 + hand2;
                }

            }


        }
        public bool push(ref T x)
        {
            if (hand1 <= hand2)
            {
                if (hand2 < endHand)
                {
                    ++hand2;
                }
                else if (hand1 > 1)
                {
                    hand2 = 1;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((hand2 + 1) < hand1)
                {
                    ++hand2;
                }
                else
                {
                    return false;
                }
            }
            queueAry[hand2] = x;
            return true;
        }
        public bool pop(ref T x)
        {
            if (hand1 < hand2)
            {
                ++hand1;
            }
            else if (hand1 == hand2)
            {
                return false;
            }
            else
            {
                if (hand1 < endHand)
                {
                    ++hand1;
                }
                else
                {
                    hand1 = 1;
                }
            }
            x = queueAry[hand1];
            return true;
        }
        public iQueue(int x)//x为数组末序号
        {
            hand1 = 0;
            hand2 = 0;
            endHand = x;
            queueAry = new T[endHand + 1];
        }
        public bool peek(ref T x)
        {
            if (hand1 < hand2)
            {
                ++hand1;
                x = queueAry[hand1];
                --hand1;
                return true;
            }
            else if (hand1 == hand2)
            {
                return false;
            }
            else
            {
                if (hand1 < endHand)
                {
                    ++hand1;
                    x = queueAry[hand1];
                    --hand1;
                    return true;
                }
                else
                {
                    hand1 = 1;
                    x = queueAry[1];
                    hand1 = endHand;
                    return true;
                }
            }
        }
    }
}
