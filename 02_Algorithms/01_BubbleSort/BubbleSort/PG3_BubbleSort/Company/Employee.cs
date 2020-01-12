using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_BubbleSort.Company
{
    public class Employee : IComparable<Employee>
    {   
        public Employee(int id, int age, decimal salary)
        {
            this.Id = id;
            this.Age = age;
            this.Salary = salary;
        }

        public int Id { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public int CompareTo(Employee other)
        {
            return Id.CompareTo(other.Id);
        }
    }

    public class SalaryAscendComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

    public static class EmployeeComparison
    {
        public static int AgeAscendComparison(Employee x, Employee y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
