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
    }


}