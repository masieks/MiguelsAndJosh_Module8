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
    public partial class frmMain : Form
    {
        StreamWriter outFile;
        string filePath = "Order.txt";
        const int SIZE = 10000;

        int count = 0;
        private string[] itemsNames = new string[SIZE];
        private int[] itemsQuantity = new int[SIZE];
        private double[] itemsPrice = new double[SIZE];
      
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmIntro frmSplashIntro = new frmIntro();
            frmSplashIntro.ShowDialog();
        }
        //Order Button Clicked -> Add lstOrderDisplay to lstOrders from frmOrder.
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtFirstName.Text + " " + txtLastName.Text;
            if (txtFirstName.Text == "")
                MessageBox.Show("Please enter your first name in the main menu.");
            else if (txtLastName.Text == "")       
                MessageBox.Show("Please enter your last name in the main menu.");
            else if (lstOrderDisplay.Items.Count == 0)
                MessageBox.Show("Please Add Item to your order!");            
            else
            {
                frmCheck frmShowOrder = new frmCheck();
                frmShowOrder.lstCheck.Items.Add(name);
                for (int i = 0; i < lstOrderDisplay.Items.Count; i++)
                    frmShowOrder.lstOrder.Items.Add(lstOrderDisplay.Items[i].ToString());
                if (lstOrderDisplay.Items.Count == 0) // ERROR CHECHS ITEMS              
                    MessageBox.Show("No items, Please Add Items!!");               
                else
                {
                    outFile = File.CreateText(filePath); // OPENS FILE
                    for (int i = 0; i < lstOrderDisplay.Items.Count; i++) // FILLS ARRAY WITH TOTAL LIST ITEMS               
                    {
                        outFile.WriteLine(itemsPrice[i]); // PRICE ONLY
                        outFile.WriteLine(itemsQuantity[i]);
                        outFile.WriteLine(itemsNames[i]);
                    }
                    outFile.Close();// CLOSES FILE
                }
                frmShowOrder.ShowDialog();
            }           
        }


        // - BUTTONS -
        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            int x = -1;
            if (lstOrderDisplay.SelectedIndex > x)
            {
                lstOrderDisplay.Items.RemoveAt(lstOrderDisplay.SelectedIndex);
            }
        }
        public void addItem(double price, int quantity, string itemName)
        {
            lstOrderDisplay.Items.Add(itemName + "\t" + quantity + "\t " + price);
            itemsNames[count] = itemName;
            itemsQuantity[count] = quantity;
            itemsPrice[count] = price;
            count++;
        }
       
        //Alcohols
        private void btnRocca_Click(object sender, EventArgs e)
        {
            double roccaPrice = 18.99;
            if (cbxRocca.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else       
                addItem(roccaPrice, int.Parse(cbxRocca.Text), lblRocca.Text);          
        }
        private void btnSpritz_Click(object sender, EventArgs e)
        {
            double spritzPrice = 9.99;
            if (cbxSpritz.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(spritzPrice, int.Parse(cbxSpritz.Text), lblSpritz.Text);
        }
        private void btnRossini_Click(object sender, EventArgs e)
        {
            double rossiniPrice = 11.99;
            if (cbxRocca.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(rossiniPrice, int.Parse(cbxRossini.Text), lblRossini.Text);
        }
        private void btnLimoncello_Click(object sender, EventArgs e)
        {
            double limoncelloPrice = 7.99;
            if (cbxLimoncello.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(limoncelloPrice, int.Parse(cbxLimoncello.Text), lblLimoncello.Text);
        }
        
        //Non Alcholic Drinks
        private void btnCoke_Click(object sender, EventArgs e)
        {
            double cokePrice = 2.99;
            if (cbxCoke.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(cokePrice, int.Parse(cbxCoke.Text), lblCoke.Text);
        }
        private void btnSanPellegrino_Click(object sender, EventArgs e)

        {
            double sanPellegrinoPrice = 1.75;
            if (cbxSanPellegrino.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(sanPellegrinoPrice, int.Parse(cbxSanPellegrino.Text), lblSanPellegrino.Text);
        }
        private void btnLemonade_Click(object sender, EventArgs e)
        {
            double lemonadePrice = 1.50;
            if (cbxLemonade.Text == "")
                MessageBox.Show("Please choose a Quantity");
            addItem(lemonadePrice, int.Parse(cbxLemonade.Text), lblLemonade.Text);
        }
       
        //Main Dishes
        private void btnSteak_Click(object sender, EventArgs e)
        {
            double steakPrice = 19.99;
            if (cbxSteak.Text == "")
                MessageBox.Show("Please choose a Quantity");
            addItem(steakPrice, int.Parse(cbxSteak.Text), lblSteak.Text);
        }
        private void btnChickenParm_Click(object sender, EventArgs e)
        {
            double chickenPramPrice = 15.99;
            if (cbxSteak.Text == " ")
                MessageBox.Show("Please choose a Quantity");
            addItem(chickenPramPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnGnocchi_Click(object sender, EventArgs e)
        {
            double gnocchiPrice = 11.99;
            if (cbxGnocchi.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(gnocchiPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnChickenAlfredo_Click(object sender, EventArgs e)
        {
            double chickenAlfredoPrice = 13.99;
            if (cbxChickenAlfredo.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(chickenAlfredoPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        
        //Pastas
        private void btnPasta_Click(object sender, EventArgs e)
        {
            double pastaPrice = 9.99;
            if (cbxPasta.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(pastaPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnLasanga_Click(object sender, EventArgs e)
        {
            double lasangaPrice = 12.99;
            if (cbxLasanga.Text == "")
                MessageBox.Show("Please choose a Quantity");
            addItem(lasangaPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnMinestrone_Click(object sender, EventArgs e)
        {
            double minestronePrice = 14.99;
            if (cbxMinestrone.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(minestronePrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnSpaghetti_Click(object sender, EventArgs e)
        {
            double spaghettiPrice = 14.99;
            if (cbxSpaghetti.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(spaghettiPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnGreekSalad_Click(object sender, EventArgs e)
        {
            double greekSaladPrice = 9.99;
            if (cbxCeasarSalad.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(greekSaladPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnCeasar_Click(object sender, EventArgs e)
        {
            double ceasarSaladPrice = 9.99;
            if (cbxCeasarSalad.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(ceasarSaladPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnItalianSalad_Click(object sender, EventArgs e)
        {
            double italianSaladPrice = 9.99;
            if (cbxItalianSalad.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(italianSaladPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnCannoli_Click(object sender, EventArgs e)
        {
            double cannoliPrice = 5.99;
            if (cbxCannoli.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(cannoliPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnGellato_Click(object sender, EventArgs e)
        {
            double gellatoPrice = 4.99;
            if (cbxGellato.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(gellatoPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnPannaCotta_Click(object sender, EventArgs e)
        {
            double pannaCottaPrice = 8.99;
            if (cbxPannaCotta.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(pannaCottaPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void btnTiramisu_Click(object sender, EventArgs e)
        {
            double tiramisuPrice = 7.99;
            if (cbxTiramisu.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
                addItem(tiramisuPrice, int.Parse(cbxSpritz.Text), lblRossini.Text);
        }
        private void tabMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstOrderDisplay.Items.Clear();
        }
    }
}
