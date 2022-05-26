namespace MiguelsAndJosh_Module8
{
    partial class frmCheck
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnFinalOrder = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblDebitCard = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtDebitNum = new System.Windows.Forms.TextBox();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.txtCreditNum = new System.Windows.Forms.TextBox();
            this.radDebit = new System.Windows.Forms.RadioButton();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.radMoney = new System.Windows.Forms.RadioButton();
            this.lstCheck = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(446, 551);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(185, 49);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnFinalOrder
            // 
            this.btnFinalOrder.Location = new System.Drawing.Point(709, 551);
            this.btnFinalOrder.Name = "btnFinalOrder";
            this.btnFinalOrder.Size = new System.Drawing.Size(171, 49);
            this.btnFinalOrder.TabIndex = 2;
            this.btnFinalOrder.Text = "Place Final Order";
            this.btnFinalOrder.UseVisualStyleBackColor = true;
            this.btnFinalOrder.Click += new System.EventHandler(this.btnFinalOrder_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(311, 64);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(235, 403);
            this.lstOrder.TabIndex = 3;
            // 
            // gbxPayment
            // 
            this.gbxPayment.Controls.Add(this.lblPin);
            this.gbxPayment.Controls.Add(this.lblDebitCard);
            this.gbxPayment.Controls.Add(this.txtPin);
            this.gbxPayment.Controls.Add(this.txtDebitNum);
            this.gbxPayment.Controls.Add(this.lblCreditCard);
            this.gbxPayment.Controls.Add(this.txtCreditNum);
            this.gbxPayment.Controls.Add(this.radDebit);
            this.gbxPayment.Controls.Add(this.radCredit);
            this.gbxPayment.Controls.Add(this.radMoney);
            this.gbxPayment.Location = new System.Drawing.Point(567, 133);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(262, 228);
            this.gbxPayment.TabIndex = 4;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "groupBox1";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(116, 138);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(98, 13);
            this.lblPin.TabIndex = 8;
            this.lblPin.Text = "Enter your debit pin";
            this.lblPin.Visible = false;
            // 
            // lblDebitCard
            // 
            this.lblDebitCard.AutoSize = true;
            this.lblDebitCard.Location = new System.Drawing.Point(105, 186);
            this.lblDebitCard.Name = "lblDebitCard";
            this.lblDebitCard.Size = new System.Drawing.Size(145, 13);
            this.lblDebitCard.TabIndex = 6;
            this.lblDebitCard.Text = "Enter your Debit card number";
            this.lblDebitCard.Visible = false;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(128, 154);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(70, 20);
            this.txtPin.TabIndex = 7;
            this.txtPin.Visible = false;
            // 
            // txtDebitNum
            // 
            this.txtDebitNum.Location = new System.Drawing.Point(119, 202);
            this.txtDebitNum.Name = "txtDebitNum";
            this.txtDebitNum.Size = new System.Drawing.Size(100, 20);
            this.txtDebitNum.TabIndex = 5;
            this.txtDebitNum.Visible = false;
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(105, 77);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(146, 13);
            this.lblCreditCard.TabIndex = 4;
            this.lblCreditCard.Text = "Enter your credit card number";
            this.lblCreditCard.Visible = false;
            // 
            // txtCreditNum
            // 
            this.txtCreditNum.Location = new System.Drawing.Point(119, 93);
            this.txtCreditNum.Name = "txtCreditNum";
            this.txtCreditNum.Size = new System.Drawing.Size(100, 20);
            this.txtCreditNum.TabIndex = 3;
            this.txtCreditNum.Visible = false;
            this.txtCreditNum.TextChanged += new System.EventHandler(this.txtCreditNum_TextChanged);
            // 
            // radDebit
            // 
            this.radDebit.AutoSize = true;
            this.radDebit.Location = new System.Drawing.Point(22, 122);
            this.radDebit.Name = "radDebit";
            this.radDebit.Size = new System.Drawing.Size(75, 17);
            this.radDebit.TabIndex = 2;
            this.radDebit.TabStop = true;
            this.radDebit.Text = "Debit Card";
            this.radDebit.UseVisualStyleBackColor = true;
            this.radDebit.CheckedChanged += new System.EventHandler(this.btnDebit_CheckedChanged);
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Location = new System.Drawing.Point(22, 75);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(77, 17);
            this.radCredit.TabIndex = 1;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit Card";
            this.radCredit.UseVisualStyleBackColor = true;
            this.radCredit.CheckedChanged += new System.EventHandler(this.radCredit_CheckedChanged);
            // 
            // radMoney
            // 
            this.radMoney.AutoSize = true;
            this.radMoney.Location = new System.Drawing.Point(22, 33);
            this.radMoney.Name = "radMoney";
            this.radMoney.Size = new System.Drawing.Size(49, 17);
            this.radMoney.TabIndex = 0;
            this.radMoney.TabStop = true;
            this.radMoney.Text = "Cash";
            this.radMoney.UseVisualStyleBackColor = true;
            this.radMoney.CheckedChanged += new System.EventHandler(this.radMoney_CheckedChanged);
            // 
            // lstCheck
            // 
            this.lstCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCheck.FormattingEnabled = true;
            this.lstCheck.Location = new System.Drawing.Point(883, 79);
            this.lstCheck.Name = "lstCheck";
            this.lstCheck.Size = new System.Drawing.Size(220, 403);
            this.lstCheck.TabIndex = 5;
            this.lstCheck.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 799);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCheck);
            this.Controls.Add(this.gbxPayment);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.btnFinalOrder);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmCheck";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnFinalOrder;
        public System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.RadioButton radMoney;
        public System.Windows.Forms.ListBox lstCheck;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.TextBox txtCreditNum;
        private System.Windows.Forms.RadioButton radDebit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebitCard;
        private System.Windows.Forms.TextBox txtDebitNum;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
    }
}