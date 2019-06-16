﻿namespace BusStation
{
    partial class CashboxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashboxForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.NumberOfFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfEmptySeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.ticketsGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberFlight2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(292, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // scheduleGridView
            // 
            this.scheduleGridView.AllowUserToAddRows = false;
            this.scheduleGridView.AllowUserToDeleteRows = false;
            this.scheduleGridView.AllowUserToResizeColumns = false;
            this.scheduleGridView.AllowUserToResizeRows = false;
            this.scheduleGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleGridView.BackgroundColor = System.Drawing.Color.White;
            this.scheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfFlight,
            this.Point,
            this.DepartureDate,
            this.DepartureTime,
            this.CountOfEmptySeats});
            this.scheduleGridView.Location = new System.Drawing.Point(6, 72);
            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.ReadOnly = true;
            this.scheduleGridView.RowHeadersVisible = false;
            this.scheduleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scheduleGridView.Size = new System.Drawing.Size(737, 264);
            this.scheduleGridView.TabIndex = 5;
            this.scheduleGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleGridView_CellClick);
            // 
            // NumberOfFlight
            // 
            this.NumberOfFlight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberOfFlight.HeaderText = "Номер рейса";
            this.NumberOfFlight.Name = "NumberOfFlight";
            this.NumberOfFlight.ReadOnly = true;
            // 
            // Point
            // 
            this.Point.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Point.HeaderText = "Конечный пункт";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            // 
            // DepartureDate
            // 
            this.DepartureDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartureDate.HeaderText = "Дата отправления";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            // 
            // DepartureTime
            // 
            this.DepartureTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartureTime.HeaderText = "Время отправления";
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
            // 
            // CountOfEmptySeats
            // 
            this.CountOfEmptySeats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountOfEmptySeats.HeaderText = "Количество пустых мест";
            this.CountOfEmptySeats.Name = "CountOfEmptySeats";
            this.CountOfEmptySeats.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(668, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Update_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 425);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.scheduleGridView);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Касса";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(211, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 60);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 60);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(8, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Совершить покупку";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.MakePurchase);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.ticketsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мои билеты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(8, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "Вернуть билет";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ReturnTicket_Click);
            // 
            // ticketsGridView
            // 
            this.ticketsGridView.AllowUserToAddRows = false;
            this.ticketsGridView.AllowUserToDeleteRows = false;
            this.ticketsGridView.AllowUserToResizeColumns = false;
            this.ticketsGridView.AllowUserToResizeRows = false;
            this.ticketsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ticketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NumberFlight2,
            this.DepartureDate2,
            this.DepartureTime2,
            this.Point2});
            this.ticketsGridView.Location = new System.Drawing.Point(8, 6);
            this.ticketsGridView.Name = "ticketsGridView";
            this.ticketsGridView.ReadOnly = true;
            this.ticketsGridView.RowHeadersVisible = false;
            this.ticketsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ticketsGridView.Size = new System.Drawing.Size(735, 289);
            this.ticketsGridView.TabIndex = 1;
            this.ticketsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NumberFlight2
            // 
            this.NumberFlight2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberFlight2.HeaderText = "Номер рейса";
            this.NumberFlight2.Name = "NumberFlight2";
            this.NumberFlight2.ReadOnly = true;
            // 
            // DepartureDate2
            // 
            this.DepartureDate2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartureDate2.HeaderText = "Дата отправления";
            this.DepartureDate2.Name = "DepartureDate2";
            this.DepartureDate2.ReadOnly = true;
            // 
            // DepartureTime2
            // 
            this.DepartureTime2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartureTime2.HeaderText = "Время отправления";
            this.DepartureTime2.Name = "DepartureTime2";
            this.DepartureTime2.ReadOnly = true;
            // 
            // Point2
            // 
            this.Point2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Point2.HeaderText = "Место прибытия";
            this.Point2.Name = "Point2";
            this.Point2.ReadOnly = true;
            // 
            // CashboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 426);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashboxForm";
            this.Text = "Личный кабинет";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView scheduleGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView ticketsGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfEmptySeats;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberFlight2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point2;
    }
}