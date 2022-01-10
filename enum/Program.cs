using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeTable timeTable = new TimeTable();
            Console.WriteLine(timeTable.GetJob(5));
            Console.WriteLine(weekdayContant.WEDNESDAY);

            TimeTable1 days = new TimeTable1();

            Console.WriteLine(days.getJob(Weekday.MONDAY));
            Console.WriteLine(Weekday.MONDAY);
        }
    }
}
