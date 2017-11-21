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
    public partial class AstrolojikBilgiler : System.Web.UI.Page
    {
        AstrolojiBLL abl = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFilmOner_Click(object sender, EventArgs e)
        {
            abl = AstrolojiBLL.GetInstance();
            List<AstrolojiModel> aml = abl.filmAl("SELECT Film.FilmID, Film.FilmAdi FROM Film INNER JOIN FilmBurc ON FilmBurc.FilmID = Film.FilmID WHERE FilmBurc.BurcID=" + burcSec.SelectedValue + " AND FilmBurc.cinsiyetID= " + cinsiyetSec.SelectedValue + ";");

            Session["Veri"] = aml;
            Response.Redirect("AstrolojiBilgiGetir.aspx");
        }

        protected void btnHediyeOner_Click(object sender, EventArgs e)
        {
            abl = AstrolojiBLL.GetInstance();
            List<HediyeModel> aml = abl.HediyeAl("SELECT Hediyeler.HediyeID, Hediyeler.HediyeAdi FROM Hediyeler INNER JOIN HediyeBurc ON HediyeBurc.HediyeID = Hediyeler.HediyeID WHERE HediyeBurc.HediyeID=" + burcSec.SelectedValue + " AND HediyeBurc.CinsiyetID= " + cinsiyetSec.SelectedValue + ";");

            Session["Veri"] = aml;
            Response.Redirect("HediyeBilgiGetir.aspx");
        }
    }
}