using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AramarkFinal
{
    public partial class StaffPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = null;
            lblGridError.Text = null;

            if (!IsPostBack)
            {
                LoginVisibility(false);
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            using (AramarkFinalDBEntities db = new AramarkFinalDBEntities())
            {
                var kitchenStaff = db.Logins.Where(kS => (kS.Username == txtUsername.Text) && (kS.Password == txtPassword.Text)).FirstOrDefault();

                if (kitchenStaff != null)
                {
                    LoginVisibility(true);
                }
                else
                {
                    lblError.Text = "ERROR: Incorrect login credentials.";
                    LoginVisibility(false);
                }
            }
        }

        private void LoginVisibility(bool x)
        {
            grdOrders.Visible = x;
            btnConfirm.Visible = x;
            btnDelete.Visible = x;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (grdOrders.SelectedRow == null)
            {
                lblGridError.Text = "ERROR: Please select a row first.";
            }
            else
            {
                AramarkFinalDBEntities db = new AramarkFinalDBEntities();

                var order = db.Orders.Find(grdOrders.SelectedValue);
                order.Status = "Confirmed";

                db.SaveChanges();
                grdOrders.DataBind();
            }    
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if(grdOrders.SelectedRow == null)
            {
                lblGridError.Text = "ERROR: Please select a row first.";
            }
            else
            {
                AramarkFinalDBEntities db = new AramarkFinalDBEntities();

                var order = db.Orders.Find(grdOrders.SelectedValue);
                db.Entry(order).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                grdOrders.DataBind();
            }
        }

        protected void btnGoToPizzas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnGoToOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("Orders.aspx");
        }
    }
}