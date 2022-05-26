using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiguelsAndJosh_Module8
{
    public partial class frmCheck : Form
    {
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
            const int CARDNUMBER = 25;
            const int PIN = 4;
            string payment = " Your payment has been decided.";

            //CreditCard
            if (radCredit.Checked)
            {
                if (txtCreditNum.Text == " ")
                    MessageBox.Show("Please enter your credit card number.");

                int info = int.Parse(txtCreditNum.Text);

                if (info < CARDNUMBER || info > CARDNUMBER)
                    MessageBox.Show("You entered an invalid credit card number. Hint a Card number has 25 digits.");
                else if (!int.TryParse(txtCreditNum.Text, out info))
                    MessageBox.Show("Please enter digits");

                else
                    MessageBox.Show(payment);
                lstCheck.Items.Clear();
                lstCheck.Visible = true;
                DateTime dt = DateTime.Now;
                DateTime ts = dt.Add(DateTime.Now.TimeOfDay);
                lstCheck.Items.Add(ts.ToString());

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
    }
}
