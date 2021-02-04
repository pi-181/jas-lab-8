using System.ComponentModel;

namespace jaslab3
{
    partial class CabinForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.squareBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.classBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 35);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(160, 20);
            this.nameBox.TabIndex = 0;
            // 
            // squareBox
            // 
            this.squareBox.Location = new System.Drawing.Point(12, 77);
            this.squareBox.Name = "squareBox";
            this.squareBox.Size = new System.Drawing.Size(160, 20);
            this.squareBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 159);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(97, 159);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Редагувати";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.OnEditButtonClick);
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(12, 118);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(160, 20);
            this.classBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Назва каюти";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Площа";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Клас";
            // 
            // CabinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(184, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.squareBox);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "CabinForm";
            this.Text = "Каюта";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox classBox;

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox squareBox;

        #endregion
    }
}