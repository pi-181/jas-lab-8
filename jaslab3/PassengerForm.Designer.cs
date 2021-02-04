using System.ComponentModel;

namespace jaslab3
{
    partial class PassengerForm
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.secondNameBox = new System.Windows.Forms.TextBox();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(12, 27);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(160, 20);
            this.firstNameBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 135);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(97, 135);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редагувати";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.OnEditButtonClick);
            // 
            // secondNameBox
            // 
            this.secondNameBox.Location = new System.Drawing.Point(12, 68);
            this.secondNameBox.Name = "secondNameBox";
            this.secondNameBox.Size = new System.Drawing.Size(160, 20);
            this.secondNameBox.TabIndex = 3;
            // 
            // sexBox
            // 
            this.sexBox.Location = new System.Drawing.Point(12, 109);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(160, 20);
            this.sexBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Прізвище";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пол";
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 169);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.secondNameBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.firstNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PassengerForm";
            this.Text = "Пасажири";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox sexBox;

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox secondNameBox;

        #endregion
    }
}