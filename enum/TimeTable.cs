using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class TimeTable
    {
        // Tham số đầu vào là ngày trong tuần

        // Tham số đầu ra là công việc

        public string GetJob(int dayInWeek)
        {
            if (dayInWeek == weekdayContant.SATURDAY || dayInWeek == weekdayContant.SUNDAY)
            {
                return "Stay at home!";
            }

            return "Go to school!";
        }
    }
}
