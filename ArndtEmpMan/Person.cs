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
 * This is the highest tier in the person tree. It's common attributes between everyone
 * is that they all have in id, name, and birthday
 * 
 */

    [Serializable()] public abstract class Person
    {

        private string HiddenPersonName; // Person name
        private string HiddenPersonID;   // Person ID
        private DateTime HiddenPersonBirthDate;   // Person birth date
        

        // Non-parameterized constructor
        public Person()
        {
            HiddenPersonName = "";
            HiddenPersonBirthDate = DateTime.Now;
            HiddenPersonID = "";
        }  // end Person Non-parameterized Constructor

        
        public Person(string id, string name,  string birthdate)
        {
            HiddenPersonName = name;
            HiddenPersonBirthDate = Convert.ToDateTime(birthdate);
            HiddenPersonID = id;
        }


        // Accessor/mutator for name
        public string personName
        {
            get
            {
                return HiddenPersonName;
            }  // end get
            set   // (string value)
            {
                HiddenPersonName = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for birth date
        public DateTime personBirthDate
        {
            get
            {
                return HiddenPersonBirthDate;
            }  // end get
            set   // (DateTime value)
            {
                HiddenPersonBirthDate = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for id
        public string personID
        {
            get
            {
                return HiddenPersonID;
            } //  end get
            set   // (string value)
            {
                HiddenPersonID = value;
            }  // end get
        }  // End Property


        // Save data from form to object
        public virtual void Save(frmEmpMan f)
        {
            personName = f.txtName.Text;
            personBirthDate = DateTime.Parse(f.txtBirthDate.Text);
            personID = f.txtID.Text;
        }  // end Save


        // Display data in object on form
        public virtual void Display(frmEmpMan f)
        {
            f.txtName.Text = personName;
            f.txtBirthDate.Text = personBirthDate.ToShortDateString();
            f.txtID.Text = personID;
        }  // end Display


        // This toString function overrides the Object toString
        // function.  The base refers to Object because this class
        // inherits Object by default.
        public override string ToString()
        {
            string s = "ObjectType       : " + base.ToString() + "\n";
            s += "PersonName     : " + HiddenPersonName + "\n";
            s += "PersonBirthDate: " + HiddenPersonBirthDate.ToShortDateString() + "\n";
            s += "PersonID       :" + HiddenPersonID;
            return s;
        }  // end ToString

        public bool isUniqueID(string enteredID)
        {
            string foundID = ""; //foundID = person[0] which is the personID to be found in the database
            if (enteredID != foundID)
            {
                return true;
            }
            return false;
        }

    }
}