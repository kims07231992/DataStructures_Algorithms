using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_InsertionSort.Company
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
}
