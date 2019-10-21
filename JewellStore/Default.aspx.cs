using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace JewellStore
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbClass obj = new dbClass();

            String res = "";
            string query = "select * from product";
            DataTable tbl = new DataTable();
            tbl = obj.getRecord(query);
            if (tbl.Rows.Count > 0)
            {
                for(int y=0;y<tbl.Rows.Count;y++) {
                    res = res + "<div class='col-lg-4 bottom-sub-grid text-center; data-aos='fade-up'><div class='bt-icon'></div><h1 class='tittle'>"+tbl.Rows[y]["Category"]+"</h1><hr/><img src='"+tbl.Rows[y]["photo"]+"' class='thumbnail' height='300px' width='300px'/><hr/><br/><h2 class='sub-title'>$"+tbl.Rows[y]["Price"]+ "</h2><hr/><br/><h2 class='sub-title'>Size--" + tbl.Rows[y]["Size"] + "</h2><hr/><p style='color:black;'>"+tbl.Rows[y]["Description"]+"</p></div>";

                }
                data.InnerHtml = res;
            }
            else {

            }

            


        }
    }
}