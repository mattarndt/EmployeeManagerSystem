using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArndtEmpMan
{
    [Serializable()] class Employee : Person
    {
        /*
 *Matthew Arndt FRIEDMAN Project IV Employee Manager System
 * 
 * This class inhereits person and has its own attribute called title.
 * 
 */


        public string jobTitle;
        public Employee(string id, string name, string birthdate, string jt) : base(id, name, birthdate)
        {
            jobTitle = jt;
        }

        public Employee()
        {
            jobTitle = "";
        }

        public String employeeJobTitle
        {
            get
            {
                return jobTitle;
            } // end get
            set //(Decimal value)
            {
                jobTitle = value;
            } // end get
        } // end Property

        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            employeeJobTitle = Convert.ToString(f.txtJobTitle.Text);
        } // end Save
          // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtJobTitle.Text = employeeJobTitle.ToString();
        } // end Display

        // This toString function overrides the Person toString
        // function. The base refers to the Person because this class
        // inherits Person by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n ";
            s += " EmployeeJobTitle: &" + jobTitle.ToString();
            return s;
        }

    }
}
