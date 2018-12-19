namespace prototype_login
{
    partial class Form1
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
            this.LOGIN = new System.Windows.Forms.Button();
            this.SIGN = new System.Windows.Forms.Button();
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.USERTEXT = new System.Windows.Forms.RichTextBox();
            this.PASSTEXT = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(119, 269);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(75, 23);
            this.LOGIN.TabIndex = 0;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // SIGN
            // 
            this.SIGN.Location = new System.Drawing.Point(284, 269);
            this.SIGN.Name = "SIGN";
            this.SIGN.Size = new System.Drawing.Size(75, 23);
            this.SIGN.TabIndex = 1;
            this.SIGN.Text = "SIGN UP";
            this.SIGN.UseVisualStyleBackColor = true;
            this.SIGN.Click += new System.EventHandler(this.SIGN_Click);
            // 
            // USERNAME
            // 
            this.USERNAME.Location = new System.Drawing.Point(160, 103);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(184, 20);
            this.USERNAME.TabIndex = 2;
            this.USERNAME.TextChanged += new System.EventHandler(this.USERNAME_TextChanged);
            // 
            // PASSWORD
            // 
            this.PASSWORD.Location = new System.Drawing.Point(160, 130);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(184, 20);
            this.PASSWORD.TabIndex = 3;
            this.PASSWORD.UseSystemPasswordChar = true;
            this.PASSWORD.TextChanged += new System.EventHandler(this.PASSWORD_TextChanged);
            // 
            // USERTEXT
            // 
            this.USERTEXT.Location = new System.Drawing.Point(54, 103);
            this.USERTEXT.Name = "USERTEXT";
            this.USERTEXT.Size = new System.Drawing.Size(100, 20);
            this.USERTEXT.TabIndex = 4;
            this.USERTEXT.Text = "";
            this.USERTEXT.TextChanged += new System.EventHandler(this.USERTEXT_TextChanged);
            // 
            // PASSTEXT
            // 
            this.PASSTEXT.Location = new System.Drawing.Point(54, 130);
            this.PASSTEXT.Name = "PASSTEXT";
            this.PASSTEXT.Size = new System.Drawing.Size(100, 20);
            this.PASSTEXT.TabIndex = 5;
            this.PASSTEXT.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 423);
            this.Controls.Add(this.PASSTEXT);
            this.Controls.Add(this.USERTEXT);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.SIGN);
            this.Controls.Add(this.LOGIN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Button SIGN;
        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.RichTextBox USERTEXT;
        private System.Windows.Forms.RichTextBox PASSTEXT;
        public System.Windows.Forms.TextBox PASSWORD;
    }
}

