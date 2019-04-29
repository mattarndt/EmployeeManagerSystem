using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 *Matthew Arndt FRIEDMAN Project IV Employee Manager System
 * 
 * This class handles all validations for when the user creates a new person.
 * 
 */

namespace ArndtEmpMan
{
    class Validation
    {
        public Validation(){
            
        }

        public bool validID(string id) //can only be numbers and of length 5
        {
            Regex reg = new Regex(@"[\d]");
            if (reg.IsMatch(id))
            {
                if (id.Length == 5)
                {
                    return true;
                }
            }
            return false;
        }

        public bool validName(string id) //can only be characters and must be longer than 2 characters
        {
            if (id == "" || id.Length < 2)
            {
                return false;
            }
            if (containsNumber(id))
            {
                return false;
            }

            return true;
        }

        public bool validBirthDate(String birthDay) //must be of the form MM/DD/YYYY
        {

            CultureInfo us = new CultureInfo("en-US");
            try
            {
                DateTime validDate = DateTime.ParseExact(birthDay, "MM/dd/yyyy", us);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool validType(String str) //must be only characters
        {
            if(str == "" || str.Length < 2)
            {
                return false;
            }
            if (containsNumber(str))
            {
                return false;
            }

            return true;
        }

        public bool validJobTitle(String str) //must be only characters
        {
            if (str == "" || str.Length < 2)
            {
                return false;
            }
            if (containsNumber(str))
            {
                return false;
            }

            return true;
        }

        public bool validSalary(string str) //must be of form xxx.xx and only numbers
        {
            try
            {
                if (validateDecimal(str))
                {
                    string[] arr = str.Split('.');
                    if (arr[1].Length == 2)
                        return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public bool validBonus(string str)//must be of form xxx.xx and only numbers
        {
            try
            {
                if (validateDecimal(str))
                {
                    string[] arr = str.Split('.');
                    if (arr[1].Length == 2)
                        return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public bool validHourlyPay(string str)//must be of form xxx.xx and only numbers and more than 7.25
        {
            try
            {
                if (validateDecimal(str))
                {
                    string[] arr = str.Split('.');
                    if (arr[1].Length == 2)
                        return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        private bool validateDecimal(string str)
        {
            try{
                decimal dec = Convert.ToDecimal(str);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool containsNumber(string str)
        {
            if (str.Any(c => char.IsDigit(c)))
            {
                return true;
            }
            return false;
        }
    }
}
