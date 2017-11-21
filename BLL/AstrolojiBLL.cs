using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AstrolojiBLL
    {
        #region GetInstance
        static AstrolojiBLL instance = null;
        public static AstrolojiBLL GetInstance()
        {
            if (instance == null)
            {
                instance = new AstrolojiBLL();
                return instance;
            }
            else
            {
                return instance;
            }
        }
        #endregion
        public List<AstrolojiModel> filmAl(string Text)
        {
            List<AstrolojiModel> lst = new List<AstrolojiModel>();
            Helper hlp = Helper.GetInstance();
            hlp.OpenConnection();
            OleDbDataReader dr = hlp.ExecuteReader(Text, CommandType.Text, null);
            while (dr.Read())
            {
                lst.Add(new AstrolojiModel(Convert.ToInt32(dr["FilmID"]), dr["FilmAdi"].ToString()));
            }
            dr.Close();
            hlp.CloseConnection();
            return lst;
        }
        public List<HediyeModel> HediyeAl(string Text)
        {
            List<HediyeModel> lst2 = new List<HediyeModel>();
            Helper hlp = Helper.GetInstance();
            hlp.OpenConnection();
            OleDbDataReader dr = hlp.ExecuteReader(Text, CommandType.Text, null);
            while (dr.Read())
            {
                lst2.Add(new HediyeModel(Convert.ToInt32(dr["HediyeID"]), dr["HediyeAdi"].ToString()));
            }
            dr.Close();
            hlp.CloseConnection();
            return lst2;
        }

        public string YapilacakAl(string Text)
        {
            string x;
            Helper hlp = Helper.GetInstance();
            hlp.OpenConnection();
            OleDbDataReader dr = hlp.ExecuteReader(Text, CommandType.Text, null);
            if (dr.Read())
            {
                x = dr["Yapilacak"].ToString();
                dr.Close();
                hlp.CloseConnection();
                return x;
            }
            else
            {
                dr.Close();
                hlp.CloseConnection();
                return "0";
            }


        }

        public List<YapilacakSayiModel> YapilacakSayiAl(string Text)
        {
            List<YapilacakSayiModel> lst4 = new List<YapilacakSayiModel>();
            Helper hlp = Helper.GetInstance();
            hlp.OpenConnection();
            OleDbDataReader dr = hlp.ExecuteReader(Text, CommandType.Text, null);
            while (dr.Read())
            {
                lst4.Add(new YapilacakSayiModel(Convert.ToInt32(dr["Sayi"])));
            }
            dr.Close();
            hlp.CloseConnection();
            return lst4;

        }

        public string PaylastikcaAl(string Text)
        {
            string x;
            Helper hlp = Helper.GetInstance();
            hlp.OpenConnection();
            OleDbDataReader dr = hlp.ExecuteReader(Text, CommandType.Text, null);
            if (dr.Read())
            {
                x = dr["Paylasma"].ToString();
                dr.Close();
                hlp.CloseConnection();
                return x;
            }
            else
            {
                dr.Close();
                hlp.CloseConnection();
                return "0";
            }


        }

        public List<PaylastikcaSayiModel> PaylastikcaSayiAl(string Text)
        {
            List<PaylastikcaSayiModel> lst4 = new List<PaylastikcaSayiModel>();
            Helper hlp = Helper.GetInstance();
            hlp.OpenConnection();
            OleDbDataReader dr = hlp.ExecuteReader(Text, CommandType.Text, null);
            while (dr.Read())
            {
                lst4.Add(new PaylastikcaSayiModel(Convert.ToInt32(dr["Sayi"])));
            }
            dr.Close();
            hlp.CloseConnection();
            return lst4;

        }

        public bool YorumYap(string Text)
        {
            Helper hlp = Helper.GetInstance();
            hlp.OpenConnection();
            OleDbDataReader dr = hlp.ExecuteReader(Text, CommandType.Text, null);
            
                hlp.CloseConnection();
                dr.Close();
                return true;
            
        }

        public List<YorumModel> YorumGetir(string Text)
        {
            List<YorumModel> lst = new List<YorumModel>();
            Helper hlp = Helper.GetInstance();
            hlp.OpenConnection();
            OleDbDataReader dr = hlp.ExecuteReader(Text, CommandType.Text, null);
            while (dr.Read())
            {
                lst.Add(new YorumModel(dr["EPosta"].ToString(), dr["AdSoyad"].ToString(), dr["MemnunMu"].ToString(), dr["Yorum"].ToString()));
            }
            dr.Close();
            hlp.CloseConnection();
            return lst;
        }

    }
}
