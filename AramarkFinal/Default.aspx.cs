using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AramarkFinal
{
    public partial class Default : System.Web.UI.Page
    {
        //Declares the running total and sets it as zero
        double total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //On page load/reload, the error message is cleared and the confirmation button is hidden
            lblError.Text = null;
            btnOk.Visible = false;
        }

        protected void btnAddCheese_Click(object sender, EventArgs e)
        {
            //Declares the quantities of both the cheese and pepperoni pizzas sets the value as the current number found on the webpage
            int quantityCheese = int.Parse(lblCheeseQuantity.Text);
            int quantityPepperoni = int.Parse(lblPepperoniQuantity.Text);

            //Increase the quantity of the cheese pizzas by one
            quantityCheese++;
            //Calculates the full total of the order and sets that value to the running total
            total += (quantityCheese * 3.6) + (quantityPepperoni * 3.8);
            
            //Displays the running total in currency format
            lblTotal.Text = String.Format("{0:C}", total);
            //Displays the quantity of cheese pizzas selected
            lblCheeseQuantity.Text = quantityCheese.ToString();

            //Checks if there are any pizzas in the order currently, hides the confirmation button if there are no pizzas selected
            if (quantityCheese < 1 && quantityPepperoni < 1)
            {
                btnOk.Visible = false;
            }
            else
            {
                btnOk.Visible = true;
            }

            //Sets the quantities of the pizzas alongside the running total to the value of the running total
            Session["QuantityCheese"] = quantityCheese;
            Session["QuantityPepperoni"] = quantityPepperoni;
            Session["OrderTotal"] = total;
        }

        protected void btnRemoveCheese_Click(object sender, EventArgs e)
        {
            //Declares the quantities of both the cheese and pepperoni pizzas sets the value as the current number found on the webpage
            int quantityCheese = int.Parse(lblCheeseQuantity.Text);
            int quantityPepperoni = int.Parse(lblPepperoniQuantity.Text);

            //Checks if there are no cheese pizzas selected, sends an error message if so
            if (quantityCheese < 1)
            {
                lblError.Text = "ERROR: Cannot remove cheese pizza from order.";
            }
            else
            {
                //Decrease the quantity of the cheese pizzas by one
                quantityCheese--;

                total += (quantityCheese * 3.6) + (quantityPepperoni * 3.8);
                lblTotal.Text = String.Format("{0:C}", total);
                lblCheeseQuantity.Text = quantityCheese.ToString();
            }

            //Checks if there are any pizzas in the order currently, hides the confirmation button if there are no pizzas selected
            if (quantityCheese < 1 && quantityPepperoni < 1)
            {
                btnOk.Visible = false;
            }
            else
            {
                btnOk.Visible = true;
            }


            //Sets the quantities of the pizzas alongside the running total to the value of the running total
            Session["QuantityCheese"] = quantityCheese;
            Session["QuantityPepperoni"] = quantityPepperoni;
            Session["OrderTotal"] = total;
        }


        protected void btnAddPepperoni_Click(object sender, EventArgs e)
        {
            int quantityCheese = int.Parse(lblCheeseQuantity.Text);
            int quantityPepperoni = int.Parse(lblPepperoniQuantity.Text);

            quantityPepperoni++;
            total += (quantityCheese * 3.6) + (quantityPepperoni * 3.8);
            lblTotal.Text = String.Format("{0:C}", total);
            lblPepperoniQuantity.Text = quantityPepperoni.ToString();

            if (quantityCheese < 1 && quantityPepperoni < 1)
            {
                btnOk.Visible = false;
            }
            else
            {
                btnOk.Visible = true;
            }

            Session["QuantityCheese"] = quantityCheese;
            Session["QuantityPepperoni"] = quantityPepperoni;
            Session["OrderTotal"] = total;
        }

        protected void btnRemovePepperoni_Click(object sender, EventArgs e)
        {
            int quantityCheese = int.Parse(lblCheeseQuantity.Text);
            int quantityPepperoni = int.Parse(lblPepperoniQuantity.Text);

            if (quantityPepperoni < 1)
            {
                lblError.Text = "ERROR: Cannot remove pepperoni pizza from order.";
            }
            else
            {
                quantityPepperoni--;
                total += (quantityCheese * 3.6) + (quantityPepperoni * 3.8);
                lblTotal.Text = String.Format("{0:C}", total);
                lblPepperoniQuantity.Text = quantityPepperoni.ToString();
            }

            if (quantityCheese < 1 && quantityPepperoni < 1)
            {
                btnOk.Visible = false;
            }
            else
            {
                btnOk.Visible = true;
            }

            Session["QuantityCheese"] = quantityCheese;
            Session["QuantityPepperoni"] = quantityPepperoni;
            Session["OrderTotal"] = total;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserInfo.aspx");
        }

        protected void btnGoToOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("Orders.aspx");
        }

        protected void btnGoToStaffPanel_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffPanel.aspx");
        }
    }
}