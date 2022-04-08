using System;
using System.Collections;
using System.Collections.Generic;

namespace ExerciseDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EmployeeList employees = new EmployeeList();
            employees.ReadEmployeeFromFile("TextFile1.txt");
            employees.Display();
            Console.WriteLine("Get by Id");
            EmployeeList employees2 = new EmployeeList(employees.GetById(1));
            employees2.Display();

            Console.WriteLine("Get by Name");
            EmployeeList employees3 = new EmployeeList(employees.GetByName("Tru"));
            employees3.Display();

            Console.WriteLine("Get by Position");
            EmployeeList employees4 = new EmployeeList(employees.GetByPosition("Developer"));
            employees4.Display();

            Console.WriteLine("Get by Base Salary");
            EmployeeList employees5 = new EmployeeList(employees.GetByBaseSalaryRange(800, 1200));
            employees5.Display();

            Console.WriteLine("Get by Salary");
            EmployeeList employees6 = new EmployeeList(employees.GetBySalary(9000, 12000));
            employees6.Display();*/

                SampleClass sc = new SampleClass();
                IControl ctrl = new SampleClass();
                ISurface srfc = new SampleClass();

                sc.Paint();
                ctrl.Paint();
                srfc.Paint();
            }

            interface IControl
            {
                void Paint();
            }
            interface ISurface
            {
                void Paint();
            }
            class SampleClass : IControl, ISurface
            {
                public void Paint()
                {
                    Console.WriteLine("Paint method in SampleClass");
                    Console.ReadKey();
                }
                void IControl.Paint()
                {
                    Console.WriteLine("Paint method in IControl");
                    Console.ReadKey();
                }

                void ISurface.Paint()
                {
                    Console.WriteLine("Paint method in ISurface");
                    Console.ReadKey();
                }
            }
        }
    }

