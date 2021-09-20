using System;

namespace assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var student1 = new student(2929, "gu", "ho", DateTime.Now, DateTime.Now);
            Console.WriteLine(student1.ToString());
        }
    }
}
