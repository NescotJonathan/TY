using System;
using System.Collections.Generic;
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
            double total = (double)Session["OrderTotal"];

            if (txtName.Text == "")
            {
                lblError.Text = "ERROR: Please enter a name.";
            }
            else if (txtPhone.Text == "")
            {
                lblError.Text = "ERROR: Please enter a phone number.";
            }
            else if ((!rbStudent.Checked) && (!rbTeacher.Checked))
            {
                lblError.Text = "ERROR: Please state whether you're a student or a teacher.";
            }
            else
            {
                total = (rbStudent.Checked) ? total : total * 1.2;
            }
        }
    }
}