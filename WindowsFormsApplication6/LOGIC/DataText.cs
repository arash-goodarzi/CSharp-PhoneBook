using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace Project.LOGIC
{
    public class DataText
    {
        public static string ImagesFolder = "../../Data/Images/";
        public static string FilesFolder  = "../../Data/Files/";
        public static string FileName     = "../../Data/Files/Data.txt";

        
        public static void WriteText_List(List<Contact> people, string fileName)
        {
            //Create a Temporary file to overwrite the original file.
            StreamWriter writer = File.CreateText(fileName + ".tmp");

            for (int i = 0; i < people.Count; i++) 
            {
                Contact person = people[i];
                writer.WriteLine(person.ToString());
            }

            writer.Close();
            
            // If the writing is done successfully, copy the temporary file to overwrite the original file.
            File.Copy(fileName + ".tmp", fileName, true);
            
            // If the copying is done successfully, delete the temporary file.
            File.Delete(fileName + ".tmp");
        }

        public static List<Contact> ReadText_List(string fileName) {

            List<Contact> list_All_Contacts = new List<Contact>();
           
            if (File.Exists(fileName))
            {
                StreamReader reader = File.OpenText(fileName);

                while (!reader.EndOfStream)
                {
                    string[] record = reader.ReadLine().Split('|');
                    string name = record[0].Trim();
                    string phone_cell = record[1].Trim();
                    string phone_home = record[2].Trim();
                    string email = record[3].Trim();
                    string photo = record[4].Trim();

                    Contact person = new Contact();
                    person.Name = name;
                    person.Phone_cell = phone_cell;
                    person.Phone_home = phone_home;
                    person.Email = email;
                    person.Photo = photo;

                    //Add New Contact to the list
                    list_All_Contacts.Add(person);
                }

                reader.Close();
            }
            return list_All_Contacts;
        }

        public static string getFileName(string filePath)
        {
            string fileName = "";

            int index = filePath.LastIndexOf('\\');
            if (index >= 0)
                fileName = filePath.Substring(index + 1);
            return fileName;
        }

        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                return input;
            return input.First().ToString().ToUpper() + String.Join("", input.Substring(1));
        }

    }
}
