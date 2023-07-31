using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeDepartment
{
    internal class Employee
    {
        private string _name;
        public string NAME{
            get
            {
                return _name;
            }
            set
            {
                if (Check(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("name must consist of letters only");
                }
            } 
        }
        private string _surname;
        public string SurName
        {
            get
            {
                return _surname;
            }
            set
            {
                if (Check(value))
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("surname must consist of letters only");
                }
            }
        }

        private int _salary;
        public int SALARY
        {
            get
            {
                return _salary;

            }
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine($"{value} 250den kicikdir.salary 250den boyuk olmalidir.");
                   
                }
            }
        }
        public  bool Check(string word)
        {
            bool result = false;
            foreach (var letter in word)
            {
                if (!char.IsLetter(letter))
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }

            }
            return result;
        }

        public Employee(string name, string surname, int salary)
        {
            NAME = name;
            SurName = surname;
            SALARY = salary;

        }
    }
}
