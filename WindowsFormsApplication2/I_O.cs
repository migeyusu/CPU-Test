using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace CPUTest
{
    internal class IO
    {
        public static void Write_In(string fileName,string outStream)//前面表示文件名，后面表示写入值
        {
            var sw = new StreamWriter(Application.StartupPath +@"\"+fileName+".txt",true);
            sw.Write(outStream);
            sw.Close();
        }
        public static void Write_In(string fileName,int[] ary)
        {
            var sw = new StreamWriter(Application.StartupPath + @"\" + fileName + ".txt",true);
            var str1="";
            for(var i=1;i<=ary.Length-1;++i)
            {
                str1+=ary[i].ToString() + ",";
            }
            sw.Write(str1);
            sw.Close();
        }
        public static void Write_In(string fileName,string[] ary)
        {
            var sw = new StreamWriter(Application.StartupPath + @"\" + fileName + ".txt",true);
            var str1 = "";
            for(var i=1;i<=ary.Length-1;++i)
            {
                str1+=ary[i];
            }
            sw.Write(str1);
            sw.Close();
        }
        public static void Write_In(string fileName,byte[] ary)
        {
            var sw = new StreamWriter(Application.StartupPath + @"\" + fileName + ".txt",true);
            var str1 = "";
            for(var i=1;i<=ary.Length-1;++i)
            {
                str1+= ary[i].ToString();
            }
            sw.Write(str1);
            sw.Close();
        }
    }
}
