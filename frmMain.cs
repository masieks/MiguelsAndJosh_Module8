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
        const int SIZE = 10000;
        int count = 0;
        string filePath = "Order.txt";
        //Arrays variables
        private string[] itemsNames = new string[SIZE];
        private int[] itemsQuantity = new int[SIZE];
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
                    if (lstOrderDisplay.Items.Count == 0) // ERROR CHECHS ITEMS
                        MessageBox.Show("No items, Please Add Items!!");
                    else
                    {
                        outFile = File.CreateText(filePath); // OPENS FILE
                        for (int i = 0; i < lstOrderDisplay.Items.Count; i++) // FILLS ARRAY WITH TOTAL LIST ITEMS               
                        {
                            outFile.WriteLine(itemsPrice[i]); // PRICE ONLY
                            outFile.WriteLine(itemsQuantity[i]);
                        }
                        outFile.Close();// CLOSES FILE
                    }
                    

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
            double roccaPrice = 18.99;
            if (cbxRocca.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblRocca.Text + " \t\t" + cbxRocca.Text + " \t\t " + roccaPrice.ToString("c"));
                itemsNames[count] = lblRocca.Text;
                itemsQuantity[count] = int.Parse(cbxRocca.Text);
                itemsPrice[count] = roccaPrice;
                count++;
            }
        }

        private void btnSpritz_Click(object sender, EventArgs e)
        {
            double spritzPrice = 9.99;
            if (cbxRocca.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblSpritz.Text + " \t\t" + cbxSpritz.Text + " \t\t " + spritzPrice.ToString("c"));
                itemsNames[count] = lblSpritz.Text;
                itemsQuantity[count] = int.Parse(cbxSpritz.Text);
                itemsPrice[count] = spritzPrice;
                count++;
            }
        }

        private void btnRossini_Click(object sender, EventArgs e)
        {
            double rossiniPrice = 11.99;
            if (cbxRocca.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblRossini.Text + " \t\t" + cbxRossini.Text + " \t\t " + rossiniPrice.ToString("c"));
                itemsNames[count] = lblRossini.Text;
                itemsQuantity[count] = int.Parse(cbxRossini.Text);
                itemsPrice[count] = rossiniPrice;
                count++;
            }
        }

        private void btnLimoncello_Click(object sender, EventArgs e)
        {
            double limoncelloPrice = 7.99;
            if (cbxRocca.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblLimoncello.Text + " \t\t" + cbxLimoncello.Text + " \t\t " + limoncelloPrice);
                itemsNames[count] = lblLimoncello.Text;
                itemsQuantity[count] = int.Parse(cbxLimoncello.Text);
                itemsPrice[count] = limoncelloPrice;
                count++;
            }
        }

        //Non Alcholic Drinks
        private void btnCoke_Click(object sender, EventArgs e)
        {
            double cokePrice = 2.99;
            if (cbxCoke.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblCoke.Text + "     \t" + cbxCoke.Text + "     \t " + lblCokePrice.Text);
                itemsNames[count] = lblCoke.Text;
                itemsQuantity[count] =int.Parse( cbxCoke.Text);
                itemsPrice[count] = cokePrice;
                count++;
            }
        }


        private void btnSanPellegrino_Click(object sender, EventArgs e)

        {
            double sanPellegrinoPrice = 1.75;
            if (cbxSanPellegrino.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblSanPellegrino.Text + " \t\t" + cbxSanPellegrino.Text + " \t\t " + sanPellegrinoPrice);
                itemsNames[count] = lblSanPellegrino.Text;
                itemsQuantity[count] = int.Parse(cbxSanPellegrino.Text);
                itemsPrice[count] = sanPellegrinoPrice;
                count++;
            }
        }

        private void btnLemonade_Click(object sender, EventArgs e)
        {
            double lemonadePrice = 1.50;
            if (cbxLemonade.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblLemonade.Text + " \t\t" + cbxLemonade.Text + " \t\t " + lblLemonade.Text);
                itemsNames[count] = lblLemonade.Text;
                itemsQuantity[count] = int.Parse(cbxLemonade.Text);
                itemsPrice[count] = lemonadePrice;
                count++;
            }
        }

        //Main Dishes
        private void btnSteak_Click(object sender, EventArgs e)
        {
            double steakPrice = 19.99;
            if (cbxSteak.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblSteak.Text + " \t\t" + cbxSteak.Text + " \t\t " + steakPrice);
                itemsNames[count] = lblSteak.Text;
                itemsQuantity[count] = int.Parse(cbxSteak.Text);
                itemsPrice[count] = steakPrice;
                count++;
            }
        }

        private void btnChickenParm_Click(object sender, EventArgs e)
        {
            double chickenPramPrice = 15.99;
            if (cbxSteak.Text == " ")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblChickenParm.Text + " \t\t" + cbxChickenParm.Text + " \t\t " + chickenPramPrice);
                itemsNames[count] = lblChickenParm.Text;
                itemsQuantity[count] = int.Parse(cbxChickenParm.Text);
                itemsPrice[count] = chickenPramPrice;
                count++;
            }
        }

        private void btnGnocchi_Click(object sender, EventArgs e)
        {
            double gnocchiPrice = 11.99;
            if (cbxGnocchi.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblGnocchi.Text + " \t\t" + cbxGnocchi.Text + " \t\t " + gnocchiPrice);
                itemsNames[count] = lblGnocchi.Text;
                itemsQuantity[count] = int.Parse(cbxGnocchi.Text);
                itemsPrice[count] = gnocchiPrice;
                count++;
            }
        }

        private void btnChickenAlfredo_Click(object sender, EventArgs e)
        {
            double chickenAlfredoPrice = 13.99;
            if (cbxChickenAlfredo.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblChickenAlfredo.Text + " \t\t" + cbxChickenAlfredo.Text + " \t\t " + chickenAlfredoPrice);
                itemsNames[count] = lblChickenAlfredo.Text;
                itemsQuantity[count] = int.Parse(cbxChickenAlfredo.Text);
                itemsPrice[count] = chickenAlfredoPrice;
                count++;
            }
        }

        //Pastas
        private void btnPasta_Click(object sender, EventArgs e)
        {
            double pastaPrice = 13.99;
            if (cbxPasta.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblPasta.Text + " \t\t" + cbxPasta.Text + " \t\t " + pastaPrice);
                itemsNames[count] = lblPasta.Text;
                itemsQuantity[count] = int.Parse(cbxPasta.Text);
                itemsPrice[count] = pastaPrice;
                count++;
            }
        }

        private void btnLasanga_Click(object sender, EventArgs e)
        {
            double lasangaPrice = 15.99;
            if (cbxLasanga.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblLasanga.Text + " \t\t" + cbxLasanga.Text + " \t\t " + lasangaPrice);
                itemsNames[count] = lblLasanga.Text;
                itemsQuantity[count] = int.Parse(cbxLasanga.Text);
                itemsPrice[count] = lasangaPrice;
                count++;
            }
        }

        private void btnMinestrone_Click(object sender, EventArgs e)
        {
            double minestronePrice = 14.99;
            if (cbxMinestrone.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblMinestrone.Text + " \t\t" + cbxMinestrone.Text + " \t\t " + minestronePrice);
                itemsNames[count] = lblMinestrone.Text;
                itemsQuantity[count] = int.Parse(cbxMinestrone.Text);
                itemsPrice[count] = minestronePrice;
                count++;
            }
        }

        private void btnSpaghetti_Click(object sender, EventArgs e)
        {
            double spaghettiPrice = 14.99;
            if (cbxSpaghetti.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblSpaghetti.Text + " \t\t" + cbxSpaghetti.Text + " \t\t " + spaghettiPrice);
                itemsNames[count] = lblSpaghetti.Text;
                itemsQuantity[count] = int.Parse(cbxSpaghetti.Text);
                itemsPrice[count] = spaghettiPrice;
                count++;
            }

        }

        private void btnGreekSalad_Click(object sender, EventArgs e)
        {
            double greekSaladPrice = 9.99;
            if (cbxCeasarSalad.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblGreekSalad.Text + " \t\t" + cbxGreekSalad.Text + " \t\t " + greekSaladPrice);
                itemsNames[count] = lblGreekSalad.Text;
                itemsQuantity[count] = int.Parse(cbxGreekSalad.Text);
                itemsPrice[count] = greekSaladPrice;
                count++;

            }
        }

        private void btnCeasar_Click(object sender, EventArgs e)
        {
            double ceasarSaladPrice = 9.99;
            if (cbxCeasarSalad.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblCeasarSalad.Text + " \t\t" + cbxCeasarSalad.Text + " \t\t " + ceasarSaladPrice);
                itemsNames[count] = lblCeasarSalad.Text;
                itemsQuantity[count] = int.Parse(cbxCeasarSalad.Text);
                itemsPrice[count] = ceasarSaladPrice;
                count++;

            }
        }

        private void btnItalianSalad_Click(object sender, EventArgs e)
        {
            double italianSaladPrice = 9.99;
            if (cbxItalianSalad.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblItalianSalad.Text + " \t\t" + cbxItalianSalad.Text + " \t\t " + italianSaladPrice);
                itemsNames[count] = lblItalianSalad.Text;
                itemsQuantity[count] = int.Parse(cbxItalianSalad.Text);
                itemsPrice[count] = italianSaladPrice;
                count++;

            }
        }

        private void btnCannoli_Click(object sender, EventArgs e)
        {
            double cannoliPrice = 5.99;
            if (cbxCannoli.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblCannoli.Text + " \t\t" + cbxCannoli.Text + " \t\t " + cannoliPrice);
                itemsNames[count] = lblCannoli.Text;
                itemsQuantity[count] = int.Parse(cbxCannoli.Text);
                itemsPrice[count] = cannoliPrice;
                count++;

            }
        }

        private void btnGellato_Click(object sender, EventArgs e)
        {
            double gellatoPrice = 4.99;
            if (cbxGellato.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblGellato.Text + " \t\t" + cbxGellato.Text + " \t\t " + gellatoPrice);
                itemsNames[count] = lblGellato.Text;
                itemsQuantity[count] = int.Parse(cbxGellato.Text);
                itemsPrice[count] = gellatoPrice;
                count++;

            }
        }

        private void btnPannaCotta_Click(object sender, EventArgs e)
        {
            double pannaCottaPrice = 9.99;
            if (cbxPannaCotta.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblPannaCotta.Text + " \t\t" + cbxPannaCotta.Text + " \t\t " + pannaCottaPrice);
                itemsNames[count] = lblPannaCotta.Text;
                itemsQuantity[count] = int.Parse(cbxPannaCotta.Text);
                itemsPrice[count] = pannaCottaPrice;
                count++;

            }
        }

        private void btnTiramisu_Click(object sender, EventArgs e)
        {
            double tiramisuPrice = 9.99;
            if (cbxTiramisu.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblTiramisu.Text + " \t\t" + cbxTiramisu.Text + " \t\t " + tiramisuPrice);
                itemsNames[count] = lblTiramisu.Text;
                itemsQuantity[count] = int.Parse(cbxTiramisu.Text);
                itemsPrice[count] = tiramisuPrice;
                count++;

            }
        }
    }
}
