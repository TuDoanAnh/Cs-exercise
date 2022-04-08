using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDelegate
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public string Position { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, double baseSalary, string position)
        {
            Id = id;
            Name = name;
            BaseSalary = baseSalary;
            Position = position;
        }

        public double GetSalary(SalaryCalculation delobj)
        {
            return delobj(BaseSalary, Position);
        }
        public void ReadDataFromFile(String line)
        {
            String[] items  = line.Split("|");
            Id = Convert.ToInt32(items[0]);
            Name = items[1];
            BaseSalary = Convert.ToDouble(items[2]);
            Position = items[3];
        }
    }
}
