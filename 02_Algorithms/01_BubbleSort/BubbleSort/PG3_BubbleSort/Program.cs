using PG3_BubbleSort.BubbleSort;
using PG3_BubbleSort.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG3_BubbleSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            //RunIComparable();
            //RunIComparer();
            RunComparison();
        }

        private static void RunIComparable()
        {
            var employeeList = GenerateEmployees();
            ShowEmployees(employeeList); // before sort

            BubbleSorter.BubbleSort(employeeList);
            ShowEmployees(employeeList); // after sort
        }
        private static void RunIComparer()
        {
            var employeeList = GenerateEmployees();
            ShowEmployees(employeeList); // before sort

            var sac = new SalaryAscendComparer();
            BubbleSorter.BubbleSort(employeeList, sac);
            ShowEmployees(employeeList); // after sort
        }
        private static void RunComparison()
        {
            var employeeList = GenerateEmployees();
            ShowEmployees(employeeList); // before sort

            BubbleSorter.BubbleSort(employeeList, EmployeeComparison.AgeAscendComparison);
            ShowEmployees(employeeList); // after sort
        }

        private static List<Employee> GenerateEmployees()
        {
            int employeeNumber = 100;
            var employeeList = new List<Employee>();

            for (int i = 0; i < employeeNumber; i++)
            {
                int id = 1 + (i + 50) % 7;
                int age = Math.Abs(-i + 5);
                int salary = (10 * i * i * i * i * i + 100) % 13;

                employeeList.Add(new Employee(id, age, salary));
            }
            return employeeList;
        }

        private static void ShowEmployees(List<Employee> employeeList)
        {
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine($"id: {emp.Id}, age: {emp.Age}, salary: {emp.Salary}");
            }
            Console.WriteLine("EOL \n\n");
        }
    }
}
