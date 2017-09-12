using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Project.LOGIC;

namespace Project.GUI
{
    public partial class EditForm : Form
    {
        private string FileName;
        private MainForm MyForm;
        private Contact oldContact;
        public EditForm()
        {
            InitializeComponent();
            FileName = "";
        }

        public EditForm(MainForm form)
        {
            InitializeComponent();
            this.MyForm = form;
            FileName = "";
        }
     
        private void button_Edit_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();

            newContact.Phone_cell = this.textBox_cell.Text.Trim();
            newContact.Email = this.textBox_email.Text.Trim();
            newContact.Phone_home = this.textBox_home.Text.Trim();
            newContact.Name = this.textBox_Name.Text.Trim();

            if (this.FileName.Length > 0) {
                newContact.Photo = this.FileName;
            }

            if (newContact.Name.Length > 0 && newContact.Phone_cell.Length > 0)
            {
                //Display the modified Contact in DataGridView
                MyForm.updateSelectedRow(newContact);

                //Drop the old Contact and Add the new Contact in Phonebook
                Phonebook.EditContact(this.oldContact, newContact);

                this.Hide();
            }
            else {
                MessageBox.Show("Please, Enter the Contact Name and his Cell Phone", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Edit(Contact person)
        {
            this.oldContact = person;

            this.textBox_cell.Text  = person.Phone_cell;
            this.textBox_email.Text   = person.Email;
            this.textBox_home.Text  = person.Phone_home;
            this.textBox_Name.Text    = person.Name;
            if (person.Photo.Length >0)
            {
                this.pictureBox1.ImageLocation = DataText.ImagesFolder + person.Photo;
            }
            
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to Cancel this operation?";
            string title = "Confirmation";

            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button_Photo_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string filePath = openFileDialog1.FileName;
                this.FileName = DataText.getFileName(filePath);

                this.pictureBox1.ImageLocation = filePath;
                // MessageBox.Show(fileName);// <-- For debugging use
            }   
        }

        private void textBox_home_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBox_cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void button_OpenBrowser_Click(object sender, EventArgs e)
        {
            Process.Start("www.411.ca");
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
