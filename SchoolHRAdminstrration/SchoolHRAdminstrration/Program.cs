using HRAdministrationaAPI;
using System;
namespace SchoolHRAdministration
{
    class Program 
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();

            SeedData(employees);

            foreach(IEmployee employee in employees)
            {
                totalSalaries += employee.Salary;
            }

            // Console.WriteLine($"Total Annual Salaries (including bonus): {totalSalaries}");
             Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum( e => e.Salary)}");

            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teaher1 = new Teacher
            {
                Id = 1,
                FirstName = "Roshan",
                LastName = "Shrestha",
                Salary = 100000
            };

            employees.Add(teaher1);

            IEmployee teaher2 = new Teacher
            {
                Id = 2,
                FirstName = "Binod",
                LastName = "Magar",
                Salary = 20000
            };

            employees.Add(teaher2);
            IEmployee headofdepartment = new HeadOfDepartment
            {
                Id = 1,
                FirstName = "Rahul",
                LastName = "Neupane",
                Salary = 200000
            };

            employees.Add(headofdepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 1,
                FirstName = "Deepak",
                LastName = "Khadka",
                Salary = 400000
            };

            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 1,
                FirstName = "Subash",
                LastName = "Rai",
                Salary = 500000
            };

            employees.Add(headMaster);


        }
    }

    public class Teacher: EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m);}
    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }

    public class DeputyHeadMaster: EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    public class HeadMaster : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }

}
