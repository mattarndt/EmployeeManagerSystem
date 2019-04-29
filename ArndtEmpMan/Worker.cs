using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Matthew Arndt FRIEDMAN Project IV Employee Manager System
 * 
 * This class extends employee and has one additional attribute which is the worker's pay and is of type decimal
 */

namespace ArndtEmpMan
{
    [Serializable()]
    class Worker : Employee
    {
        private Decimal HiddenWorkerPay; // Bonus amount
                                         // Parameterless constructor
        public Worker()
        {
            HiddenWorkerPay = 0m;
        } 
        public Worker(string id, string name, string birthdate, string jt, Decimal p) : base(id, name, birthdate, jt)
        {
            HiddenWorkerPay = p;
        } 

        public Decimal workerPay
        {
            get
            {
                return HiddenWorkerPay;
            } // end get
            set //(Decimal value)
            {
                HiddenWorkerPay = value;
            } // end get
        } 

        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            workerPay = Convert.ToDecimal(f.txtHourlyPay.Text);
        } 
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtHourlyPay.Text = workerPay.ToString();
        } // end Display

        
        public override string ToString()
        {
            string s = base.ToString() + "\n & ";
            s += "WorkerPay: " + HiddenWorkerPay.ToString();
            return s;
        }
    }
}
