using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astroloji
{
    public partial class Yorum : System.Web.UI.Page
    {
        AstrolojiBLL abl = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            abl = AstrolojiBLL.GetInstance();
            List<YorumModel> asd = abl.YorumGetir("SELECT EPosta,AdSoyad,MemnunMu,Yorum FROM Yorumlar;");
            dtRepeter.DataSource = asd;
            dtRepeter.DataBind();
        }
    }
}