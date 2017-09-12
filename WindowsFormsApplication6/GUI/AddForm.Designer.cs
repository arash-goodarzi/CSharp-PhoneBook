namespace Project.GUI
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_cell = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_home = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_OpenBrowser = new System.Windows.Forms.Button();
            this.button_Photo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Home = new System.Windows.Forms.Label();
            this.label_Cell = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(99, 156);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(223, 24);
            this.textBox_email.TabIndex = 18;
            // 
            // textBox_cell
            // 
            this.textBox_cell.Location = new System.Drawing.Point(157, 70);
            this.textBox_cell.Name = "textBox_cell";
            this.textBox_cell.Size = new System.Drawing.Size(165, 24);
            this.textBox_cell.TabIndex = 14;
            this.textBox_cell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cell_KeyPress);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(99, 27);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(223, 24);
            this.textBox_Name.TabIndex = 12;
            // 
            // textBox_home
            // 
            this.textBox_home.Location = new System.Drawing.Point(157, 114);
            this.textBox_home.Name = "textBox_home";
            this.textBox_home.Size = new System.Drawing.Size(165, 24);
            this.textBox_home.TabIndex = 22;
            this.textBox_home.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_home_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_OpenBrowser
            // 
            this.button_OpenBrowser.Image = global::Project.Properties.Resources.Treetog_I_Internet_Document;
            this.button_OpenBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OpenBrowser.Location = new System.Drawing.Point(338, 208);
            this.button_OpenBrowser.Name = "button_OpenBrowser";
            this.button_OpenBrowser.Size = new System.Drawing.Size(132, 43);
            this.button_OpenBrowser.TabIndex = 27;
            this.button_OpenBrowser.Text = "www.411.ca";
            this.button_OpenBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OpenBrowser.UseVisualStyleBackColor = true;
            this.button_OpenBrowser.Click += new System.EventHandler(this.button_OpenBrowser_Click);
            // 
            // button_Photo
            // 
            this.button_Photo.Image = global::Project.Properties.Resources.Folder_my_video;
            this.button_Photo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Photo.Location = new System.Drawing.Point(338, 156);
            this.button_Photo.Name = "button_Photo";
            this.button_Photo.Size = new System.Drawing.Size(132, 36);
            this.button_Photo.TabIndex = 26;
            this.button_Photo.Text = "Photo";
            this.button_Photo.UseVisualStyleBackColor = true;
            this.button_Photo.Click += new System.EventHandler(this.button_Photo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::Project.Properties.Resources.Places_user_identity_icon;
            this.pictureBox1.Location = new System.Drawing.Point(338, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 134);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Image = global::Project.Properties.Resources.Basic_Close;
            this.button_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Cancel.Location = new System.Drawing.Point(99, 208);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(96, 43);
            this.button_Cancel.TabIndex = 19;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Email
            // 
            this.label_Email.Image = global::Project.Properties.Resources.Aroche_Delta_Mail;
            this.label_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Email.Location = new System.Drawing.Point(9, 146);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(81, 41);
            this.label_Email.TabIndex = 17;
            this.label_Email.Text = "Email";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Home
            // 
            this.label_Home.Image = global::Project.Properties.Resources.Artua_Mac_Home;
            this.label_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Home.Location = new System.Drawing.Point(6, 104);
            this.label_Home.Name = "label_Home";
            this.label_Home.Size = new System.Drawing.Size(151, 41);
            this.label_Home.TabIndex = 15;
            this.label_Home.Text = "Phone - Home";
            this.label_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Cell
            // 
            this.label_Cell.Image = global::Project.Properties.Resources.Rokey_Wifun_Cellphone;
            this.label_Cell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Cell.Location = new System.Drawing.Point(4, 66);
            this.label_Cell.Name = "label_Cell";
            this.label_Cell.Size = new System.Drawing.Size(137, 30);
            this.label_Cell.TabIndex = 13;
            this.label_Cell.Text = "Phone - Cell";
            this.label_Cell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Name
            // 
            this.label_Name.Image = global::Project.Properties.Resources.Icons_Land_Vista_People_Person_Male_Light;
            this.label_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Name.Location = new System.Drawing.Point(9, 12);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(82, 39);
            this.label_Name.TabIndex = 11;
            this.label_Name.Text = "Name";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Add
            // 
            this.button_Add.Image = global::Project.Properties.Resources.Text_Edit;
            this.button_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Add.Location = new System.Drawing.Point(226, 208);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(96, 43);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Add";
            this.button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 268);
            this.Controls.Add(this.button_OpenBrowser);
            this.Controls.Add(this.button_Photo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_home);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Home);
            this.Controls.Add(this.textBox_cell);
            this.Controls.Add(this.label_Cell);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_Add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddForm";
            this.Text = "Add New Contact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Home;
        private System.Windows.Forms.TextBox textBox_cell;
        private System.Windows.Forms.Label label_Cell;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Photo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_OpenBrowser;
    }
}