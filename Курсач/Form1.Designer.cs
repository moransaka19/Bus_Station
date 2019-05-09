namespace Курсач
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowTicket = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowTicket
            // 
            this.buttonShowTicket.Enabled = false;
            this.buttonShowTicket.Location = new System.Drawing.Point(12, 93);
            this.buttonShowTicket.Name = "buttonShowTicket";
            this.buttonShowTicket.Size = new System.Drawing.Size(97, 21);
            this.buttonShowTicket.TabIndex = 0;
            this.buttonShowTicket.Text = "Показать билет";
            this.buttonShowTicket.UseVisualStyleBackColor = true;
            this.buttonShowTicket.Click += new System.EventHandler(this.ShowTicket);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Купить билет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BuyTicket);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(201, 212);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 52);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitProgram);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 276);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonShowTicket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonShowTicket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Exit;
    }
}

