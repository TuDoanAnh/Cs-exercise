using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDelegate
{
    internal class EmployeeList
    {
        List<Employee> employees;
        
        public EmployeeList()
        {
            employees = new List<Employee>();
        }
        public EmployeeList(List<Employee> _employeesList)
        {
            employees = new List<Employee>(_employeesList);
        }
        public void Input()
        {
            while (true)
            {
                Console.Write("C to continue,S to Stop: ");
                String checkStatus = Console.ReadLine();
                if (checkStatus.Equals("S")) break;
                Console.Write("Enter ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                String name = Console.ReadLine();
                Console.Write("Enterbase Salary: ");
                double baseSalary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Position: ");
                String position = Console.ReadLine();
                Employee employee = new Employee(id, name, baseSalary, position);
                employees.Add(employee);
            }
            return;
        }

        public void ReadEmployeeFromFile(String filename)
        {
            StreamReader reader = new StreamReader(filename);
            String line;
            while((line = reader.ReadLine()) != null)
            {
                Employee e = new Employee();
                e.ReadDataFromFile(line);
                employees.Add(e);
            }
            reader.Close();
        }

        public void Display()
        {
            foreach(Employee e in employees)
            {
                Console.WriteLine($"{e.Id} - {e.Name} - {e.GetSalary(CalculateSalary)} - {e.Position} - {e.BaseSalary}");
            }
        }
        public double CalculateSalary(double baseSalary, String position)
        {
            if (position.Equals("Manager")) return baseSalary * 16;
            else if (position.Equals("Developer")) return baseSalary * 14;
            else return baseSalary * 12;
        }
        public List<Employee> GetById(int _id)
        {
            return (from e in employees
                    where e.Id == _id
                    select e).ToList();
        }
        public List<Employee> GetByName(String _name)
        {
            return(from e in employees
                   where e.Name.Contains(_name)
                   select e).ToList();
        }
        public List<Employee> GetByPosition(String _position)
        {
            return (from e in employees
                    where e.Position.Equals(_position)
                    select e).ToList();
        }
        public List<Employee> GetByBaseSalaryRange(double _baseSalaryDown, double _baseSalaryUp)
        {
            return(from e in employees
                   where e.BaseSalary < _baseSalaryUp && e.BaseSalary > _baseSalaryDown
                   select e).ToList();
        }

        public List<Employee> GetBySalary(double _SalaryDown, double _SalaryUp)
        {
            return (from e in employees
                    where e.GetSalary(CalculateSalary) < _SalaryUp && e.GetSalary(CalculateSalary) > _SalaryDown
                    select e).ToList();
        }
    }
}
