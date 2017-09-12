namespace Project.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Contact_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Phone_Cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Phone_Home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.button_SAVE = new System.Windows.Forms.Button();
            this.button_DELETE = new System.Windows.Forms.Button();
            this.button_EDIT = new System.Windows.Forms.Button();
            this.button_FIND = new System.Windows.Forms.Button();
            this.button_List = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(1128, 18);
            this.button7.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 61);
            this.button7.TabIndex = 13;
            this.button7.Text = "Exit";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contact_Name,
            this.Contact_Phone_Cell,
            this.Contact_Phone_Home,
            this.Contact_Email,
            this.Contact_Photo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 242);
            this.dataGridView1.TabIndex = 15;
            // 
            // Contact_Name
            // 
            this.Contact_Name.HeaderText = "Name";
            this.Contact_Name.Name = "Contact_Name";
            this.Contact_Name.Width = 180;
            // 
            // Contact_Phone_Cell
            // 
            this.Contact_Phone_Cell.HeaderText = "Phone (Cell)";
            this.Contact_Phone_Cell.Name = "Contact_Phone_Cell";
            this.Contact_Phone_Cell.Width = 150;
            // 
            // Contact_Phone_Home
            // 
            this.Contact_Phone_Home.HeaderText = "Phone (Home)";
            this.Contact_Phone_Home.Name = "Contact_Phone_Home";
            this.Contact_Phone_Home.Width = 150;
            // 
            // Contact_Email
            // 
            this.Contact_Email.HeaderText = "Email";
            this.Contact_Email.Name = "Contact_Email";
            this.Contact_Email.Width = 230;
            // 
            // Contact_Photo
            // 
            this.Contact_Photo.HeaderText = "Photo";
            this.Contact_Photo.Name = "Contact_Photo";
            // 
            // button_EXIT
            // 
            this.button_EXIT.Image = global::Project.Properties.Resources.Actions_system_shutdown_icon;
            this.button_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_EXIT.Location = new System.Drawing.Point(749, 15);
            this.button_EXIT.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(117, 73);
            this.button_EXIT.TabIndex = 14;
            this.button_EXIT.Text = "Exit";
            this.button_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // button_SAVE
            // 
            this.button_SAVE.Image = global::Project.Properties.Resources.Save_icon;
            this.button_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_SAVE.Location = new System.Drawing.Point(616, 15);
            this.button_SAVE.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button_SAVE.Name = "button_SAVE";
            this.button_SAVE.Size = new System.Drawing.Size(118, 73);
            this.button_SAVE.TabIndex = 12;
            this.button_SAVE.Text = "Save";
            this.button_SAVE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SAVE.UseVisualStyleBackColor = true;
            this.button_SAVE.Click += new System.EventHandler(this.button_SAVE_Click);
            // 
            // button_DELETE
            // 
            this.button_DELETE.Image = global::Project.Properties.Resources.Actions_contact_DELETE_icon2;
            this.button_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_DELETE.Location = new System.Drawing.Point(136, 15);
            this.button_DELETE.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button_DELETE.Name = "button_DELETE";
            this.button_DELETE.Size = new System.Drawing.Size(120, 73);
            this.button_DELETE.TabIndex = 11;
            this.button_DELETE.Text = "Drop";
            this.button_DELETE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DELETE.UseVisualStyleBackColor = true;
            this.button_DELETE.Click += new System.EventHandler(this.button_DELETE_Click);
            // 
            // button_EDIT
            // 
            this.button_EDIT.Image = ((System.Drawing.Image)(resources.GetObject("button_EDIT.Image")));
            this.button_EDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_EDIT.Location = new System.Drawing.Point(269, 15);
            this.button_EDIT.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button_EDIT.Name = "button_EDIT";
            this.button_EDIT.Size = new System.Drawing.Size(101, 73);
            this.button_EDIT.TabIndex = 10;
            this.button_EDIT.Text = "Edit";
            this.button_EDIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_EDIT.UseVisualStyleBackColor = true;
            this.button_EDIT.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_FIND
            // 
            this.button_FIND.Image = ((System.Drawing.Image)(resources.GetObject("button_FIND.Image")));
            this.button_FIND.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_FIND.Location = new System.Drawing.Point(501, 15);
            this.button_FIND.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button_FIND.Name = "button_FIND";
            this.button_FIND.Size = new System.Drawing.Size(101, 73);
            this.button_FIND.TabIndex = 9;
            this.button_FIND.Text = "Find";
            this.button_FIND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_FIND.UseVisualStyleBackColor = true;
            this.button_FIND.Click += new System.EventHandler(this.button_FIND_Click);
            // 
            // button_List
            // 
            this.button_List.Image = ((System.Drawing.Image)(resources.GetObject("button_List.Image")));
            this.button_List.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_List.Location = new System.Drawing.Point(385, 15);
            this.button_List.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button_List.Name = "button_List";
            this.button_List.Size = new System.Drawing.Size(101, 73);
            this.button_List.TabIndex = 8;
            this.button_List.Text = "List";
            this.button_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_List.UseVisualStyleBackColor = true;
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // button_Add
            // 
            this.button_Add.Image = ((System.Drawing.Image)(resources.GetObject("button_Add.Image")));
            this.button_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Add.Location = new System.Drawing.Point(9, 15);
            this.button_Add.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(115, 73);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Add";
            this.button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button_SAVE);
            this.Controls.Add(this.button_DELETE);
            this.Controls.Add(this.button_EDIT);
            this.Controls.Add(this.button_FIND);
            this.Controls.Add(this.button_List);
            this.Controls.Add(this.button_Add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "PhoneBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button_SAVE;
        private System.Windows.Forms.Button button_DELETE;
        private System.Windows.Forms.Button button_EDIT;
        private System.Windows.Forms.Button button_FIND;
        private System.Windows.Forms.Button button_List;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_EXIT;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Phone_Cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Phone_Home;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Photo;
    }
}

