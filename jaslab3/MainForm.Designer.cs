namespace jaslab3
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.джерелоДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.підключенняДоБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відключенняВідБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cabinGrid = new System.Windows.Forms.DataGridView();
            this.cabinContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passengerGrid = new System.Windows.Forms.DataGridView();
            this.passengerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.cabinGrid)).BeginInit();
            this.cabinContextMenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.passengerGrid)).BeginInit();
            this.passengerContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.джерелоДанихToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // джерелоДанихToolStripMenuItem
            // 
            this.джерелоДанихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.підключенняДоБДToolStripMenuItem, this.відключенняВідБДToolStripMenuItem});
            this.джерелоДанихToolStripMenuItem.Name = "джерелоДанихToolStripMenuItem";
            this.джерелоДанихToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.джерелоДанихToolStripMenuItem.Text = "Джерело даних";
            // 
            // підключенняДоБДToolStripMenuItem
            // 
            this.підключенняДоБДToolStripMenuItem.Name = "підключенняДоБДToolStripMenuItem";
            this.підключенняДоБДToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.підключенняДоБДToolStripMenuItem.Text = "Підключення до БД";
            this.підключенняДоБДToolStripMenuItem.Click += new System.EventHandler(this.OnConnectItemClick);
            // 
            // відключенняВідБДToolStripMenuItem
            // 
            this.відключенняВідБДToolStripMenuItem.Name = "відключенняВідБДToolStripMenuItem";
            this.відключенняВідБДToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.відключенняВідБДToolStripMenuItem.Text = "Відключення від БД";
            this.відключенняВідБДToolStripMenuItem.Click += new System.EventHandler(this.OnDisconnectItemClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(542, 426);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cabinGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каюта";
            // 
            // cabinGrid
            // 
            this.cabinGrid.AllowUserToAddRows = false;
            this.cabinGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cabinGrid.ContextMenuStrip = this.cabinContextMenuStrip;
            this.cabinGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabinGrid.Location = new System.Drawing.Point(3, 16);
            this.cabinGrid.MultiSelect = false;
            this.cabinGrid.Name = "cabinGrid";
            this.cabinGrid.ReadOnly = true;
            this.cabinGrid.RowHeadersVisible = false;
            this.cabinGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cabinGrid.Size = new System.Drawing.Size(251, 407);
            this.cabinGrid.TabIndex = 0;
            this.cabinGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCabinCellClick);
            // 
            // cabinContextMenuStrip
            // 
            this.cabinContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.додатиToolStripMenuItem, this.видалитиToolStripMenuItem, this.редагуватиToolStripMenuItem});
            this.cabinContextMenuStrip.Name = "contextMenuStrip1";
            this.cabinContextMenuStrip.Size = new System.Drawing.Size(135, 70);
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.OnContextCabinAddClick);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.OnContextCabinRemoveClick);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.OnContextCabinEditClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passengerGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 426);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пасажир";
            // 
            // passengerGrid
            // 
            this.passengerGrid.AllowUserToAddRows = false;
            this.passengerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengerGrid.ContextMenuStrip = this.passengerContextMenuStrip;
            this.passengerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passengerGrid.Location = new System.Drawing.Point(3, 16);
            this.passengerGrid.MultiSelect = false;
            this.passengerGrid.Name = "passengerGrid";
            this.passengerGrid.ReadOnly = true;
            this.passengerGrid.RowHeadersVisible = false;
            this.passengerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passengerGrid.Size = new System.Drawing.Size(275, 407);
            this.passengerGrid.TabIndex = 0;
            // 
            // passengerContextMenuStrip
            // 
            this.passengerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.додатиToolStripMenuItem1, this.видалитиToolStripMenuItem1, this.редагуватиToolStripMenuItem1});
            this.passengerContextMenuStrip.Name = "contextMenuStrip2";
            this.passengerContextMenuStrip.Size = new System.Drawing.Size(135, 70);
            // 
            // додатиToolStripMenuItem1
            // 
            this.додатиToolStripMenuItem1.Name = "додатиToolStripMenuItem1";
            this.додатиToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.додатиToolStripMenuItem1.Text = "Додати";
            this.додатиToolStripMenuItem1.Click += new System.EventHandler(this.OnContextPassengerAddClick);
            // 
            // видалитиToolStripMenuItem1
            // 
            this.видалитиToolStripMenuItem1.Name = "видалитиToolStripMenuItem1";
            this.видалитиToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.видалитиToolStripMenuItem1.Text = "Видалити";
            this.видалитиToolStripMenuItem1.Click += new System.EventHandler(this.OnContextPassengerRemoveClick);
            // 
            // редагуватиToolStripMenuItem1
            // 
            this.редагуватиToolStripMenuItem1.Name = "редагуватиToolStripMenuItem1";
            this.редагуватиToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.редагуватиToolStripMenuItem1.Text = "Редагувати";
            this.редагуватиToolStripMenuItem1.Click += new System.EventHandler(this.OnContextPassengerEditClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Java & C#: Lab №3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.cabinGrid)).EndInit();
            this.cabinContextMenuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.passengerGrid)).EndInit();
            this.passengerContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip cabinContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip passengerContextMenuStrip;

        private System.Windows.Forms.DataGridView passengerGrid;

        private System.Windows.Forms.DataGridView cabinGrid;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.ToolStripMenuItem відключенняВідБДToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem підключенняДоБДToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem джерелоДанихToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}