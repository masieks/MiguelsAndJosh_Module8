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
    public partial class frmMain : Form
    {
        const int SIZE = 10000;

        //Arrays variables
        private string[] itemsNames = new string[SIZE];
        private int[] itemsQuantity = new int[SIZE];
        private int[] itemNumber = new int[SIZE];
        private double[] itemsPrice = new double[SIZE];
        //Order Counter Variable


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmIntro frmSplashIntro = new frmIntro();
            frmSplashIntro.ShowDialog();

        }

        // Get Description from items

        // Get Pricing from items
        private void addItemsPricing(string[] names, int[] quantity, double[] price)
        {



        }
        
        //Function to ignore inputs of zero, and add items to the list order

        private void getListDisplay(string name, int quantity)
        {
            //Variables
            if (quantity <= 0)
                return;
            //If item quantity is bigger than 0 then loop and add
            else
                lstOrderDisplay.Items.Add(name + quantity);
        }

        //Order Button Clicked -> Add lstOrderDisplay to lstOrders from frmOrder.
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
                MessageBox.Show("Please enter your first name.");
            else if (txtLastName.Text == "")
                MessageBox.Show("Please enter your last name.");
            else
            {
                if (lstOrderDisplay.Items.Count < 0)
                    MessageBox.Show("Please Add Item!");
                else
                {
                    frmCheck frmShowOrder = new frmCheck();
                    for (int i = 0; i < lstOrderDisplay.Items.Count; i++)
                    frmShowOrder.lstOrder.Items.Add(lstOrderDisplay.Items[i].ToString());
                    frmShowOrder.ShowDialog();
                }
            }
        }

        //Remove Items Button
        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            if (lstOrderDisplay.SelectedIndex > -1)
            {
                lstOrderDisplay.Items.RemoveAt(lstOrderDisplay.SelectedIndex);
                lstOrderDisplay.Items.Remove(lstOrderDisplay.SelectedItems);
            }
        }
        

        //Alcohols
        private void btnRocca_Click(object sender, EventArgs e)
        {
            string name = lblRossini.Text;
            int quantity = int.Parse(nudRossini.Text);
            double price = double.Parse(lblRossiniPrice.Text);
            getListDisplay(name, quantity);
        }

        private void btnSpritz_Click(object sender, EventArgs e)
        {
            string name = lblSpritz.Text;
            int quantity = int.Parse(nudSpritz.Text);
            double price = double.Parse(lblSpritzPrice.Text);
            getListDisplay(name, quantity);
        }

        private void btnRossini_Click(object sender, EventArgs e)
        {
            string name = lblRossini.Text;
            int quantity = int.Parse(nudRossini.Text);
            double price = double.Parse(lblRossiniPrice.Text);
            getListDisplay(name, quantity);
        }

        private void btnLimoncello_Click(object sender, EventArgs e)
        {
            string name = lblLimoncello.Text;
            int quantity = int.Parse(nudLimoncello.Text);
            double price = double.Parse(lblLimoncelloPrice.Text);
            getListDisplay(name, quantity);
        }

        //Non Alcholic Drinks
        private void btnCoke_Click(object sender, EventArgs e)
        {

            string name = lblCoke.Text;
            int quantity = int.Parse(nudCoke.Text);
            double price = double.Parse(lblCokePrice.Text);

            getListDisplay(name, quantity);

        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            string name = lblSprite.Text;
            int quantity = int.Parse(nudSprite.Text);
            double price = double.Parse(lblSpritePrice.Text);
            getListDisplay(name, quantity);
        }

        private void btnSanPellegrino_Click(object sender, EventArgs e)
        {
            string name = lblSanPellegrino.Text;
            int quantity = int.Parse(nudSanPellegrino.Text);
            double price = double.Parse(lblSanPellegrinoPrice.Text);
            getListDisplay(name, quantity);
        }

        private void btnLemonade_Click(object sender, EventArgs e)
        {
            string name = lblLemonade.Text;
            int quantity = int.Parse(nudLemonade.Text);
            double price = double.Parse(lblLemonadePrice.Text);
            getListDisplay(name, quantity);
        }

        //Main Dishes
        private void btnSteak_Click(object sender, EventArgs e)
        {
            string name = lblSteak.Text;
            int quantity = int.Parse(nudSteak.Text);
            double price = double.Parse(lblSteak.Text);
            getListDisplay(name, quantity);
        }

        private void btnChickenParm_Click(object sender, EventArgs e)
        {
            string name = lblChickenParm.Text;
            int quantity = int.Parse(nudChickenParm.Text);
            double price = double.Parse(lblChickenParm.Text);
            getListDisplay(name, quantity);
        }

        private void btnGnocchi_Click(object sender, EventArgs e)
        {
            string name = lblGnocchi.Text;
            int quantity = int.Parse(nudGnocchi.Text);
            double price = double.Parse(lblGnocchi.Text);
            getListDisplay(name, quantity);
        }

        private void btnChickenAlfredo_Click(object sender, EventArgs e)
        {
            string name = lblChickenAlfredo.Text;
            int quantity = int.Parse(nudChickenAlfredo.Text);
            double price = double.Parse(lblChickenAlfredoPrice.Text);
            getListDisplay(name, quantity);
        }

        //Pastas
        private void btnPasta_Click(object sender, EventArgs e)
        {
            string name = lblPasta.Text;
            int quantity = int.Parse(nudPasta.Text);
            double price = double.Parse(lblPastaPrice.Text);
            getListDisplay(name, quantity);
        }

        private void btnLasanga_Click(object sender, EventArgs e)
        {
            string name = lblLasanga.Text;
            int quantity = int.Parse(nudLasanga.Text);
            double price = double.Parse(lblLasangaPrice.Text);
            getListDisplay(name, quantity);
        }

        private void btnMinestrone_Click(object sender, EventArgs e)
        {
            string name = lblSteak.Text;
            int quantity = int.Parse(nudSteak.Text);
            double price = double.Parse(lblSteak.Text);
            getListDisplay(name, quantity);
        }

        private void btnSpaghetti_Click(object sender, EventArgs e)
        {
            string name = lblSpaghetti.Text;
            int quantity = int.Parse(nudSpaghetti.Text);
            double price = double.Parse(lblSpaghettiPrice.Text);
            getListDisplay(name, quantity);
        }

        private void gbxMainDish_Enter(object sender, EventArgs e)
        {

        }
    }
}
