using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace SehirIlceWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_sehir.DataSource = dm.SehirleriGetir();
                ddl_sehir.DataBind();
            }
           
        }

        protected void ddl_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(ddl_sehir.SelectedValue);
            ddl_ilce.DataSource=dm.IlceleriGetir(id);
            ddl_ilce.DataBind();
        }
    }
}