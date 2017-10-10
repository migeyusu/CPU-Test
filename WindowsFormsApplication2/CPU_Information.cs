using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;//先引用managementdll才能使用managementclass
using Microsoft.Win32;//win32注册表信息，获取原始cpu频率
using System.Windows.Forms;


namespace CPUTest
{
    internal class CpuInformation
    {
        private enum WmiProcesser
        {
            CurrentClockSpeed=1,
            NumberOfCores=2,
            Name=3,
            NumberOfLogicalProcessors=4
        }

        public static string InfoSearch(string searcher)
        {
            return WmiSearcher.InfoSearch("SELECT * FROM Win32_Processor", searcher);   
        }

        public static string[] ProcessInfo()
        {
            string[] searcher = {WmiProcesser.Name.ToString(), WmiProcesser.NumberOfCores.ToString(),
                                    WmiProcesser.NumberOfLogicalProcessors.ToString()};
            return InfoSearch(searcher);
        }

        public static string[] InfoSearch(string[] searcher)
        {
            var rut=WmiSearcher.InfoSearch("Win32_Processor", searcher);
            var rst = new string[searcher.Length];
            for(var i=0;i<searcher.Length;++i)
            {
                rst[i] = rut[0, i];
            }
            return rst;
        }

        public static int ClockSpeed()
        {
            var mos = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            var resultInt = 0;
            foreach (ManagementObject mo in mos.Get())
            {
                resultInt = int.Parse(mo["CurrentClockSpeed"].ToString());
                break;
            }
            return resultInt;
        }
    }

    internal class WmiSearcher
    {
        public static string[,] InfoSearch(string wmiClass, string[] param, string key, string value)
        {
            var str1 = "SELECT * FROM " + wmiClass + " WHERE " + key + "=" + "'" + value + "'";
            var len1 = param.Length;
            int i, j = 0;
            var mos = new ManagementObjectSearcher(str1);
            var moc = mos.Get();
            var rst = new string[moc.Count, len1];
            foreach (ManagementObject mo in moc)
            {
                for (i = 0; i < len1; ++i)
                {
                    rst[j, i] = mo[param[i]].ToString();
                }
                ++j;
            }
            return rst;
        }

        public static string[,] InfoSearch(string wmiClass, string[] param, string key, int value)
        {
            var str1 = "SELECT * FROM " + wmiClass + " WHERE " + key + "=" + value.ToString();
            var len1 = param.Length;
            var j = 0;
            var mos = new ManagementObjectSearcher(str1);
            var moc = mos.Get();
            var rst = new string[moc.Count, len1];
            foreach (var o in moc)
            {
                var mo = (ManagementObject) o;
                int i;
                for (i = 0; i < len1; ++i)
                {
                    rst[j, i] = mo[param[i]].ToString();
                }
                ++j;
            }
            return rst;
        }

        public static string[,] InfoSearch(string wmiClass, string[] param)
        {

            wmiClass = "SELECT * FROM " + wmiClass;
            var len1 = param.Length;
            var j = 0;
            var mos = new ManagementObjectSearcher(wmiClass);
            var moc = mos.Get();
            var rst = new string[moc.Count, len1];

            foreach (var o in moc)
            {
                var mo = (ManagementObject) o;
                int i;
                for (i = 0; i < len1; ++i)
                {
                    rst[j, i] = mo[param[i]].ToString();
                }
                ++j;
            }
            return rst;
        }

        public static string InfoSearch(string sqlSearcher, string param)
        {
            var mos=new ManagementObjectSearcher(sqlSearcher);
            var str1="";
            foreach(var o in mos.Get())
            {
                var mo = (ManagementObject) o;
                str1= mo[param].ToString();
                break;
            }
            return str1;
        }
    }    
}
