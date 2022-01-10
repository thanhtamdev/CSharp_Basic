using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class TimeTable1
    {
        public string getJob(Weekday day)
        {
            if(day == Weekday.SATURDAY || day == Weekday.SUNDAY)
            {
                return "Stay at home!";
            }

            return "Go to school!";
        }
    }
}
