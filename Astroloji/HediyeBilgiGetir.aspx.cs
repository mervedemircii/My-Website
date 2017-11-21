using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astroloji
{
    public partial class HediyeBilgiGetir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<HediyeModel> lst = Session["Veri"] as List<HediyeModel>;

            for (int i = 0; i < lst.Count; i++)
            {
                rptBilgiler.DataSource = lst;
                rptBilgiler.DataBind();
            }
        }
    }
}