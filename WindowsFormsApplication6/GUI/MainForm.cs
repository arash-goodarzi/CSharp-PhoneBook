using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.LOGIC;

namespace Project.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            int selectedRow = this.dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            if (selectedRow >= 0)
            {


                Contact person = getSelectedContact(selectedRow);

                EditForm form = new EditForm(this);
                form.Show();
                form.Edit(person);
            }
            else {
                MessageBox.Show("Please, Select the Contact you want to Edit", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateSelectedRow(Contact person)
        {

            int selectedRow = this.dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[selectedRow];

                row.Cells["Contact_Name"].Value = person.Name;
                row.Cells["Contact_Phone_Home"].Value = person.Phone_home;
                row.Cells["Contact_Phone_Cell"].Value = person.Phone_cell;
                row.Cells["Contact_Email"].Value = person.Email;
                row.Cells["Contact_Photo"].Value = person.Photo;
            }

        }

        public void displayContact(Contact person)
        {
            this.dataGridView1.Rows.Clear();
            //Display Contact in the DataGridView
            this.dataGridView1.Rows.Add(person.Name, person.Phone_cell, person.Phone_home, person.Email, person.Photo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read Data From a Text File
            //List<Contact> allContacts = DataText.ReadText_List(DataText.FileName);
           
            //Read Data From a XMLBinary File
            //List<Contact> allContacts = DataXMLBinary.ReadXML_List(DataXMLBinary.FileName);

            //Read Data From a XMLText File
            List<Contact> allContacts = DataXML.ReadXML_List(DataXML.FileName);

            Phonebook.loadFromList(allContacts);

            //Display the contact list in DataGridView
            refreshDataGrid();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm(this);
            frm.Show();
        }

        private void button_DELETE_Click(object sender, EventArgs e)
        {
            int selectedRow = this.dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            
            if (selectedRow >= 0 && selectedRow < this.dataGridView1.Rows.Count - 1)
            {
                //Delete Contact from Lists of Phonebook
                Contact person = getSelectedContact(selectedRow);
                Phonebook.DeleteContact(person);

                //Delete Contact from DataGridView
                this.dataGridView1.Rows.RemoveAt(selectedRow);
            }
            else {
                MessageBox.Show("Please, Select the Contact you want to Delete", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Contact getSelectedContact(int index) {

            DataGridViewRow row = this.dataGridView1.Rows[index];

            string name = (string)row.Cells["Contact_Name"].Value;
            string phone_home = (string)row.Cells["Contact_Phone_Home"].Value;
            string phone_cell = (string)row.Cells["Contact_Phone_Cell"].Value;
            string email = (string)row.Cells["Contact_Email"].Value;
            string photo = (string)row.Cells["Contact_Photo"].Value;
            Contact person = new Contact();
            person.Name = name;
            person.Phone_cell = phone_cell;
            person.Phone_home = phone_home;
            person.Email = email;
            person.Photo = photo;

            return person;
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to quit ?\n"+ "Did you save your Contacts ?";
            string title = "Confirmation";

            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void button_SAVE_Click(object sender, EventArgs e)
        {
            List<Contact> people = new List<Contact>();
            for (int i = 0; i < Phonebook.ListByName.Count; i++)
            {
                Contact person = (Contact)Phonebook.ListByName.GetByIndex(i);
                people.Add(person);
            }

            //Save the Phonebook List in Text File
            //DataText.WriteText_List(people , DataText.FileName);

            //Save the Phonebook List in XMLBinary File
            //DataXMLBinary.WriteXML_List(people , DataXMLBinary.FileName);
           
            //Save the Phonebook List in XMLText File
            DataXML.WriteXML_List(people, DataXML.FileName);
        }

        private void button_FIND_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm(this);
            frm.Show();
        }
        private void refreshDataGrid() {

            this.dataGridView1.Rows.Clear();
            //Display Data from Phonebook List
            for (int i = 0; i < Phonebook.ListByName.Count; i++)
            {
                // Create a new row first as it will include the columns you've created at design-time.
                int rowId = this.dataGridView1.Rows.Add();

                // Grab the new row!
                DataGridViewRow row = dataGridView1.Rows[rowId];
                Contact person = (Contact)Phonebook.ListByName.GetByIndex(i);
                // Add the data
                row.Cells["Contact_Name"].Value = person.Name;
                row.Cells["Contact_Phone_Home"].Value = person.Phone_home;
                row.Cells["Contact_Phone_Cell"].Value = person.Phone_cell;
                row.Cells["Contact_Email"].Value = person.Email;
                row.Cells["Contact_Photo"].Value = person.Photo;

            }
        }

    }
}
