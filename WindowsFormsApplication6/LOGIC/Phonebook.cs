using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Project.LOGIC
{
    public class Phonebook
    {
        public static SortedList ListByName = new SortedList();
        public static SortedList ListByPhone = new SortedList();

        //Create Phonebook 
        public static void loadFromList(List<Contact> people)
        {
            Phonebook.ListByName = new SortedList();
            Phonebook.ListByPhone = new SortedList();

            for (int i = 0; i < people.Count; i++ )
            {
                Contact person = people[i];
                string name = person.Name;
                string phone_cell = person.Phone_cell;

                if (name != string.Empty && Phonebook.ListByName.Contains(name) == false && Phonebook.ListByPhone.Contains(phone_cell) == false)
                {
                    Phonebook.AddContact(person);
                }
            }

        }

        public static bool AddContact(Contact person)
        {
            string name = person.Name;
            string phone_cell = person.Phone_cell;

            if (!ListByName.ContainsKey(name))
            {
                ListByName.Add(name, person);

                if (!ListByPhone.Contains(phone_cell))
                {
                    ListByPhone.Add(phone_cell, person);
                }
                return true;
            }
            else {
                string message = "This Contact Name already Exists!";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            return false;
        }
        //----------------------------------------------------------------
        public static void DeleteContact(Contact person)
        {

            string name = person.Name;
            string phone = person.Phone_cell;

            if (ListByName.ContainsKey(name))
            {
                ListByName.Remove(name);
            }
            if (ListByPhone.Contains(phone))
            {
                ListByPhone.Remove(phone);
            }
        }
        //----------------------------------------------------------------
        public static bool EditContact(Contact oldPerson, Contact newPerson)
        {

            string oldName = oldPerson.Name;
            string newName = newPerson.Name;

            string oldPhone = oldPerson.Phone_cell;
            string newPhone = newPerson.Phone_cell;

            if (!ListByName.ContainsKey(newName))
            {
                ListByName.Remove(oldName);
                ListByName.Add(newName, newPerson);
                ListByPhone.Remove(oldPhone);
                ListByPhone.Add(newPerson.Phone_cell, newPerson);

                return true;
            }
            return false;//Contact not added

        }
        //-----------------------------------------------------------------
        public static Contact LookupByName(string name)
        {
            return ListByName.ContainsKey(name) ? (Contact)ListByName[name] : null;
        }
        //-----------------------------------------------------------------
        public static Contact LookupByNumber(string phone)
        {
            return ListByPhone.ContainsKey(phone) ? (Contact)ListByPhone[phone] : null;
        }
        //-----------------------------------------------------------------
    }
}
