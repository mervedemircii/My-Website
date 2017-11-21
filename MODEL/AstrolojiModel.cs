using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class AstrolojiModel
    {
        public AstrolojiModel(int filmID, string filmAdi)
        {
            this.filmID = filmID;
            this.filmAdi = filmAdi;
        }

        public int filmID { get; set; }
        public int cinsiyetID { get; set; }
        public int burcID { get; set; }
        public string filmAdi { get; set; }

    }
    public class HediyeModel
    {
        public HediyeModel(int HediyeID, string HediyeAdi)
        {
            this.HediyeID = HediyeID;
            this.HediyeAdi = HediyeAdi;
        }

        public int HediyeID { get; set; }
        public int CinsiyetID { get; set; }
        public int BurcID { get; set; }
        public string HediyeAdi { get; set; }

    }

    public class YapilacakModel
    {
        public YapilacakModel(int YapilacakID, string Yapilacak)
        {
            this.YapilacakID = YapilacakID;
            this.Yapilacak = Yapilacak;
        }

        public int YapilacakID { get; set; }
        public string Yapilacak { get; set; }
    }

    public class YapilacakSayiModel
    {
        public YapilacakSayiModel(int Sayi)
        {
            this.Sayi = Sayi;
        }
        public int Sayi { get; set; }
    }

    public class PaylastikcaModel
    {
        public PaylastikcaModel(int PaylasmaID, string Paylasma)
        {
            this.PaylasmaID = PaylasmaID;
            this.Paylasma = Paylasma;
        }

        public int PaylasmaID { get; set; }
        public string Paylasma { get; set; }
    }

    public class PaylastikcaSayiModel
    {
        public PaylastikcaSayiModel(int Sayi)
        {
            this.Sayi = Sayi;
        }
        public int Sayi { get; set; }
    }

    public class YorumModel
    {
        public YorumModel(string EPosta, string AdSoyad, string MemnunMu, string Yorum)
        {
            this.AdSoyad = AdSoyad;
            this.EPosta = EPosta;
            this.MemnunMu = MemnunMu;
            this.Yorum = Yorum;
        }
        public string EPosta { get; set; }
        public string AdSoyad { get; set; }
        public string MemnunMu { get; set; }
        public string Yorum { get; set; }
    }
}
