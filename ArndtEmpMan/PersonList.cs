using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArndtEmpMan

/*
*Matthew Arndt FRIEDMAN Project IV Employee Manager System
* 
* This class is the internal representation of every employee in the list. It is
* essentially just a person list that contains an assortment of subtypes entered by the user
* 
*/
{
    [Serializable()] class PersonList
    {
        public List<Person> list = new List<Person>();

        public PersonList()
        {

        }

        public int Count()
        {
            return list.Count();
        }

        // Add new person into person list 
        public void add(Person p)
        {
            list.Add(p);
        }

        public Person search(string id)
        {
            foreach (Person p in list)
            {
                if (p.personID == id)
                {
                    return p;
                }
            }
            return null;
        }

        public void delete(string id)
        {
            int count = -1;
            foreach (Person p in list)
            {
                count++;
                if (p.personID == id)
                {
                    list.RemoveAt(count);
                    break;
                }
            }
        }

        public string printList()
        {
            string personListString = "";
            foreach (Person p in list)
            {
                personListString += "ID: " + Convert.ToString(p.personID) + " Type: " + Convert.ToString(p.GetType()) + "\n";
            }
            return personListString;
        }


    }
}
