using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
    public static class DateUtility
    {
        public static string MiladiToShamsi(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}_{1}_{2}_{3}_{4}", pc.GetYear(date),
                pc.GetMonth(date), pc.GetDayOfMonth(date),pc.GetHour(date),pc.GetMinute(date));
        }
    }
}
