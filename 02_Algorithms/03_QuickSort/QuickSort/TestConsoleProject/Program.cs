using System;
using System.Collections.Generic;
using QuickSort;

namespace TestConsoleProject
{
    /* 만약 QuickSort DLL 과 Test Project를 분리한다면, Employee 클래스는 Test Console Project 안에 있어야 합니다.
     * Employee 클래스는 QuickSort 와 직접 관련이 없는 클래스이며, QuickSort DLL 를 모든 타입을 Cover 하는 generalized 된 library 이어야 합니다.
     * 
     * SortFactory 는 Factory 패턴을 연상시키므로 Sort 혹은 SortUtility 등으로 변경하는 것이 좋겠습니다.
     */
    class Program
    {
        static void Main(string[] args)
        {
            const int population = 10;  //Set Empolyees number

            List<Employee> employeeList = new List<Employee>();

            Run(employeeList, population);
        }

        static void Run(List<Employee> employeeList, int population)
        {
            SetEmployeeInfo(employeeList, population);   //Show default Empolyees
            Console.WriteLine("Default Empolyees");
            Show(employeeList);

            SortUtility.QuickSort(employeeList);  //IComparable Id Ascend
            Console.WriteLine("ID ASCEND");
            Show(employeeList);

            AgeAscendComparer aac = new AgeAscendComparer();  //IComparer Age Ascend
            SortUtility.QuickSort(employeeList, aac);
            Console.WriteLine("AGE ASCEND");
            Show(employeeList);

            SortUtility.QuickSort(employeeList,  EmployeeComparison.SalaryAscendComparison); //IComparison Salary Ascend
            Console.WriteLine("SALARY ASCEND");
            Show(employeeList);
        }

        static List<Employee> SetEmployeeInfo(List<Employee> employeeList, int population)
        {
            for (int i = 0; i < population; i++)
            {
                int id = 1 + (i + 50) % 7;
                int age = Math.Abs(-i + 5);
                int salary = (10 * i * i * i * i * i + 100) % 13;

                employeeList.Add(new Employee(id, age, salary));
            }
            return employeeList;
        }

        static void Show(List<Employee> employeeList)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine("Id : {0} \t\t Age : {1} \t Salary : {2} \t"
                    ,employeeList[i].Id, employeeList[i].Age, employeeList[i].Salary);
            }
            Console.WriteLine();
        }
    }
}
