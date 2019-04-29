
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

/*
 *Matthew Arndt FRIEDMAN Project IV Employee Manager System
 * 
 * This class reads and writes from the bin file to the person list. Created by frank
 * 
 */

namespace ArndtEmpMan
{
    class POManager
    {

        // This class manages the persistant object by reading from and writing to a file

        // Write the Person List to file as a serialized binary object
        public static bool writeToFile(PersonList plist, string fn)
        {
            Stream thisFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (plist.Count() > 0)
            {
                try
                {
                    thisFileStream = File.Create(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Person List not written", "POManager File Open");
                    MessageBox.Show(ex.ToString());
                    return false;
                }  // end Try

                try
                {
                    serializer.Serialize(thisFileStream, plist);
                    //MsgBox("File write: Person List was written")
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File write error: Person List not written", "POManager File Write");
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    thisFileStream.Close();
                }  // end Try
            }
            else
                MessageBox.Show("No Person in List");
            // end if

            return true;  // The file write succeeded

        }  // end WriteToFile


        // Read the Person List from file as a serialized binary object
        public static bool readFromFile(ref PersonList plist, string fn)
        {
            Stream TestFileStream;
            BinaryFormatter deserializer = new BinaryFormatter();

            if (File.Exists(fn))
            {
                try
                {
                    TestFileStream = File.OpenRead(fn);
                }
                catch (Exception)
                {
                    MessageBox.Show("File open error: Open with new Person List", "POManager, File Open");
                    plist = new PersonList();
                    return false;
                }  // end Try

                try
                {
                    plist = (PersonList)deserializer.Deserialize(TestFileStream);
                    // pl = CType(deserializer.Deserialize(TestFileStream), PersonList);
                    // MsgBox("File open: Person loaded to List");
                }
                catch (Exception)
                {
                    MessageBox.Show("File read error: Open with new Person List", "POManager File Read");
                    plist = new PersonList();
                    return false;
                }
                finally
                {
                    TestFileStream.Close();
                }  // end Try
            }  // end then part of if
            else
            {
                MessageBox.Show("File does not exist: Open with new Person List", "PO Manager Exists ");
                plist = new PersonList();
            }  // end if

            return true;   // The file read succeeded

        }  // end readFromFile 

    }  // end POManager Class
}  // end namespace

