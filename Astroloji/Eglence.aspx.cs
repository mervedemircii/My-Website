using MODEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astroloji
{
    public partial class Eglence : System.Web.UI.Page
    {
        AstrolojiBLL abl = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            abl = AstrolojiBLL.GetInstance();
            List<YapilacakSayiModel> aml2 = abl.YapilacakSayiAl("SELECT COUNT(*) AS Sayi FROM Yapilacaklar;");
            Random rnd = new Random();
            int x = rnd.Next(1, aml2[0].Sayi);

            string degisken = abl.YapilacakAl("SELECT Yapilacak FROM Yapilacaklar WHERE YapilacakID = " + x + ";");
            lblYazi.Text = degisken;


            abl = AstrolojiBLL.GetInstance();
            List<PaylastikcaSayiModel> aml3 = abl.PaylastikcaSayiAl("SELECT COUNT(*) AS Sayi FROM MutlulukPaylastikcaGuzel;");
            Random rnd2 = new Random();
            int x2 = rnd2.Next(1, aml3[0].Sayi);

            string degisken2 = abl.PaylastikcaAl("SELECT Paylasma FROM MutlulukPaylastikcaGuzel WHERE PaylasmaID = " + x2 + ";");
            paylasmalbl.Text = degisken2;



        }
    }
}