using EmployeeDate;
using System;

namespace DateTimeEmployees
{
    public class  Program
    {
        public static void Main()
        {
            Employee Joan = new Employee("Joan", "Colomer", "12345678A", new DateTime(1973, 12, 12), new DateTime(2010, 12, 12), 1500, 12);

            Console.WriteLine(Joan);
        }
        
    }
}
