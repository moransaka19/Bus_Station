namespace Курсач
{
    partial class Cashbox
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
            this.SuspendLayout();
            // 
            // buttonCreditOrder
            // 
            this.buttonCreditOrder.Location = new System.Drawing.Point(12, 294);
            this.buttonCreditOrder.Name = "buttonCreditOrder";
            this.buttonCreditOrder.Size = new System.Drawing.Size(113, 55);
            this.buttonCreditOrder.TabIndex = 1;
            this.buttonCreditOrder.Text = "Оформить покупку";
            this.buttonCreditOrder.UseVisualStyleBackColor = true;
            this.buttonCreditOrder.Click += new System.EventHandler(this.CreditOrder);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // buttonShowTicket
            // 
            this.buttonShowTicket.Location = new System.Drawing.Point(279, 294);
            this.buttonShowTicket.Name = "buttonShowTicket";
            this.buttonShowTicket.Size = new System.Drawing.Size(113, 55);
            this.buttonShowTicket.TabIndex = 4;
            this.buttonShowTicket.Text = "Показать билет";
            this.buttonShowTicket.UseVisualStyleBackColor = true;
            this.buttonShowTicket.Click += new System.EventHandler(this.ButtonShowTicket_Click);
            // 
            // Cashbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.buttonShowTicket);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCreditOrder);
            this.Name = "Cashbox";
            this.Text = "Cashbox";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Button buttonCreditOrder;
        private System.Windows.Forms.Button buttonShowTicket;
    }
}