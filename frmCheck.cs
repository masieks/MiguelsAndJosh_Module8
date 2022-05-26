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
        StreamReader inFile;
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



        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void btnFinalOrder_Click(object sender, EventArgs e)
        {
            const int CARDNUMBER = 16;
            string paymentDecline = " Your payment has been decided.";
            string creditCard;
            bool accepted = false;

            

            //CreditCard
            if (radCredit.Checked)
            {
                if (!accepted)
                {
                   
                    creditCard = txtCreditNum.Text;

                    if (creditCard == null)
                    {
                        MessageBox.Show(paymentDecline);
                        accepted = false;
                        Focus(TextBox txtCreditNum);
                    }
                    else if (creditCard.Length > CARDNUMBER)
                    {
                        MessageBox.Show(paymentDecline);
                        accepted = false;
                    }
                    else if (creditCard.Length < CARDNUMBER)
                    {
                        MessageBox.Show(paymentDecline);
                        accepted = false;
                    }
                    else
                    {
                        accepted = true;

                        lstCheck.Items.Clear();

                        inFile = new StreamReader(filePath); // READS

                        while (!inFile.EndOfStream)
                        {
                            itemsPrice[count] = double.Parse(inFile.ReadLine()); // Converts Price
                            itemsQuantity[count] = int.Parse(inFile.ReadLine());
                            // Displays for Print
                            lstCheck.Items.Add(itemsPrice[count] * itemsQuantity[count]);


                            count++;
                        }
                        inFile.Close();

                        lstCheck.Visible = true;
                        DateTime dt = DateTime.Now;
                        DateTime ts = dt.Add(DateTime.Now.TimeOfDay);
                        lstCheck.Items.Add(ts.ToString());

                    }

                }
            }
        }

        private void btnDebit_CheckedChanged(object sender, EventArgs e)
        {
            
                lblDebitCard.Visible = true;
                txtDebitNum.Visible = true;
                lblPin.Visible = true;
                txtPin.Visible = true;
                txtCreditNum.Visible = false;
                lblCreditCard.Visible = false;
         
           
               
            
        }

        private void radCredit_CheckedChanged(object sender, EventArgs e)
        {
         
                txtCreditNum.Visible = true;
                lblCreditCard.Visible = true;
            lblDebitCard.Visible = false;
            lblPin.Visible=false;
            txtPin.Visible=false;   
            txtDebitNum.Visible=false;
        }

        private void radMoney_CheckedChanged(object sender, EventArgs e)
        {
            lblDebitCard.Visible = false;
            lblPin.Visible = false;
            txtPin.Visible = false;
            txtDebitNum.Visible = false;
            txtCreditNum.Visible = false;
            lblCreditCard.Visible = false;
        }

        private void txtCreditNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
