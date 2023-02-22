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
        double total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = null;
            btnOk.Visible = false;
        }

        protected void btnAddCheese_Click(object sender, EventArgs e)
        {
            int quantityCheese = int.Parse(lblCheeseQuantity.Text);
            int quantityPepperoni = int.Parse(lblPepperoniQuantity.Text);

            quantityCheese++;
            total += (quantityCheese * 3.6) + (quantityPepperoni * 3.8);
            lblTotal.Text = String.Format("{0:C}", total);
            lblCheeseQuantity.Text = quantityCheese.ToString();

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

        protected void btnRemoveCheese_Click(object sender, EventArgs e)
        {
            int quantityCheese = int.Parse(lblCheeseQuantity.Text);
            int quantityPepperoni = int.Parse(lblPepperoniQuantity.Text);

            if (quantityCheese < 1)
            {
                lblError.Text = "ERROR: Cannot remove cheese pizza from order.";
            }
            else
            {
                quantityCheese--;
                total += (quantityCheese * 3.6) + (quantityPepperoni * 3.8);
                lblTotal.Text = String.Format("{0:C}", total);
                lblCheeseQuantity.Text = quantityCheese.ToString();
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
    }
}