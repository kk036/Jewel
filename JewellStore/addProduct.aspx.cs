using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections.Generic;

namespace JewellStore
{
    public partial class addProduct : System.Web.UI.Page
    {
        dbClass obj = new dbClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
           
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Product/" + str));
                result.InnerHtml = "record added";
                string Image = "Product/" + str.ToString();
                String query = "insert into product(Category,Description,Size,Price,Photo) values('" + txtCat.Text + "','" + txtDescription.Text + "','" + TxtSize.Text + "','" + TxtPrice.Text + "','" + Image + "')";
                obj.record(query);
                txtCat.Text = "";
                txtDescription.Text = "";
                TxtPrice.Text = "";
                TxtSize.Text = "";
            }
            else
            {
                result.InnerHtml = "record not added";
            }
        }
    }
}