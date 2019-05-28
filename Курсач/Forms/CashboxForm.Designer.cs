namespace Курсач
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
            this.buttonCreditOrder = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonShowTicket = new System.Windows.Forms.Button();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.NumberOfFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfEmptySeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreditOrder
            // 
            this.buttonCreditOrder.Location = new System.Drawing.Point(12, 311);
            this.buttonCreditOrder.Name = "buttonCreditOrder";
            this.buttonCreditOrder.Size = new System.Drawing.Size(113, 55);
            this.buttonCreditOrder.TabIndex = 1;
            this.buttonCreditOrder.Text = "Оформить покупку";
            this.buttonCreditOrder.UseVisualStyleBackColor = true;
            this.buttonCreditOrder.Click += new System.EventHandler(this.MakePurchase);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // buttonShowTicket
            // 
            this.buttonShowTicket.Location = new System.Drawing.Point(479, 311);
            this.buttonShowTicket.Name = "buttonShowTicket";
            this.buttonShowTicket.Size = new System.Drawing.Size(113, 55);
            this.buttonShowTicket.TabIndex = 4;
            this.buttonShowTicket.Text = "Показать билет";
            this.buttonShowTicket.UseVisualStyleBackColor = true;
            this.buttonShowTicket.Click += new System.EventHandler(this.ButtonShowTicket_Click);
            // 
            // scheduleGridView
            // 
            this.scheduleGridView.AllowUserToAddRows = false;
            this.scheduleGridView.AllowUserToDeleteRows = false;
            this.scheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfFlight,
            this.Point,
            this.DepartureTime,
            this.CountOfEmptySeats});
            this.scheduleGridView.Location = new System.Drawing.Point(16, 66);
            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.ReadOnly = true;
            this.scheduleGridView.Size = new System.Drawing.Size(576, 170);
            this.scheduleGridView.TabIndex = 5;
            this.scheduleGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleGridView_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update_Click);
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
            // DepartureTime
            // 
            this.DepartureTime.HeaderText = "Время отправления";
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
            // 
            // CountOfEmptySeats
            // 
            this.CountOfEmptySeats.HeaderText = "Количество пустых мест";
            this.CountOfEmptySeats.Name = "CountOfEmptySeats";
            this.CountOfEmptySeats.ReadOnly = true;
            // 
            // Cashbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scheduleGridView);
            this.Controls.Add(this.buttonShowTicket);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCreditOrder);
            this.Name = "Cashbox";
            this.Text = "Cashbox";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Button buttonCreditOrder;
        private System.Windows.Forms.Button buttonShowTicket;
        private System.Windows.Forms.DataGridView scheduleGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfEmptySeats;
    }
}