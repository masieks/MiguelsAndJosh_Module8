using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiguelsAndJosh_Module8
{

    public partial class frmCheck : Form
    {
        StreamWriter outFile;
        string filePath1 = "Reciept.txt";
        //Variables
        const int SIZE = 10000;
        int count = 0;
        string filePath = "Order.txt";
        private string[] itemsNames = new string[SIZE];
        private int[] itemsQuantity = new int[SIZE];
        private double[] itemsPrice = new double[SIZE];
        bool credit = false;
        bool debit = false;
        bool cash = false;
        public frmCheck()
        {
            InitializeComponent();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void btnFinalOrder_Click(object sender, EventArgs e)
        {
            //Variables
            //Set to true so that we know when a costumer has paid.
            bool declinedPayment = true;
            //To add more to the order.
            bool orderChanged = false;
            //Set to false until the customer has paid. This is to ensure there are no double charges.
            bool stopDoubleOrder = false;
            //CreditCard Variables
            const int CREDITLIMIT = 16;
            double numbersOnlyCheck = 0;
            double pinNumbersOnlyCheck = 0;
            string cardNumber;
            string expDate;
            string expMonth;
            //DebitCard specific Variables
            const int DEBITLIMIT = 16;
            const int PIN = 4;
            string pinNumbers;


            if (stopDoubleOrder == false)
            {
                if (chbxCredit.Checked)
                {
                    if (declinedPayment)
                    {
                        //See if all criteria is meet
                        cardNumber = txtCreditNum.Text;
                        expDate = cbxCreditExpDay.Text;
                        expMonth = cbxCreditExpMonth.Text;
                        //Error Check CREDIT CARD
                        if (cardNumber == "")
                            MessageBox.Show("Please enter a card number.");
                        else if (cardNumber.Length != CREDITLIMIT)
                            MessageBox.Show("Please enter credit card number with 16 digits.");
                        else if (!double.TryParse(cardNumber, out numbersOnlyCheck))
                            MessageBox.Show("Please enter credit card number with 16 digits.");
                        else if (expDate == "" || expMonth == "")
                            MessageBox.Show("Please enter both expiration day and month.");
                        else
                            declinedPayment = false;
                    }
                    if (!declinedPayment)
                    {
                        if (lstCheck.Visible == true)
                            MessageBox.Show("You already placed your order.");
                        else
                        {
                            bool credit = true;
                            bool cash = false;
                            bool debit = false;
                            MessageBox.Show("Payment was accepted.");
                            btnRemoveItems.Enabled = false;
                            btnReturn.Enabled = false;
                            btnFinalOrder.Enabled = false;
                            btnSaveChanges.Visible = true;
                            btnRestart.Visible = true;
                            getFinalOrder(credit, debit, cash);
                        }
                    }
                }

                else if (chbxDebit.Checked)
                {
                    if (declinedPayment)
                    {
                        cardNumber = txtDebitNum.Text;
                        pinNumbers = txtPin.Text;
                        expDate = cbxDeditExpDay.Text;
                        expMonth = cbxDeditExpMonth.Text;
                        //Make sure its not empty
                        if (cardNumber == "" || pinNumbers == "")
                            MessageBox.Show("Please enter both card number & pin.");
                        else if (cardNumber.Length != DEBITLIMIT)
                            MessageBox.Show("Please enter Debit Card number with 16 digits");
                        else if (pinNumbers.Length != PIN)
                            MessageBox.Show("Please enter Pin with 4 digits");
                        else if (!double.TryParse(cardNumber, out numbersOnlyCheck) || !double.TryParse(pinNumbers, out pinNumbersOnlyCheck))
                            MessageBox.Show("Card Numbers & Pin must be numbers.");
                        else if (expDate == "" || expMonth == "")
                            MessageBox.Show("Please enter expiration Month and Year.");
                        else
                            declinedPayment = false;
                    }
                    if (!declinedPayment)
                    {
                        bool credit = false;
                        bool cash = false;
                        bool debit = true;
                        if (lstCheck.Visible == true)
                            MessageBox.Show("You already placed your order.");
                        else
                        {

                            MessageBox.Show("Payment was accepted.");
                            btnRemoveItems.Enabled = false;
                            btnReturn.Enabled = false;
                            btnFinalOrder.Enabled = false;
                            btnSaveChanges.Visible = true;
                            btnRestart.Visible = true;
                            getFinalOrder(credit, debit, cash);
                        }
                    }
                }
                else if (chbxCash.Checked)
                {
                    bool credit = false;
                    bool cash = true;
                    bool debit = false;
                    if (lstCheck.Visible == true)
                        MessageBox.Show("You already placed your order.");
                    else
                    {
                        MessageBox.Show("Payment was accepted.");
                        btnRemoveItems.Enabled = false;
                        btnReturn.Enabled = false;
                        btnFinalOrder.Enabled = false;
                        btnSaveChanges.Visible = true;
                        btnRestart.Visible = true;
                        getFinalOrder(credit, debit, cash);
                    }
                }

            }
            else MessageBox.Show("Payment was already accepted");
        }

        private void chbxCash_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCash.Checked) //If checked uncheck others
            {
                chbxCredit.Checked = false;
                chbxDebit.Checked = false;
            }
        }
        private void chbxCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCredit.Checked) //If checked uncheck others
            {
                chbxCash.Checked = false;
                chbxDebit.Checked = false;
            }
        }
        private void chbxDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDebit.Checked) //If checked uncheck others
            {
                chbxCash.Checked = false;
                chbxCredit.Checked = false;
            }
        }
        public void getFinalOrder(bool credit, bool debit, bool cash)// Set this text reader/writer to its own function.
        {
            StreamReader inFile;
            double itemPrice;
            double total = 0;
            double taxTotal = 0;
            double tip = 0;
            double grandTotal = 0;
            int receipt = 0;
            const double TAXFORTOTAL = 9.5;
            string dash = "------------------------------";
            lstCheck.Visible = true;
            receipt++;

            lstCheck.Items.Add("Receipt#:" + receipt);
            DateTime dt = DateTime.Now;
            string ts = (DateTime.Now.ToString("h:mm:ss tt"));
            lstCheck.Items.Add(dt);

            inFile = new StreamReader(filePath); // READS

            while (!inFile.EndOfStream)
            {
                itemsPrice[count] = double.Parse(inFile.ReadLine()); // Converts Price
                itemsQuantity[count] = int.Parse(inFile.ReadLine());
                itemPrice = itemsPrice[count] * itemsQuantity[count];
                total += itemPrice;

                itemsNames[count] = inFile.ReadLine();
                // Displays for Print
                lstCheck.Items.Add(itemsNames[count] + "      X" + itemsQuantity[count] + "      " + itemPrice.ToString("c"));
                count++;
            }
            lstCheck.Items.Add("Total: \t" + total.ToString("c"));
            taxTotal += total / TAXFORTOTAL;
            lstCheck.Items.Add("Tax:\t" + taxTotal.ToString("c"));
            lstCheck.Items.Add("Tip: \t" + tip.ToString("c"));
            grandTotal += taxTotal + total + tip;
            lstCheck.Items.Add("Grand Total:\t" + grandTotal.ToString("c"));

            if (credit)
            {
                lstCheck.Items.Add("Payment Method:\tCredit Card");
            }
            else if (debit)
            {
                lstCheck.Items.Add("Payment Method:\tDebit Card");
            }
            else if (cash)
            {
                lstCheck.Items.Add("Payment Method:\tCash");
            }
            inFile.Close();
        }

   

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex > -1)
            {
                lstOrder.Items.RemoveAt(lstOrder.SelectedIndex);
                lstOrder.Items.Remove(lstOrder.SelectedItems);
            }
        }
  

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            outFile = File.AppendText(filePath1);
            for (int i = 0; i < lstCheck.Items.Count; i++)

            {
                outFile.WriteLine(lstCheck.Items[i].ToString());

            }
            outFile.Close();
            MessageBox.Show("Your reciept has been saved");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
