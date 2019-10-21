using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellStore
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        dbClass obj = new dbClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            // get the user name or password from the text boxes 
            String UsrName = txtName.Text;
            String Password = txtPassword.Text;
            //database query to use and compare the user name or password
            String query = "select * from login where UserName='"+UsrName+"' and UserPassword='"+Password+"'";
            DataTable obj_Data = new DataTable();
            //pass the data to the data table
            obj_Data = obj.getRecord(query);
            //check the record is matched or not 
            if (obj_Data.Rows.Count>0) {
                result.InnerHtml = "<script> alert('wel come the site ');</script>";

                Response.Redirect("adminZone.aspx");

                txtName.Text = "";
                txtPassword.Text = "";

            }
            else {
                result.InnerHtml = "Invalid User Name or Password please verify once";
                txtName.Text = "";
                txtPassword.Text = "";

            }

        }
    }
}