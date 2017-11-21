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
    public partial class WebForm1 : System.Web.UI.Page
    {
        AstrolojiBLL abl = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            abl = AstrolojiBLL.GetInstance();
            bool sonuc =   abl.YorumYap("INSERT INTO Yorumlar (EPosta,AdSoyad,MemnunMu,Yorum) VALUES('" + txtEposta.Text + "','" + txtIsim.Text + "','" + EvetHayir.SelectedValue + "','" + txtYorum.Text + "');");
            if (sonuc== true)
            {
                Response.Redirect("Yorum.aspx");
            }
        }
    }
}