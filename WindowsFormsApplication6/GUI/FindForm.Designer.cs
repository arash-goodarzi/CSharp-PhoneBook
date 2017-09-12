namespace Project.GUI
{
    partial class FindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Cell = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Find = new System.Windows.Forms.Button();
            this.radioButton_Name = new System.Windows.Forms.RadioButton();
            this.radioButton_Phone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(205, 88);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(155, 24);
            this.textBox_Phone.TabIndex = 23;
            this.textBox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone_KeyPress);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(155, 40);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(205, 24);
            this.textBox_Name.TabIndex = 21;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Image = global::Project.Properties.Resources.Basic_Close;
            this.button_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Cancel.Location = new System.Drawing.Point(137, 148);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(96, 43);
            this.button_Cancel.TabIndex = 24;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Cell
            // 
            this.label_Cell.Image = global::Project.Properties.Resources.Rokey_Wifun_Cellphone;
            this.label_Cell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Cell.Location = new System.Drawing.Point(12, 85);
            this.label_Cell.Name = "label_Cell";
            this.label_Cell.Size = new System.Drawing.Size(39, 30);
            this.label_Cell.TabIndex = 22;
            this.label_Cell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Name
            // 
            this.label_Name.Image = global::Project.Properties.Resources.Icons_Land_Vista_People_Person_Male_Light;
            this.label_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Name.Location = new System.Drawing.Point(12, 33);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(37, 39);
            this.label_Name.TabIndex = 20;
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Find
            // 
            this.button_Find.Image = global::Project.Properties.Resources.Basic_Zoom;
            this.button_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Find.Location = new System.Drawing.Point(264, 148);
            this.button_Find.Margin = new System.Windows.Forms.Padding(4);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(96, 43);
            this.button_Find.TabIndex = 25;
            this.button_Find.Text = "Find";
            this.button_Find.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // radioButton_Name
            // 
            this.radioButton_Name.AutoSize = true;
            this.radioButton_Name.Location = new System.Drawing.Point(55, 42);
            this.radioButton_Name.Name = "radioButton_Name";
            this.radioButton_Name.Size = new System.Drawing.Size(94, 22);
            this.radioButton_Name.TabIndex = 26;
            this.radioButton_Name.TabStop = true;
            this.radioButton_Name.Text = "By Name";
            this.radioButton_Name.UseVisualStyleBackColor = true;
            this.radioButton_Name.CheckedChanged += new System.EventHandler(this.radioButton_Name_CheckedChanged);
            // 
            // radioButton_Phone
            // 
            this.radioButton_Phone.AutoSize = true;
            this.radioButton_Phone.Location = new System.Drawing.Point(56, 89);
            this.radioButton_Phone.Name = "radioButton_Phone";
            this.radioButton_Phone.Size = new System.Drawing.Size(143, 22);
            this.radioButton_Phone.TabIndex = 27;
            this.radioButton_Phone.TabStop = true;
            this.radioButton_Phone.Text = "By Phone - Cell";
            this.radioButton_Phone.UseVisualStyleBackColor = true;
            this.radioButton_Phone.CheckedChanged += new System.EventHandler(this.radioButton_Phone_CheckedChanged);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 210);
            this.Controls.Add(this.radioButton_Phone);
            this.Controls.Add(this.radioButton_Name);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label_Cell);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Cell;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.RadioButton radioButton_Name;
        private System.Windows.Forms.RadioButton radioButton_Phone;
    }
}