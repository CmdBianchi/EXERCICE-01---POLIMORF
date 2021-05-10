using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCICE_01___POLIMORF.Entities {
    //------------------------------- START -------------------------------//
    class Employee {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double  ValuePerHour { get; set; }

        public Employee() { }
    //------------------------------- CONST -------------------------------//  
        public Employee(string name, int hours, double valuePerHour) {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
    //------------------------------- MET -------------------------------//  
        public virtual double Payment() {
            return Hours * ValuePerHour;
        }
    }
    //-------------------------------- END -------------------------------//
}
