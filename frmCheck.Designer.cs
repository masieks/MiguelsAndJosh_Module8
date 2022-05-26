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
            this.txtTip = new System.Windows.Forms.TextBox();
            this.chkTip = new System.Windows.Forms.CheckBox();
            this.gbxCreditInfo = new System.Windows.Forms.GroupBox();
            this.chbxCredit = new System.Windows.Forms.CheckBox();
            this.txtCreditNum = new System.Windows.Forms.TextBox();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.cbxCreditExpDay = new System.Windows.Forms.ComboBox();
            this.cbxCreditExpMonth = new System.Windows.Forms.ComboBox();
            this.lblCreditExpMonth = new System.Windows.Forms.Label();
            this.lblCreditExp = new System.Windows.Forms.Label();
            this.lblCreditExpDate = new System.Windows.Forms.Label();
            this.chbxCash = new System.Windows.Forms.CheckBox();
            this.gbxDebitInfo = new System.Windows.Forms.GroupBox();
            this.chbxDebit = new System.Windows.Forms.CheckBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtDebitNum = new System.Windows.Forms.TextBox();
            this.lblDebitCard = new System.Windows.Forms.Label();
            this.lblDebitExpMonth = new System.Windows.Forms.Label();
            this.lblDebitExp = new System.Windows.Forms.Label();
            this.cbxDeditExpMonth = new System.Windows.Forms.ComboBox();
            this.lblDebitExpDay = new System.Windows.Forms.Label();
            this.cbxDeditExpDay = new System.Windows.Forms.ComboBox();
            this.lstCheck = new System.Windows.Forms.ListBox();
            this.lblOrderReview = new System.Windows.Forms.Label();
            this.lblFinalOrder = new System.Windows.Forms.Label();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblDisplayItem = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbxPayment.SuspendLayout();
            this.gbxCreditInfo.SuspendLayout();
            this.gbxDebitInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(78, 726);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(240, 51);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnFinalOrder
            // 
            this.btnFinalOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalOrder.Location = new System.Drawing.Point(740, 643);
            this.btnFinalOrder.Name = "btnFinalOrder";
            this.btnFinalOrder.Size = new System.Drawing.Size(216, 63);
            this.btnFinalOrder.TabIndex = 2;
            this.btnFinalOrder.Text = "Place Final Order";
            this.btnFinalOrder.UseVisualStyleBackColor = true;
            this.btnFinalOrder.Click += new System.EventHandler(this.btnFinalOrder_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 25;
            this.lstOrder.Location = new System.Drawing.Point(53, 98);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(322, 575);
            this.lstOrder.TabIndex = 3;
            // 
            // gbxPayment
            // 
            this.gbxPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxPayment.Controls.Add(this.txtTip);
            this.gbxPayment.Controls.Add(this.chkTip);
            this.gbxPayment.Controls.Add(this.gbxCreditInfo);
            this.gbxPayment.Controls.Add(this.chbxCash);
            this.gbxPayment.Controls.Add(this.gbxDebitInfo);
            this.gbxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPayment.Location = new System.Drawing.Point(420, 98);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(542, 539);
            this.gbxPayment.TabIndex = 4;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Select Payment Method";
            // 
            // txtTip
            // 
            this.txtTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTip.Location = new System.Drawing.Point(105, 480);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(111, 32);
            this.txtTip.TabIndex = 23;
            this.txtTip.Visible = false;
            // 
            // chkTip
            // 
            this.chkTip.AutoSize = true;
            this.chkTip.Location = new System.Drawing.Point(19, 480);
            this.chkTip.Name = "chkTip";
            this.chkTip.Size = new System.Drawing.Size(60, 30);
            this.chkTip.TabIndex = 21;
            this.chkTip.Text = "Tip";
            this.chkTip.UseVisualStyleBackColor = true;
            this.chkTip.CheckedChanged += new System.EventHandler(this.chkTip_CheckedChanged);
            // 
            // gbxCreditInfo
            // 
            this.gbxCreditInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxCreditInfo.Controls.Add(this.chbxCredit);
            this.gbxCreditInfo.Controls.Add(this.txtCreditNum);
            this.gbxCreditInfo.Controls.Add(this.lblCreditCard);
            this.gbxCreditInfo.Controls.Add(this.cbxCreditExpDay);
            this.gbxCreditInfo.Controls.Add(this.cbxCreditExpMonth);
            this.gbxCreditInfo.Controls.Add(this.lblCreditExpMonth);
            this.gbxCreditInfo.Controls.Add(this.lblCreditExp);
            this.gbxCreditInfo.Controls.Add(this.lblCreditExpDate);
            this.gbxCreditInfo.Location = new System.Drawing.Point(8, 92);
            this.gbxCreditInfo.Name = "gbxCreditInfo";
            this.gbxCreditInfo.Size = new System.Drawing.Size(528, 140);
            this.gbxCreditInfo.TabIndex = 19;
            this.gbxCreditInfo.TabStop = false;
            // 
            // chbxCredit
            // 
            this.chbxCredit.AutoSize = true;
            this.chbxCredit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.chbxCredit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chbxCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxCredit.Location = new System.Drawing.Point(11, 19);
            this.chbxCredit.Name = "chbxCredit";
            this.chbxCredit.Size = new System.Drawing.Size(74, 24);
            this.chbxCredit.TabIndex = 21;
            this.chbxCredit.Text = "Credit";
            this.chbxCredit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chbxCredit.UseVisualStyleBackColor = true;
            this.chbxCredit.CheckedChanged += new System.EventHandler(this.chbxCredit_CheckedChanged);
            // 
            // txtCreditNum
            // 
            this.txtCreditNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCreditNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditNum.Location = new System.Drawing.Point(97, 90);
            this.txtCreditNum.Name = "txtCreditNum";
            this.txtCreditNum.Size = new System.Drawing.Size(199, 32);
            this.txtCreditNum.TabIndex = 3;
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCard.Location = new System.Drawing.Point(93, 66);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(218, 20);
            this.lblCreditCard.TabIndex = 4;
            this.lblCreditCard.Text = "Enter your credit card number";
            // 
            // cbxCreditExpDay
            // 
            this.cbxCreditExpDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCreditExpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCreditExpDay.FormattingEnabled = true;
            this.cbxCreditExpDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxCreditExpDay.Location = new System.Drawing.Point(354, 89);
            this.cbxCreditExpDay.Name = "cbxCreditExpDay";
            this.cbxCreditExpDay.Size = new System.Drawing.Size(61, 33);
            this.cbxCreditExpDay.TabIndex = 9;
            // 
            // cbxCreditExpMonth
            // 
            this.cbxCreditExpMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCreditExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCreditExpMonth.FormattingEnabled = true;
            this.cbxCreditExpMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbxCreditExpMonth.Location = new System.Drawing.Point(440, 89);
            this.cbxCreditExpMonth.Name = "cbxCreditExpMonth";
            this.cbxCreditExpMonth.Size = new System.Drawing.Size(61, 33);
            this.cbxCreditExpMonth.TabIndex = 11;
            // 
            // lblCreditExpMonth
            // 
            this.lblCreditExpMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreditExpMonth.AutoSize = true;
            this.lblCreditExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditExpMonth.Location = new System.Drawing.Point(436, 66);
            this.lblCreditExpMonth.Name = "lblCreditExpMonth";
            this.lblCreditExpMonth.Size = new System.Drawing.Size(54, 20);
            this.lblCreditExpMonth.TabIndex = 13;
            this.lblCreditExpMonth.Text = "Month";
            // 
            // lblCreditExp
            // 
            this.lblCreditExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreditExp.AutoSize = true;
            this.lblCreditExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditExp.Location = new System.Drawing.Point(380, 28);
            this.lblCreditExp.Name = "lblCreditExp";
            this.lblCreditExp.Size = new System.Drawing.Size(75, 20);
            this.lblCreditExp.TabIndex = 12;
            this.lblCreditExp.Text = "Exp Date";
            // 
            // lblCreditExpDate
            // 
            this.lblCreditExpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreditExpDate.AutoSize = true;
            this.lblCreditExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditExpDate.Location = new System.Drawing.Point(350, 66);
            this.lblCreditExpDate.Name = "lblCreditExpDate";
            this.lblCreditExpDate.Size = new System.Drawing.Size(44, 20);
            this.lblCreditExpDate.TabIndex = 10;
            this.lblCreditExpDate.Text = "Date";
            // 
            // chbxCash
            // 
            this.chbxCash.AutoSize = true;
            this.chbxCash.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.chbxCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chbxCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxCash.Location = new System.Drawing.Point(19, 46);
            this.chbxCash.Name = "chbxCash";
            this.chbxCash.Size = new System.Drawing.Size(67, 24);
            this.chbxCash.TabIndex = 8;
            this.chbxCash.Text = "Cash";
            this.chbxCash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chbxCash.UseVisualStyleBackColor = true;
            this.chbxCash.CheckedChanged += new System.EventHandler(this.chbxCash_CheckedChanged);
            // 
            // gbxDebitInfo
            // 
            this.gbxDebitInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbxDebitInfo.AutoSize = true;
            this.gbxDebitInfo.Controls.Add(this.chbxDebit);
            this.gbxDebitInfo.Controls.Add(this.txtPin);
            this.gbxDebitInfo.Controls.Add(this.lblPin);
            this.gbxDebitInfo.Controls.Add(this.txtDebitNum);
            this.gbxDebitInfo.Controls.Add(this.lblDebitCard);
            this.gbxDebitInfo.Controls.Add(this.lblDebitExpMonth);
            this.gbxDebitInfo.Controls.Add(this.lblDebitExp);
            this.gbxDebitInfo.Controls.Add(this.cbxDeditExpMonth);
            this.gbxDebitInfo.Controls.Add(this.lblDebitExpDay);
            this.gbxDebitInfo.Controls.Add(this.cbxDeditExpDay);
            this.gbxDebitInfo.Location = new System.Drawing.Point(8, 238);
            this.gbxDebitInfo.Name = "gbxDebitInfo";
            this.gbxDebitInfo.Size = new System.Drawing.Size(528, 222);
            this.gbxDebitInfo.TabIndex = 20;
            this.gbxDebitInfo.TabStop = false;
            // 
            // chbxDebit
            // 
            this.chbxDebit.AutoSize = true;
            this.chbxDebit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.chbxDebit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chbxDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxDebit.Location = new System.Drawing.Point(6, 18);
            this.chbxDebit.Name = "chbxDebit";
            this.chbxDebit.Size = new System.Drawing.Size(69, 24);
            this.chbxDebit.TabIndex = 22;
            this.chbxDebit.Text = "Debit";
            this.chbxDebit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chbxDebit.UseVisualStyleBackColor = true;
            this.chbxDebit.CheckedChanged += new System.EventHandler(this.chbxDebit_CheckedChanged);
            // 
            // txtPin
            // 
            this.txtPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(97, 158);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(111, 32);
            this.txtPin.TabIndex = 7;
            // 
            // lblPin
            // 
            this.lblPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(93, 132);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(146, 20);
            this.lblPin.TabIndex = 8;
            this.lblPin.Text = "Enter your debit pin";
            // 
            // txtDebitNum
            // 
            this.txtDebitNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDebitNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebitNum.Location = new System.Drawing.Point(97, 91);
            this.txtDebitNum.Name = "txtDebitNum";
            this.txtDebitNum.Size = new System.Drawing.Size(199, 32);
            this.txtDebitNum.TabIndex = 5;
            // 
            // lblDebitCard
            // 
            this.lblDebitCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDebitCard.AutoSize = true;
            this.lblDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitCard.Location = new System.Drawing.Point(93, 68);
            this.lblDebitCard.Name = "lblDebitCard";
            this.lblDebitCard.Size = new System.Drawing.Size(217, 20);
            this.lblDebitCard.TabIndex = 6;
            this.lblDebitCard.Text = "Enter your Debit card number";
            // 
            // lblDebitExpMonth
            // 
            this.lblDebitExpMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDebitExpMonth.AutoSize = true;
            this.lblDebitExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitExpMonth.Location = new System.Drawing.Point(430, 134);
            this.lblDebitExpMonth.Name = "lblDebitExpMonth";
            this.lblDebitExpMonth.Size = new System.Drawing.Size(54, 20);
            this.lblDebitExpMonth.TabIndex = 18;
            this.lblDebitExpMonth.Text = "Month";
            // 
            // lblDebitExp
            // 
            this.lblDebitExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDebitExp.AutoSize = true;
            this.lblDebitExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitExp.Location = new System.Drawing.Point(345, 92);
            this.lblDebitExp.Name = "lblDebitExp";
            this.lblDebitExp.Size = new System.Drawing.Size(75, 20);
            this.lblDebitExp.TabIndex = 17;
            this.lblDebitExp.Text = "Exp Date";
            // 
            // cbxDeditExpMonth
            // 
            this.cbxDeditExpMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDeditExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeditExpMonth.FormattingEnabled = true;
            this.cbxDeditExpMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbxDeditExpMonth.Location = new System.Drawing.Point(434, 157);
            this.cbxDeditExpMonth.Name = "cbxDeditExpMonth";
            this.cbxDeditExpMonth.Size = new System.Drawing.Size(61, 33);
            this.cbxDeditExpMonth.TabIndex = 16;
            // 
            // lblDebitExpDay
            // 
            this.lblDebitExpDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDebitExpDay.AutoSize = true;
            this.lblDebitExpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitExpDay.Location = new System.Drawing.Point(344, 134);
            this.lblDebitExpDay.Name = "lblDebitExpDay";
            this.lblDebitExpDay.Size = new System.Drawing.Size(44, 20);
            this.lblDebitExpDay.TabIndex = 15;
            this.lblDebitExpDay.Text = "Date";
            // 
            // cbxDeditExpDay
            // 
            this.cbxDeditExpDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDeditExpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeditExpDay.FormattingEnabled = true;
            this.cbxDeditExpDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDeditExpDay.Location = new System.Drawing.Point(348, 157);
            this.cbxDeditExpDay.Name = "cbxDeditExpDay";
            this.cbxDeditExpDay.Size = new System.Drawing.Size(61, 33);
            this.cbxDeditExpDay.TabIndex = 14;
            // 
            // lstCheck
            // 
            this.lstCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCheck.FormattingEnabled = true;
            this.lstCheck.ItemHeight = 25;
            this.lstCheck.Location = new System.Drawing.Point(997, 98);
            this.lstCheck.Name = "lstCheck";
            this.lstCheck.Size = new System.Drawing.Size(487, 575);
            this.lstCheck.TabIndex = 5;
            this.lstCheck.Visible = false;
            // 
            // lblOrderReview
            // 
            this.lblOrderReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderReview.AutoSize = true;
            this.lblOrderReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderReview.Location = new System.Drawing.Point(136, 47);
            this.lblOrderReview.Name = "lblOrderReview";
            this.lblOrderReview.Size = new System.Drawing.Size(145, 26);
            this.lblOrderReview.TabIndex = 6;
            this.lblOrderReview.Text = "Order Review";
            // 
            // lblFinalOrder
            // 
            this.lblFinalOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFinalOrder.AutoSize = true;
            this.lblFinalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalOrder.Location = new System.Drawing.Point(1186, 59);
            this.lblFinalOrder.Name = "lblFinalOrder";
            this.lblFinalOrder.Size = new System.Drawing.Size(120, 26);
            this.lblFinalOrder.TabIndex = 7;
            this.lblFinalOrder.Text = "Final Order";
            this.lblFinalOrder.Visible = false;
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.Location = new System.Drawing.Point(141, 688);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(110, 32);
            this.btnRemoveItems.TabIndex = 8;
            this.btnRemoveItems.Text = "Remove Item";
            this.btnRemoveItems.UseVisualStyleBackColor = true;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(1088, 688);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(129, 32);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // lblDisplayItem
            // 
            this.lblDisplayItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisplayItem.AutoSize = true;
            this.lblDisplayItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayItem.Location = new System.Drawing.Point(90, 75);
            this.lblDisplayItem.Name = "lblDisplayItem";
            this.lblDisplayItem.Size = new System.Drawing.Size(41, 20);
            this.lblDisplayItem.TabIndex = 11;
            this.lblDisplayItem.Text = "Item";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(224, 75);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(322, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price";
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 799);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDisplayItem);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnRemoveItems);
            this.Controls.Add(this.lblFinalOrder);
            this.Controls.Add(this.lblOrderReview);
            this.Controls.Add(this.lstCheck);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.btnFinalOrder);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbxPayment);
            this.Name = "frmCheck";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.gbxCreditInfo.ResumeLayout(false);
            this.gbxCreditInfo.PerformLayout();
            this.gbxDebitInfo.ResumeLayout(false);
            this.gbxDebitInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnFinalOrder;
        public System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.GroupBox gbxPayment;
        public System.Windows.Forms.ListBox lstCheck;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblDebitCard;
        private System.Windows.Forms.TextBox txtDebitNum;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.GroupBox gbxCreditInfo;
        private System.Windows.Forms.TextBox txtCreditNum;
        private System.Windows.Forms.ComboBox cbxCreditExpDay;
        private System.Windows.Forms.ComboBox cbxCreditExpMonth;
        private System.Windows.Forms.Label lblCreditExpMonth;
        private System.Windows.Forms.Label lblCreditExp;
        private System.Windows.Forms.Label lblCreditExpDate;
        private System.Windows.Forms.GroupBox gbxDebitInfo;
        private System.Windows.Forms.Label lblDebitExpMonth;
        private System.Windows.Forms.Label lblDebitExp;
        private System.Windows.Forms.ComboBox cbxDeditExpMonth;
        private System.Windows.Forms.Label lblDebitExpDay;
        private System.Windows.Forms.ComboBox cbxDeditExpDay;
        private System.Windows.Forms.Label lblOrderReview;
        private System.Windows.Forms.Label lblFinalOrder;
        private System.Windows.Forms.CheckBox chbxCredit;
        private System.Windows.Forms.CheckBox chbxCash;
        private System.Windows.Forms.CheckBox chbxDebit;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.CheckBox chkTip;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblDisplayItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
    }
}