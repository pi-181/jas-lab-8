using System.ComponentModel;

namespace jaslab3
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.hostBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.databaseBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(7, 27);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(170, 20);
            this.hostBox.TabIndex = 0;
            this.hostBox.Text = "127.0.0.1";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(7, 68);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(170, 20);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "5432";
            // 
            // databaseBox
            // 
            this.databaseBox.Location = new System.Drawing.Point(7, 115);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(170, 20);
            this.databaseBox.TabIndex = 2;
            this.databaseBox.Text = "jaslab3";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(7, 156);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(170, 20);
            this.userBox.TabIndex = 3;
            this.userBox.Text = "postgres";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(7, 199);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(170, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Підключитися";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnConnectButtonClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Database";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "User";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 259);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.databaseBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.hostBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionForm";
            this.Text = "Підключення";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox databaseBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passwordBox;

        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.TextBox portBox;

        #endregion
    }
}