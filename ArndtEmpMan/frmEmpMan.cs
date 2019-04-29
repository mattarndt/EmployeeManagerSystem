using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *Matthew Arndt FRIEDMAN Project IV Employee Manager System
 * 
 * This the main backbone of the entire program. Im this class you can find the even handlers for all of the buttons on the form.
 * Their main purpose is to add, search for, and delete employees in the .bin file. When a new employee gets created,
 * it is added to the bin.
 */


namespace ArndtEmpMan
{
    public partial class frmEmpMan : Form
    {
        //variables
        private PersonList personList = new PersonList();
        private Validation validation = new Validation();
        private EmpManDB db = new EmpManDB();
        private string fileName = "PersistentObject.bin";
        private bool isClient = false;
        private bool isManager = false;
        private bool isWorker = false;
        private bool validClient = false;
        private bool validManager = false;
        private bool validWorker = false;

        public frmEmpMan()
        {
            InitializeComponent();
        }
        private void frmEmpMan_Load(object sender, EventArgs e)
        {
            //read file
            POManager.readFromFile(ref personList, fileName);//when the form loads, read everything from .bin file to the person list
            //personList.printList();
        }

        private void btnLookUp_Click(object sender, EventArgs e)//LOOKUP BUTTON HANDLER
        {
            clearTextBoxes();
            //everything unenabled that needs to be unenabled.
            pnlSharedInfo.Enabled = true;
            pnlClient.Enabled = false;
            pnlJobTitle.Enabled = false;
            pnlManager.Enabled = false;
            pnlWorker.Enabled = false;
            txtName.Enabled = false;
            txtBirthDate.Enabled = false;
            txtID.Enabled = true;

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            //btnEdit.Enabled = true;
            btnFind.Enabled = true;
        }
        private void btnClient_Click(object sender, EventArgs e)//CLIENT BUTTON HANDLER
        {
            clearTextBoxes();
            pnlSharedInfo.Enabled = true;//panels
            pnlClient.Enabled = true;
            pnlJobTitle.Enabled = false;
            pnlManager.Enabled = false;
            pnlWorker.Enabled = false;
            txtName.Enabled = true;
            txtBirthDate.Enabled = true;
            txtID.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            //btnEdit.Enabled = false;
            btnFind.Enabled = false;
            //btnSave.Enabled = false;

            isClient = true;
            isManager = false;
            isWorker = false;

            
        }

        private void btnManager_Click(object sender, EventArgs e)//MANAGER BUTTON HANDLER
        {
            clearTextBoxes();
            pnlSharedInfo.Enabled = true;//panels
            pnlClient.Enabled = false;
            pnlJobTitle.Enabled = true;
            pnlManager.Enabled = true;
            pnlWorker.Enabled = false;
            txtName.Enabled = true;//shared text boxes
            txtBirthDate.Enabled = true;
            txtID.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
           // btnEdit.Enabled = false;
            btnFind.Enabled = false;
           // btnSave.Enabled = false;

            isClient = false;
            isManager = true;
            isWorker = false;
        }

        private void btnWorker_Click(object sender, EventArgs e) //WORKER BUTTON HANDLER
        {
            clearTextBoxes();
            //panels
            pnlSharedInfo.Enabled = true;
            pnlClient.Enabled = false;
            pnlJobTitle.Enabled = true;
            pnlManager.Enabled = false;
            pnlWorker.Enabled = true;
            txtName.Enabled = true;//shared textboxes
            txtBirthDate.Enabled = true;
            txtID.Enabled = true;
            btnAdd.Enabled = true;//buttons
            btnDelete.Enabled = false;
            //btnEdit.Enabled = false;
            btnFind.Enabled = false;
            //btnSave.Enabled = false;
            //bool operations
            isClient = false;
            isManager = false;
            isWorker = true;
        }

