using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WindowsFormsApplication7
{
    public static class Logger
    {
        static string _fileAddressLog = $"g:\\log_{DateUtility.MiladiToShamsi(DateTime.Now)}.txt";
        public static void Error(Exception ex, string msg)
        {
            string message = string.Format("Error====>DateTime:{0}=====Exception:{1}", DateTime.Now, ex.ToString());
            File.AppendAllLines(_fileAddressLog, new List<string> { message });
        }
    }
}
