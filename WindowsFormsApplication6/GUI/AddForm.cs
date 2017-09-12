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
using System.Diagnostics;

namespace Project.GUI
{
    public partial class AddForm : Form
    {
        private string FileName;
        private MainForm MyForm;
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(MainForm form)
        {
            InitializeComponent();
            this.MyForm = form;
            FileName = "";
        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = this.textBox_Name.Text.Trim();
            string phone_cell = this.textBox_cell.Text.Trim();
            string phone_home = this.textBox_home.Text.Trim();
            string email = this.textBox_email.Text.Trim();

            if (name.Length > 0 && phone_cell.Length > 0)
            {
                Contact person = new Contact();

                person.Name = name;
                person.Phone_cell = phone_cell;
                person.Phone_home = phone_home;
                person.Email = email;
                person.Photo = this.FileName;

                //Add Contact to the List of Phonebook
                bool isAdded = Phonebook.AddContact(person);

                if(isAdded == true){
                    //Display Contact in the DataGridView
                    this.MyForm.dataGridView1.Rows.Add(person.Name, person.Phone_cell, person.Phone_home, person.Email, person.Photo);
                }
               this.Hide();
            }
            else {
                MessageBox.Show("Please, Enter the Contact Name and his Cell Phone", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        

        private void textBox_cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBox_home_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to Cancel this operation?";
            string title = "Confirmation";

            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button_OpenBrowser_Click(object sender, EventArgs e)
        {
            Process.Start("www.411.ca");
        }
    }
}