        private void btnClose_Click(object sender, EventArgs e) //closes the form
        {
            this.Close();
            POManager.writeToFile(personList, fileName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes(); //sets everything blank
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!validation.validID(txtID.Text))//checks valid id
            {
                MessageBox.Show("Invalid ID. Must be only digits and 5 in length.");
                validClient = false;
                validWorker = false;
                validManager = false;
            }
            else if (!validation.validName(txtName.Text)) //checks valid name
            {
                MessageBox.Show("Invalid Name. Cannot contain numbers, must be at least 2 letters.");
                validClient = false;
                validWorker = false;
                validManager = false;
            }
            else if (!validation.validBirthDate(txtBirthDate.Text)) //checks valid birthday
            {
                MessageBox.Show("Invalid Birth data. Must be of the format: mm/dd/yyyy");
                validClient = false;
                validWorker = false;
                validManager = false;
            }
            else
            {
                if (isClient) //if the person entered is a client (when the user first clicked on the button)
                {
                    if (!validation.validType(txtType.Text)) //checks if client validation is good, if not make everything false
                    {
                        MessageBox.Show("Invalid Job Type. Cannot contain digits and must be at least two characters.");
                        validClient = false;
                        validWorker = false;
                        validManager = false;
                    }
                    else
                    {
                        validClient = true;
                        validWorker = false;
                        validManager = false;
                    }
                }
                if (isManager) //if manager
                {
                    if (!validation.validJobTitle(txtJobTitle.Text))//checks valid job title
                    {
                        MessageBox.Show("Invalid Job Title. Cannot contain numbers and must be at least 2 in length");
                    }
                    else if (!validation.validSalary(txtSalary.Text)) //checks valid salary
                    {
                        MessageBox.Show("Invalid Salary. Must be only digits and a period. Of the form xxxxx.yy (e.g. 80000.00)");
                    }
                    else if (!validation.validBonus(txtBonus.Text)) //checks valid bonus
                    {
                        MessageBox.Show("Invalid Bonus. Must be only digits and a period. Of the form xxxxx.yy (e.g. 80000.00)");
                    }
                    else
                    {
                        validClient = false;
                        validWorker = false;
                        validManager = true;
                    }
                }
                if (isWorker)
                {
                    if (!validation.validJobTitle(txtJobTitle.Text))
                    {
                        MessageBox.Show("Invalid Job Title. Cannot contain numbers and must be at least 2 in length");
                    }
                    else if (!validation.validHourlyPay(txtHourlyPay.Text))
                    {
                        MessageBox.Show("Invalid Hourly Pay. Must be in decimal form (xx.yy) and cannot be lower than 7.25");
                    }
                    else
                    {
                        validClient = false;
                        validWorker = true;
                        validManager = false;
                    }
                }
            }

            if (validClient) //adds client to the person list
            {
                MessageBox.Show("CLIENT ADDED");
                Person client = new Client(txtID.Text, txtName.Text, txtBirthDate.Text, txtType.Text);
                personList.add(client);
                POManager.writeToFile(personList, fileName);
                db.InsertClient(Int32.Parse(txtID.Text), txtName.Text, txtBirthDate.Text, txtType.Text);
            }
            if (validManager) //adds manager to the person list
            {
                MessageBox.Show("MANAGER ADDED");
                decimal sal = Convert.ToDecimal(txtSalary.Text);
                decimal bon = Convert.ToDecimal(txtBonus.Text);
                Person manager = new Manager(txtID.Text, txtName.Text, txtBirthDate.Text, txtJobTitle.Text, sal, bon);
                personList.add(manager);
                POManager.writeToFile(personList, fileName);
                db.InsertManager(Int32.Parse(txtID.Text), txtName.Text, txtBirthDate.Text, bon, sal, txtJobTitle.Text);
            }
            if (validWorker) //adds worker to the person list
            {
                MessageBox.Show("WORKER ADDED");
                decimal hourpay = Convert.ToDecimal(txtHourlyPay.Text);
                Person manager = new Worker(txtID.Text, txtName.Text, txtBirthDate.Text, txtJobTitle.Text, hourpay);
                personList.add(manager);
               POManager.writeToFile(personList, fileName);
                db.InsertWorker(Int32.Parse(txtID.Text), txtName.Text, txtBirthDate.Text, hourpay, txtJobTitle.Text);
            }
            //ADD TO PERSON LIST HERE
        }

        private void btnFind_Click(object sender, EventArgs e) //FIND BUTTON HANDLER
        {
            string id = txtID.Text;
            Person person = personList.search(id);
            if (person == null) 
            {
                MessageBox.Show("Could not find employee with the ID: " + id);
            }
            else //if there id entered is actually in the person list
            {
                displaySharedInfo(person); //displays id, name, bday
                if (person.GetType() == typeof(Client))
                {
                    txtType.Text = ((Client)person).clientType;
                }
                if (person.GetType() == typeof(Manager))
                {
                    txtSalary.Text = Convert.ToString(((Manager)person).managerSalary);
                    txtBonus.Text = Convert.ToString(((Manager)person).managerBonus);
                }
                if (person.GetType() == typeof(Worker))
                {
                    txtHourlyPay.Text = Convert.ToString(((Worker)person).workerPay);
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e) //EDIT BUTTON HANDLER
        {
           // btnSave.Enabled = true;
            string id = txtID.Text;
            Person person = personList.search(id);
            if (person == null)
            {
                MessageBox.Show("Could not find employee with the ID: " + id);
            }
            else
            {
                displaySharedInfo(person);
                makeSharedInfoEditable();
                if (person.GetType() == typeof(Client))
                {
                    txtType.Text = ((Client)person).clientType;

                }
                if (person.GetType() == typeof(Manager))
                {
                    txtSalary.Text = Convert.ToString(((Manager)person).managerSalary);
                    txtBonus.Text = Convert.ToString(((Manager)person).managerBonus);
                }
                if (person.GetType() == typeof(Worker))
                {
                    txtBonus.Text = Convert.ToString(((Worker)person).workerPay);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //DELETE BUTTON HANDLER
        {
            string id = txtID.Text;
            Person person = personList.search(id);
            if (person == null)
            {
                MessageBox.Show("Could not find employee with the ID: " + id);
            }
            else
            {// deletes user in db and in bin folder
                personList.delete(id);
                db.Delete(Int32.Parse(id));
                MessageBox.Show("User with id " + id + " has been deleted");
                clearTextBoxes();
            }
        }

        private void displaySharedInfo(Person p)
        {
            txtID.Text = p.personID;
            txtBirthDate.Text = p.personBirthDate.ToString();
            txtName.Text = p.personName;
        }

        private void makeSharedInfoEditable()
        {
            pnlSharedInfo.Enabled = true;
        }

        private void clearTextBoxes()
        {
            txtBirthDate.Text = "";
            txtBonus.Text = "";
            txtHourlyPay.Text = "";
            txtID.Text = "";
            txtJobTitle.Text = "";
            txtName.Text = "";
            txtSalary.Text = "";
            txtType.Text = "";
        }
    }
}
