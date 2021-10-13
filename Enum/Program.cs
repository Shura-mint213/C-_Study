using System;

namespace Enum
{
    //Создать класс студент в этом классе должно быть
    //день недели в который родился студент, месяц, год, имя, оценка.
    class Program
    {
        static void Main(string[] args)
        {
            StoringClasses.Student student = new StoringClasses.Student();
            student = StoringClasses.Read.StudentRead(student);
            StoringClasses.Print.StudentPrint(student);
        }
    }
}
