using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartment
{
    internal class Department
    {
        public string Name { get; set; }    
        public int count { get; set; }
        public int SalaryLimit { get; set; }
        public Employee[] employees { get; set; }

        public Department(int employeelimit)
        {
           
            count = 0;
            //EmployeeLimit = employeelimit;
            employees=new Employee[employeelimit];
        }

        public void AddEmployee(string name, string surname ,int salary)
        {
            if (count < employees.Length)
            {
                Employee E = new Employee(name, surname, salary);
                if (E.NAME != null && E.SurName != null && E.SALARY !=0)
                {
                    
                    employees[count] = E;
                    count++;
                    Console.WriteLine($"add {count}.employee was added to the department");
                }
                else
                {
                    Console.WriteLine("iscinin adinda soyadinda veya salarysinde problem var,bu sebebden elave olunmadi yeniden nezer yetirin.");
                }
            }
            else
            {
                Console.WriteLine("EmployeeLimit asildi");
            }
            
        }
        
    }
}
