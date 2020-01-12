using System;
using System.Collections.Generic;

namespace TestConsoleProject
{
    //'================================================================================================================
    //' CLASS NAME  : Employee
    //'               1.Empolyee의 Id, Age, Salary를 담고있는 클래스 
    //'               2.IComparable을 상속받아 CompareTo Method를 통해 Id Ascend를 기본으로 하고 있다.
    //'               3.Id, Age, Salary를 Ascend하는 IComparer.cs 및 IComparison.cs를 포함하고 있다.
    //'================================================================================================================
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(int id, int age, int salary)
        {
            Id = id;
            Age = age;
            Salary = salary;
        }

        public int CompareTo(Employee other)
        {
            return Id.CompareTo(other.Id);
        }
    }

    public class IdAscendComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
    public class AgeAscendComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Age.CompareTo(y.Age);
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
        public static int IdAscendComparison(Employee x, Employee y)
        {
            return x.Id.CompareTo(y.Id);
        }
        public static int AgeAscendComparison(Employee x, Employee y)
        {
            return x.Age.CompareTo(y.Age);
        }
        public static int SalaryAscendComparison(Employee x, Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }

    }
}
