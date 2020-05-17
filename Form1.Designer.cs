namespace ProjectCardHip
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
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.Location = new System.Drawing.Point(187, 12);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(1038, 133);
            this.pnlPlayer1.TabIndex = 0;
            this.pnlPlayer1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPlayer1_Paint);
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Location = new System.Drawing.Point(187, 445);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(1038, 138);
            this.pnlPlayer2.TabIndex = 1;
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(187, 194);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(1038, 194);
            this.pnlTable.TabIndex = 2;
            this.pnlTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTable_Paint);
            // 
            // pnlDeck
            // 
            this.pnlDeck.Location = new System.Drawing.Point(12, 235);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(137, 132);
            this.pnlDeck.TabIndex = 3;
            this.pnlDeck.Click += new System.EventHandler(this.pnlDeck_Click);
            this.pnlDeck.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeck_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(40, 104);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1275, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Panel pnlDeck;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button1;
    }
}

