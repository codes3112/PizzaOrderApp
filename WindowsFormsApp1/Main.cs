using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {

        private string order;

        const double TAX_RATE = .13;  //@ 13%
        const double PRICE_SMALL = 9.0;
        const double PRICE_MEDIUM = 12.0;
        const double PRICE_LARGE = 15.0;
        const double PRICE_TOPPING = 1.5;
        const double PRICE_SODA = 1.75;
        const double PRICE_CHICKEN_WINGS = 4.5;
        const double PRICE_POTATO_WEDGES = 3.5;
        double pizzaCost = 0;
        double toppingCost = 0;
        double specialityCost = 0;
        string orderFormat = "{0,-20}{1,-20}{3,-20}\n";


        private double subTotal;
        private double tax;
        private double total;



        public Main(string username)
        {
            InitializeComponent();
            
            label13.Text = username;
            label15.Text = username;
            label17.Text = username;

            if (username == "")
            {
                label13.Text = "Guest";
                label15.Text = "Guest";
                label17.Text = "Guest";
            }
            else
            {
                label13.Text = username;
                label15.Text = username;
                label17.Text = username;
            }
            this.FormClosing += Main_FormClosing;
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            ClearTheReceipt();
            ClearTheSelections();

            //this.txtBxPizzaQty.Text = "0";
            //this.txtBxSoda.Text = "0";
            //this.txtBxWater.Text = "0";

            subTotal = 0;
            tax = 0;
            total = 0;

        }



        private void ClearTheReceipt()
        {
            lstBxOrderReceipt.Items.Clear();
            lstBxTotal.Items.Clear();

        }


        private void ClearTheSelections()
        {
            rad1.Checked = false;
            rad2.Checked = false;
            rad3.Checked = false;

            chkBxOlives.Checked = false;
            chkBxMush.Checked = false;
            chkBxJal.Checked = false;
            chkBxOnions.Checked = false;
            txtBxPizzaQty.Clear();



            lstBxSize.SelectedItems.Clear();            
            lstBxSpecialityItems.SelectedItems.Clear();


            this.txtBxPizzaQty.Text = "0";
            this.txtBxSoda.Text = "0";
            this.txtBxWater.Text = "0";

        }


        private double ComputePizzaCost()
        {

            double pizzaCnt;
            order = "";



            /*---------------------------------------------------------------------------------------------
             Calculate the pizza Cost
             //---------------------------------------------------------------------------------------------*/
            
            switch (lstBxSize.SelectedIndex)
            {
                case 0:
                    pizzaCost = PRICE_SMALL;
                    break;
                case 1:
                    pizzaCost = PRICE_MEDIUM;
                    break;
                case 2:
                    pizzaCost = PRICE_LARGE;
                    break;
                                               
            }

           

            while (double.TryParse(txtBxPizzaQty.Text, out pizzaCnt) == false)
            {
                MessageBox.Show("The Quantity Must be numeric");
                txtBxPizzaQty.Text = "0";
            }

            if (txtBxPizzaQty.Text != "0")
            {
                //Input Validation
                //-------------------------------------------------------------------------------------------

                if (lstBxSize.Text == "")
                {
                    MessageBox.Show("You must select a size", "Size", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    
                }
                else if ((rad1.Checked == false) && (rad2.Checked == false) &&
                    (rad3.Checked == false))
                {

                    MessageBox.Show("You must select a crust type", "Crust", MessageBoxButtons.OK,
                       MessageBoxIcon.Asterisk);
                }
             
                    order += "\n\nPizza Selections:\n  " + lstBxSize.SelectedItem.ToString() + "                            " + pizzaCost.ToString("C");
                    lstBxOrderReceipt.Items.Add(order);
                    lstBxOrderReceipt.Items.Add("--------------------------------------------------");

                    order = "";
                    /*---------------------------------------------------------------------------------------------
            Calculate the cost of Toppings
           //---------------------------------------------------------------------------------------------*/

                    order += "\nToppings:  ";
                    bool[] chkBox = new bool[] { chkBxOlives.Checked,
                                             chkBxMush.Checked,
                                             chkBxJal.Checked,
                                             chkBxOnions.Checked};
                    int num = 0;

                    for (int i = 0; i < chkBox.Length; i++)
                    {
                        if (chkBox[i] == true)
                        {
                            num += 1;
                            switch (i)
                            {
                                case 0:
                                    order += " Olives " + "  ";
                                    break;
                                case 1:
                                    order += " Mushrooms " + "  ";
                                    break;
                                case 2:
                                    order += " Jalapenoes " + "  ";
                                    break;
                                case 3:
                                    order += " Onions " + "  ";
                                    break;
                            }                       

                        }
                    }
                if (num != 0)
                {
                    toppingCost += PRICE_TOPPING * num;
                    order += "\n" + num + " Topping(s) " + toppingCost.ToString("C");
                    lstBxOrderReceipt.Items.Add(order);
                    lstBxOrderReceipt.Items.Add("--------------------------------------------------");
                }

                order = "";


                    pizzaCost = (pizzaCost + toppingCost) * pizzaCnt;
                    order += "\n\nPizza Quantity:\n" + pizzaCnt + "  pizza(s) " + pizzaCost.ToString("C");

                    lstBxOrderReceipt.Items.Add(order);


                }
            

             
            else
            {
                MessageBox.Show("You must select quantity", "Quantity", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                pizzaCost = 0;

            }

            return pizzaCost;
        }


        private double ComputeSpecialityCost()
        {

            order = "";
            double sodaCnt,
                   waterCnt,
                   sodaCost;
            /*---------------------------------------------------------------------------------------------
            Calculate the cost of Speciality Items
            //---------------------------------------------------------------------------------------------*/
            if (lstBxSpecialityItems.Text == "Potato Wedges - $ 3.5" && lstBxSpecialityItems.Text == "Chicken Wings - $ 4.5")
            {
                specialityCost += PRICE_POTATO_WEDGES + PRICE_CHICKEN_WINGS;
                order += "\n\nSpecialty Items:\n" + "Potato Wedges          " + PRICE_POTATO_WEDGES.ToString("C");
                order += "\n\nChicken Wings     " + PRICE_CHICKEN_WINGS.ToString("C");
                lstBxOrderReceipt.Items.Add(order);
                lstBxOrderReceipt.Items.Add("--------------------------------------------------");
            }
            else if (lstBxSpecialityItems.Text == "Chicken Wings - $ 4.5")
            {
                specialityCost += PRICE_CHICKEN_WINGS;
                order += "\n\nSpecialty Items:\n" + "Chicken Wings          " + PRICE_CHICKEN_WINGS.ToString("C");

                lstBxOrderReceipt.Items.Add(order);
                lstBxOrderReceipt.Items.Add("--------------------------------------------------");

            }
            else if (lstBxSpecialityItems.Text == "Potato Wedges - $ 3.5")
            {
                specialityCost += PRICE_POTATO_WEDGES;
                order += "\n\nSpecialty Items:\n" + "Potato Wedges          " + PRICE_POTATO_WEDGES.ToString("C");
                lstBxOrderReceipt.Items.Add(order);
                lstBxOrderReceipt.Items.Add("--------------------------------------------------");

            }



            /*---------------------------------------------------------------------------------------------
            Calculate the cost of Beverages
            //---------------------------------------------------------------------------------------------*/

            order = "";

            while (double.TryParse(txtBxSoda.Text, out sodaCnt) == false)
            {
                MessageBox.Show("The Quantity Must be numeric");
                txtBxSoda.Text = "0";
            }
            if (txtBxSoda.Text != "0")
            {
                sodaCost = sodaCnt * PRICE_SODA;

                specialityCost += sodaCost;

                order += "\n\nDrink Selections:" + "\n" + sodaCnt + " soda(s) " + sodaCost.ToString("C");


                lstBxOrderReceipt.Items.Add(order);
                lstBxOrderReceipt.Items.Add("--------------------------------------------------");
            }

            order = "";

            while (double.TryParse(txtBxWater.Text, out waterCnt) == false)
            {
                MessageBox.Show("The Quantity Must be numeric");
                txtBxWater.Text = "0";
            }
            if (txtBxSoda.Text != "0")
            {
                order += "\n" + waterCnt + " water(s)             ";


                lstBxOrderReceipt.Items.Add(order);
                lstBxOrderReceipt.Items.Add("--------------------------------------------------");
            }
            order = "";
            


            return specialityCost;


        }

        public void UpdateTotal()
        {

            lstBxTotal.Items.Clear();

            lstBxTotal.Items.Add(dateTimePicker1.Text);

            /*---------------------------------------------------------------------------------------------
              Display the Sub Total
            //---------------------------------------------------------------------------------------------*/

            subTotal = ComputePizzaCost() + ComputeSpecialityCost();


            lstBxTotal.Items.Add("SubTotal:                         " +subTotal.ToString("C"));

            tax = subTotal * TAX_RATE;
            total = subTotal + tax;

            lstBxTotal.Items.Add("Tax:                                    " +tax.ToString("C"));

            lstBxTotal.Items.Add("Total:                                 " +total.ToString("C"));

            lstBxOrderReceipt.Items.Add("------------------------------------------------");

            ClearTheSelections();


        }




        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(2);
            UpdateTotal();



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTheSelections();
            ClearTheReceipt();
            tabControl1.SelectTab(0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the aplication?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                MessageBox.Show("The Application has been closed successfully", "Application Closed", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

    }
}
