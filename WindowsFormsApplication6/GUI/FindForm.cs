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
    public partial class FindForm : Form
    {
        private MainForm MyForm;

        public FindForm()
        {
            InitializeComponent();
        }
         public FindForm(MainForm form)
        {
            InitializeComponent();
            this.MyForm = form;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            if (this.radioButton_Name.Checked == true)
            {
                string name = this.textBox_Name.Text.Trim();
                name = DataText.FirstCharToUpper(name);

                if (name.Length > 0)
                {
                    Contact person = Phonebook.LookupByName(name);
                    if (person != null)
                    {
                        this.MyForm.displayContact(person);
                    }
                    else {
                        MessageBox.Show("Contact Name : "+name+" is Not Found !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  
                }
                else {
                    MessageBox.Show("Please, Enter the Name to Find the Contact Info", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (this.radioButton_Phone.Checked == true)
            {
                string phone = this.textBox_Phone.Text.Trim();
                if (phone.Length > 0)
                {
                    Contact person = Phonebook.LookupByNumber(phone);
                    if (person != null)
                    {
                        this.MyForm.displayContact(person);
                    }
                    else
                    {
                        MessageBox.Show("Phone Number : " + phone + " is Not Found !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please, Enter the Phone Number to Find the Contact Info", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Hide();
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to Cancel this operation?";
            string title = "Confirmation";

            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void radioButton_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_Name.Checked == true)
            {
                this.textBox_Name.Enabled = true;
                this.textBox_Name.Clear();
            }
            else {
                this.textBox_Name.Enabled = false;
                this.textBox_Name.Clear();
            }
        }

        private void radioButton_Phone_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_Phone.Checked == true)
            {
                this.textBox_Phone.Enabled = true;
                this.textBox_Phone.Clear();
            }
            else
            {
                this.textBox_Phone.Enabled = false;
                this.textBox_Phone.Clear();
            }
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            this.radioButton_Name.Checked = true;
            this.textBox_Name.Enabled = true;

            this.radioButton_Phone.Checked = false;
            this.textBox_Phone.Enabled = false;
        }

        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

    }
}
