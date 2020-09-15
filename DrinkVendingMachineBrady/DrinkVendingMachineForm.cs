using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Drink Vending Machine
* Author      : Kabrina Brady
* Created     : 10/15/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User clicks on a picture to buy an item. Price of item is added to total sales and the number of items left is decremented.
*               Input:  Picture clicks
*               Output: Total sales, remaining items
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace DrinkVendingMachineBrady
{
    struct TypesDrinks //drinks structure
    {
        public int remainingCola;
        public int remainingRootBeer;
        public int remainingLemonLime;
        public int remainingGrapeSoda;
        public int remainingCreamSoda;
    }

    public partial class DrinkVendingMachineForm : Form
    {
        double totalSales; //double to hold total amount of sales

        public DrinkVendingMachineForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }

        //THE COMMENTS FOR THIS METHOD APPLY TO ALL OTHER PICTUREBOX CLICK EVENT HANDLERS
        private void PicCola_Click(object sender, EventArgs e)
        {
            //create instance of structure
            TypesDrinks details = new TypesDrinks();

            int priceCola = 1; //sets the price of drink
            totalSales = priceCola + totalSales; //adds price to total sales

            int subtract = int.Parse(lblDrinksLeftCola.Text); //makes an int that is equal to the current number of drinks left
            details.remainingCola = 0; //initializes details.remainingDrink to 0
            int needed = 1; //number of drinks user wants (one per click)

            details.remainingCola = subtract - needed; //remaining drinks are the current number of drinks left minus needed drinks
            lblDrinksLeftCola.Text = details.remainingCola.ToString(); //displays new number of drinks left

            //error message if no drinks left
            if (details.remainingCola <= 0)
            {
                MessageBox.Show("No drinks left!");
            }

            lblTotalSales.Text = totalSales.ToString("c"); //displays total sales
        }

        private void DrinkVendingMachineForm_Load(object sender, EventArgs e)
        {
            //initializes all values to 20 when form loads
            lblDrinksLeftCola.Text = "20";
            lblDrinksLeftRootBeer.Text = "20";
            lblDrinksLeftLemonLime.Text = "20";
            lblDrinksLeftGrapeSoda.Text = "20";
            lblDrinksLeftCreamSoda.Text = "20";
        }

        private void PicRootBeer_Click(object sender, EventArgs e)
        {
            //create instance of structure
            TypesDrinks details = new TypesDrinks();

            int priceRootBeer = 1;
            totalSales = priceRootBeer + totalSales;

            int subtract = int.Parse(lblDrinksLeftRootBeer.Text);
            details.remainingRootBeer = 0;
            int needed = 1;

            details.remainingRootBeer = subtract - needed;
            lblDrinksLeftRootBeer.Text = details.remainingRootBeer.ToString();

            if (details.remainingRootBeer <= 0)
            {
                MessageBox.Show("No drinks left!");
            }

            lblTotalSales.Text = totalSales.ToString("c");
        }

        private void PicLemonLime_Click(object sender, EventArgs e)
        {
            //create instance of structure
            TypesDrinks details = new TypesDrinks();

            int priceLemonLime = 1;
            totalSales = priceLemonLime + totalSales;

            int subtract = int.Parse(lblDrinksLeftLemonLime.Text);
            details.remainingLemonLime = 0;
            int needed = 1;

            details.remainingLemonLime = subtract - needed;
            lblDrinksLeftLemonLime.Text = details.remainingLemonLime.ToString();

            if (details.remainingLemonLime <= 0)
            {
                MessageBox.Show("No drinks left!");
            }

            lblTotalSales.Text = totalSales.ToString("c");
        }

        private void PicGrapeSoda_Click(object sender, EventArgs e)
        {
            //create instance of structure
            TypesDrinks details = new TypesDrinks();

            double priceGrapeSoda = 1.50;
            totalSales = priceGrapeSoda + totalSales;

            int subtract = int.Parse(lblDrinksLeftGrapeSoda.Text);
            details.remainingGrapeSoda = 0;
            int needed = 1;

            details.remainingGrapeSoda = subtract - needed;
            lblDrinksLeftGrapeSoda.Text = details.remainingGrapeSoda.ToString();

            if (details.remainingGrapeSoda <= 0)
            {
                MessageBox.Show("No drinks left!");
            }

            lblTotalSales.Text = totalSales.ToString("c");
        }

        private void PicCreamSoda_Click(object sender, EventArgs e)
        {
            //create instance of structure
            TypesDrinks details = new TypesDrinks();

            double priceCreamSoda = 1.50;
            totalSales = priceCreamSoda + totalSales;

            int subtract = int.Parse(lblDrinksLeftCreamSoda.Text);
            details.remainingCreamSoda = 0;
            int needed = 1;

            details.remainingCreamSoda = subtract - needed;
            lblDrinksLeftCreamSoda.Text = details.remainingCreamSoda.ToString();

            if (details.remainingCreamSoda <= 0)
            {
                MessageBox.Show("No drinks left!");
            }

            lblTotalSales.Text = totalSales.ToString("c");
        }
    }
}

