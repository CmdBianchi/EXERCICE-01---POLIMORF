using System;
using System.Collections.Generic;
using EXERCICE_01___POLIMORF.Entities;
namespace EXERCICE_01___POLIMORF {
    class Program {
        //-----> START
        ////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args) {

            List<Employee> List = new List<Employee>();

            Console.Write("Enter the number of employess");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (Y/N)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch == 'y' & ch == 'Y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    List.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    List.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in List) {
                Console.WriteLine(emp.Name + "- $" + emp.Payment().ToString("F2"));
            }


        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        //-----> END
    }
}
