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
 * This class inherits person and has its own "client type" attribute
 * 
 */

    [Serializable()] class Client : Person
    {
        private String HiddenClientType;

        // constructor with parameters
        public Client(string id, string name, string birthdate, string ct) : base(id, name, birthdate)
        {
            HiddenClientType = ct;
        }

        public Client()
        {
            HiddenClientType = "";
        }

        // Accessor/mutator for client type
        public String clientType
        {
            get
            {
                return HiddenClientType;
            } // end get
            set //(Decimal value)
            {
                HiddenClientType = value;
            } // end get
        } // end Property

        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            clientType = Convert.ToString(f.txtType.Text);
        } // end Save

        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtType.Text = clientType.ToString();
        } // end Display

        // This toString function overrides the Person toString
        // function. The base refers to the Person because this class
        // inherits Person by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n ";
            s += " ClientType: &" + HiddenClientType.ToString();
            return s;
        }
    }
}
