using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCICE_01___POLIMORF.Entities {
    //------------------------------- START -------------------------------//
    class OutsourceEmployee : Employee {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee() {
        }

    //------------------------------- CONST -------------------------------//  
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour){
            AdditionalCharge = additionalCharge;
        }

    //------------------------------- MET ---------------------------------//  
        public override double Payment() {
            return base.Payment() + 1.1 * AdditionalCharge; ;
        }
       
    }
    //-------------------------------- END -------------------------------//
}
