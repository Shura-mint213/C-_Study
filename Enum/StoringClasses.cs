using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class StoringClasses
    {
        public class Date
        {
            public string Day { get; set; }
            public string Month { get; set; }
            public int Year { get; set; }
        }
        public class Student : Date
        {
            public string Name { get; set; }
            public string Estimation { get; set; }
        }
        public static class Print
        {
            public static void StudentPrint(Student student)
            {
                Console.WriteLine("Birthday: \n\tDay week: {0},\n\tMonth: {1}," +
                    "\n\tYear: {2};\nName: {3},  Estimation: {4} - {5}",
                        (Enum.DayOfWeek)student.Day.ToInt(),
                        (Enum.MonthDay)student.Month.ToInt(),
                        student.Year,
                        student.Name,
                        student.Estimation,
                        (Enum.EstimationStudent)student.Estimation.ToInt()

                    );
            }
        }
        public static class Read
        {
            public static Student StudentRead(Student student)
            {
                Console.WriteLine("Ведите день недели когда вы родились!");
                student.Day = Console.ReadLine();

                Console.WriteLine("Ведите месяц когда вы родились!");
                student.Month = Console.ReadLine();

                Console.WriteLine("Ведите год когда вы родились!");
                student.Year = Console.ReadLine().ToInt();

                Console.WriteLine("Ведите Имя!");
                student.Name = Console.ReadLine();
                
                Console.WriteLine("Ведите оценку!");
                student.Estimation = Console.ReadLine();

                return student;
            }
        }
    }
}
