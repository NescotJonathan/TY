using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace AramarkFinal
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = null;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lblError.Text = "ERROR: Please enter a name.";
            }
            else if ((!rbStudent.Checked) && (!rbFaculty.Checked))
            {
                lblError.Text = "ERROR: Please state whether you're a student or a teacher.";
            }
            else if (txtPhone.Text == "")
            {
                lblError.Text = "ERROR: Please enter a phone number.";
            }
            else
            {
                double total = (double)Session["OrderTotal"];

                AramarkFinalDBEntities db = new AramarkFinalDBEntities();
                var dbOrders = db.Orders;
                var newOrder = new Order();

                DateTime currentTime = DateTime.Now;


                total = (rbStudent.Checked) ? total : total * 1.2;

                newOrder.Name = txtName.Text;
                newOrder.Phone = txtPhone.Text;
                newOrder.Price = total.ToString();
                newOrder.Cheese = (int)Session["QuantityCheese"];
                newOrder.Pepperoni = (int)Session["QuantityPepperoni"];
                newOrder.Time = currentTime.ToString();
                newOrder.Status = "Processing...";

                dbOrders.Add(newOrder);
                db.SaveChanges();
                Response.Redirect("Orders.aspx");

                try
                {
                    dbOrders.Add(newOrder);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var errors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in errors.ValidationErrors)
                        {
                            // get the error message (check me in breakpoint!)
                            string errorMessage = validationError.ErrorMessage;
                        }
                    }
                }
            }
        }
    }
}
