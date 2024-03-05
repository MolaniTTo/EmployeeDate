using System;

namespace EmployeeDate
{
    public class Employee
    {
        private static int employeeCount = 0;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Code { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Hiredate { get; set; }
        public float Monthsalary { get; set; }
        public int Payments { get; set; }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthdate.Year;
                if (DateTime.Now.DayOfYear < Birthdate.DayOfYear)
                    age = age - 1;
                return age;
            }

        }

        public Employee(string name, string surname, string code, DateTime birthdate, DateTime hiredate, float monthsalary = 1800, int payments = 14)
        {
            Name = name;
            Surname = surname;
            Code = code;
            Birthdate = birthdate;
            Hiredate = hiredate;
            Monthsalary = monthsalary;
            Payments = payments;

            employeeCount++; 
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Surname: {Surname}\n" +
                   $"Code: {Code}\n" +
                   $"Birthdate: {Birthdate.ToShortDateString()}\n" +
                   $"Hiredate: {Hiredate.ToShortDateString()}\n" +
                   $"Monthsalary: {Monthsalary}\n" +
                   $"Payments: {Payments}\n" +
                   $"Age: {Age}\n";
        }

        public static int GetEmployeeCount()
        {
            return employeeCount;
        }
    }
}