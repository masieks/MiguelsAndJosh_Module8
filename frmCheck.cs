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
        //Variables
        const int SIZE = 10000;
        int count = 0;
        string filePath = "Order.txt";
        private string[] itemsNames = new string[SIZE];
        private int[] itemsQuantity = new int[SIZE];
        private double[] itemsPrice = new double[SIZE];


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
                        //Grab text
                        cardNumber = txtCreditNum.Text;
                        expDate = cbxCreditExpDay.Text;
                        expMonth = cbxCreditExpMonth.Text;

                        //Make sure its not empty
                        if (cardNumber == "")
                        {
                            MessageBox.Show("Please enter a card number.");
                            declinedPayment = true;
                        }
                        //See if the Numbers inputed by user is actually a full credit card number
                        else if (cardNumber.Length > CREDITLIMIT || cardNumber.Length < CREDITLIMIT)
                        {
                            MessageBox.Show("Please enter credit card number with 16 digits.");
                            declinedPayment = true;
                        }
                        //Make sure the string is both a full cardnumber and a string of numbers.
                        else if (!double.TryParse(cardNumber, out numbersOnlyCheck))
                        {
                            MessageBox.Show("Please enter credit card number with 16 digits.");
                            declinedPayment = true;
                        }
                        //Check Expiration Dates
                        else if (expDate == "" || expMonth == "")
                        {
                            MessageBox.Show("Please enter both expiration day and month.");
                            declinedPayment = true;
                        }
                        //If all criteria is passed send false;
                        else
                            declinedPayment = false;
                    }

                    if (!declinedPayment)
                    {
                        if (lstCheck.Visible == true)
                        {
                            MessageBox.Show("You already placed your order.");
                        }
                        else
                        {
                            MessageBox.Show("Payment was accepted.");

                            getFinalOrder();

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
                        {
                            MessageBox.Show("Please enter both card number & pin.");
                            declinedPayment = true;
                        }
                        //See if the Numbers inputed by user is actually a full credit card number
                        else if (cardNumber.Length > DEBITLIMIT || cardNumber.Length < DEBITLIMIT || pinNumbers.Length > PIN || pinNumbers.Length < PIN)
                        {
                            MessageBox.Show("Please enter credit card number with 16 digits and 4 digit pin.");
                            declinedPayment = true;
                        }
                        //Make sure the string is both a full cardnumber and a string of numbers.
                        else if (!double.TryParse(cardNumber, out numbersOnlyCheck) || !double.TryParse(pinNumbers, out pinNumbersOnlyCheck))
                        {
                            MessageBox.Show("Card Numbers & Pin must be numbers.");
                            declinedPayment = true;
                        }
                        //Check exp date and month are selected;
                        else if (expDate == "" || expMonth == "")
                        {
                            MessageBox.Show("Please enter expiration day and month.");
                            declinedPayment = true;
                        }
                        //If all criteria is passed send false;
                        else
                        {
                            declinedPayment = false;
                        }

                    }

                    if (!declinedPayment)
                    {
                        if (lstCheck.Visible == true)
                        {
                            MessageBox.Show("You already placed your order.");
                        }
                        else
                        {
                            MessageBox.Show("Payment was accepted.");

                            getFinalOrder();
                        }
                    }
                }
                else if (chbxCash.Checked)
                {
                    if (lstCheck.Visible == true)
                    {
                        MessageBox.Show("You already placed your order.");
                    }
                    else
                    {
                        MessageBox.Show("Payment was accepted.");

                        getFinalOrder();
                    }
                }

            }
            else MessageBox.Show("Payment was already accepted");
            

        }

        private void chbxCash_CheckedChanged(object sender, EventArgs e)
        {
            //If checked uncheck others
            if (chbxCash.Checked)
            {
                chbxCredit.Checked = false;
                chbxDebit.Checked = false;
            }
        }

        private void chbxCredit_CheckedChanged(object sender, EventArgs e)
        {
            //If checked uncheck others
            if (chbxCredit.Checked)
            {
                chbxCash.Checked = false;
                chbxDebit.Checked = false;
            }
        }

        private void chbxDebit_CheckedChanged(object sender, EventArgs e)
        {
            //If checked uncheck others
            if (chbxDebit.Checked)
            {
                chbxCash.Checked = false;
                chbxCredit.Checked = false;
            }
        }

 // Set this text reader/writer to its own function.
        public void getFinalOrder()
        {
            StreamReader inFile;
            double itemPrice;
            double total = 0;
            lstCheck.Visible = true;
          
            DateTime dt = DateTime.Now;
            DateTime ts = dt.Add(DateTime.Now.TimeOfDay);
            lstCheck.Items.Add(ts.ToString());
         
            

            inFile = new StreamReader(filePath); // READS

            while (!inFile.EndOfStream)
            {
               
                itemsPrice[count] = double.Parse(inFile.ReadLine()); // Converts Price
                itemsQuantity[count] = int.Parse(inFile.ReadLine());
                itemPrice = itemsPrice[count] * itemsQuantity[count];
                total += itemPrice;
                itemsNames[count] = inFile.ReadLine();
                // Displays for Print
               
                lstCheck.Items.Add(itemsNames[count]+"X" +itemsQuantity[count]+itemPrice.ToString("c"));
                


                count++;
                
            }
            lstCheck.Items.Add(total.ToString("c"));

            inFile.Close();

           
        }

        private void chkTip_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTip.Checked)
            {
                txtTip.Visible = true;
            }
            else
            {
                txtTip.Visible = false;
            }
        }
    }
}
