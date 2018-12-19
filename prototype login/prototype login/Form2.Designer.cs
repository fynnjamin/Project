namespace prototype_login
{
    partial class Form2
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
            this.DONE = new System.Windows.Forms.Button();
            this.first_name = new System.Windows.Forms.RichTextBox();
            this.last_name = new System.Windows.Forms.RichTextBox();
            this.PASSWORD = new System.Windows.Forms.RichTextBox();
            this.USERNAME = new System.Windows.Forms.RichTextBox();
            this.fisrtname = new System.Windows.Forms.TextBox();
            this.Password_1 = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DONE
            // 
            this.DONE.Location = new System.Drawing.Point(189, 272);
            this.DONE.Name = "DONE";
            this.DONE.Size = new System.Drawing.Size(75, 23);
            this.DONE.TabIndex = 0;
            this.DONE.Text = "DONE";
            this.DONE.UseVisualStyleBackColor = true;
            this.DONE.Click += new System.EventHandler(this.DONE_Click);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(62, 60);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(110, 22);
            this.first_name.TabIndex = 1;
            this.first_name.Text = "";
            this.first_name.TextChanged += new System.EventHandler(this.first_name_TextChanged);
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(62, 88);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(110, 26);
            this.last_name.TabIndex = 2;
            this.last_name.Text = "";
            this.last_name.TextChanged += new System.EventHandler(this.last_name_TextChanged);
            // 
            // PASSWORD
            // 
            this.PASSWORD.Location = new System.Drawing.Point(62, 154);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(110, 31);
            this.PASSWORD.TabIndex = 3;
            this.PASSWORD.Text = "";
            this.PASSWORD.TextChanged += new System.EventHandler(this.PASSWORD_TextChanged);
            // 
            // USERNAME
            // 
            this.USERNAME.Location = new System.Drawing.Point(62, 120);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(110, 28);
            this.USERNAME.TabIndex = 4;
            this.USERNAME.Text = "";
            this.USERNAME.TextChanged += new System.EventHandler(this.USERNAME_TextChanged);
            // 
            // fisrtname
            // 
            this.fisrtname.Location = new System.Drawing.Point(178, 60);
            this.fisrtname.Name = "fisrtname";
            this.fisrtname.Size = new System.Drawing.Size(100, 20);
            this.fisrtname.TabIndex = 5;
            this.fisrtname.TextChanged += new System.EventHandler(this.fisrtname_TextChanged);
            // 
            // Password_1
            // 
            this.Password_1.Location = new System.Drawing.Point(178, 154);
            this.Password_1.Name = "Password_1";
            this.Password_1.Size = new System.Drawing.Size(100, 20);
            this.Password_1.TabIndex = 6;
            this.Password_1.TextChanged += new System.EventHandler(this.Password_1_TextChanged);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(178, 120);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 7;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(178, 94);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 8;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 332);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Password_1);
            this.Controls.Add(this.fisrtname);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.DONE);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DONE;
        private System.Windows.Forms.RichTextBox first_name;
        private System.Windows.Forms.RichTextBox last_name;
        private System.Windows.Forms.RichTextBox PASSWORD;
        private System.Windows.Forms.RichTextBox USERNAME;
        private System.Windows.Forms.TextBox fisrtname;
        private System.Windows.Forms.TextBox Password_1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox lastname;
    }
}