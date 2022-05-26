﻿using System;
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
            string name = lblRossini.Text;
            int quantity = int.Parse(cbxRossini.Text);
            double price = double.Parse(lblRossiniPrice.Text);
        }

        private void btnSpritz_Click(object sender, EventArgs e)
        {
            string name = lblSpritz.Text;
            int quantity = int.Parse(cbxSpritz.Text);
            double price = double.Parse(lblSpritzPrice.Text);
        }

        private void btnRossini_Click(object sender, EventArgs e)
        {
            string name = lblRossini.Text;
            int quantity = int.Parse(cbxRossini.Text);
            double price = double.Parse(lblRossiniPrice.Text);
        }

        private void btnLimoncello_Click(object sender, EventArgs e)
        {
            string name = lblLimoncello.Text;
            int quantity = int.Parse(cbxLimoncello.Text);
            double price = double.Parse(lblLimoncelloPrice.Text);
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
            double sanPellegrinoPrice = 
            if (cbxSanPellegrino.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblSanPellegrino.Text + " \t\t" + cbxSanPellegrino.Text + " \t\t " + lblCokePrice.Text);
                itemsNames[count] = lblSanPellegrino.Text;
                itemsQuantity[count] = int.Parse(cbxSanPellegrino.Text);
                itemsPrice[count] = double.Parse(lblSanPellegrinoPrice.Text);
                count++;
            }
        }

        private void btnLemonade_Click(object sender, EventArgs e)
        {


            if (cbxLemonade.Text == "")
                MessageBox.Show("Please choose a Quantity");
            else
            {
                lstOrderDisplay.Items.Add(lblLemonade.Text + " \t\t" + cbxLemonade.Text + " \t\t " + lblLemonade.Text);
                itemsNames[count] = lblLemonade.Text;
                itemsQuantity[count] = int.Parse(cbxLemonade.Text);
                itemsPrice[count] = double.Parse(lblLemonadePrice.Text);
                count++;
            }
        }

        //Main Dishes
        private void btnSteak_Click(object sender, EventArgs e)
        {
            string name = lblSteak.Text;
            int quantity = int.Parse(cbxSteak.Text);
            double price = double.Parse(lblSteak.Text);
        }

        private void btnChickenParm_Click(object sender, EventArgs e)
        {
            string name = lblChickenParm.Text;
            int quantity = int.Parse(cbxChickenParm.Text);
            double price = double.Parse(lblChickenParm.Text);
        }

        private void btnGnocchi_Click(object sender, EventArgs e)
        {
            string name = lblGnocchi.Text;
            int quantity = int.Parse(cbxGnocchi.Text);
            double price = double.Parse(lblGnocchi.Text);
        }

        private void btnChickenAlfredo_Click(object sender, EventArgs e)
        {
            string name = lblChickenAlfredo.Text;
            int quantity = int.Parse(cbxChickenAlfredo.Text);
            double price = double.Parse(lblChickenAlfredoPrice.Text);
        }

        //Pastas
        private void btnPasta_Click(object sender, EventArgs e)
        {
            string name = lblPasta.Text;
            int quantity = int.Parse(cbxPasta.Text);
            double price = double.Parse(lblPastaPrice.Text);
        }

        private void btnLasanga_Click(object sender, EventArgs e)
        {
            string name = lblLasanga.Text;
            int quantity = int.Parse(cbxLasanga.Text);
            double price = double.Parse(lblLasangaPrice.Text);
        }

        private void btnMinestrone_Click(object sender, EventArgs e)
        {
            string name = lblSteak.Text;
            int quantity = int.Parse(cbxSteak.Text);
            double price = double.Parse(lblSteak.Text);
        }

        private void btnSpaghetti_Click(object sender, EventArgs e)
        {
            string name = lblSpaghetti.Text;
            int quantity = int.Parse(cbxSpaghetti.Text);
            double price = double.Parse(lblSpaghettiPrice.Text);
        }

    }
}