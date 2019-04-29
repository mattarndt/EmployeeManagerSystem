using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArndtEmpMan
{
    /*
 *Matthew Arndt FRIEDMAN Project IV Employee Manager System
 * 
 * This class inherits employee attributes and also has some of its own, which is salary and bonus
 * 
 */


    [Serializable()] class Manager : Employee
    {
        private Decimal HiddenManagerSalary;   // Salary amount
        private Decimal HiddenManagerBonus;    // Bonus amount

        // Parameterless constructor
        public Manager()
        {
            HiddenManagerSalary = 0m;
            HiddenManagerBonus = 0m;
        }  // end Manager parameterless constructor

        // Parameterized constructor (not used)
        public Manager(string id, string name, string birthdate, string jt, Decimal s, Decimal b) : base(id, name, birthdate, jt)
        {
            HiddenManagerSalary = s;
            HiddenManagerBonus = b;
        }  // end Manager parametierized constructor


        // Accessor/mutator for salary
        public Decimal managerSalary
        {
            get
            {
                return HiddenManagerSalary;
            }  // end get
            set  //(Decimal value)
            {
                HiddenManagerSalary = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for bonus
        public Decimal managerBonus
        {
            get
            {
                return HiddenManagerBonus;
            }  // end get
            set   // (Decimal value)
            {
                HiddenManagerBonus = value;
            }  // end get
        } // end Property


        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            managerSalary = Convert.ToDecimal(f.txtSalary.Text);
            managerBonus = Convert.ToDecimal(f.txtBonus.Text);
        }  // end Save


        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtSalary.Text = managerSalary.ToString();
            f.txtBonus.Text = managerBonus.ToString();
        }  // end Display


        // This toString function overrides the Employee toString
        //     function.  The base refers to the Employee because this class
        //     inherits Employee by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "ManagerSalary:     " + HiddenManagerSalary.ToString() + "\n";
            s += "ManagerBonus:      " + HiddenManagerBonus.ToString();
            return s;
        }  // end ToString


    }  // end Manager Class

}
