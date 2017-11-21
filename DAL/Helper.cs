using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Helper
    {
        OleDbConnection cn = null;
        OleDbCommand cmd = null;
        static Helper instance = null;

        public static Helper GetInstance()
        {
            if (instance == null)
            {
                instance = new Helper();
                return instance;
            }
            else
            {
                return instance;
            }
        }

        private Helper()
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:/filmburc.accdb; Persist Security Info = False; ");
        }

        public void OpenConnection()//metot ekledik
        {
            if (cn != null && cn.State != ConnectionState.Open)//ConnectionSnuull değilse  connstatesi açık değilse aç
            {
                cn.Open();
            }
        }

        public void CloseConnection()//metot ekledik
        {
            if (cn != null && cn.State != ConnectionState.Closed)//nesnemiz varsa Version kapalı değilse kapat
            {
                cn.Close();
            }
        }

        public int ExecuteNonQuery(string cmdtext, CommandType tpye, OleDbParameter[] p)
        {
            try
            {
                cmd = new OleDbCommand(cmdtext, cn);
                cmd.CommandType = tpye;
                cmd.Parameters.AddRange(p);
                return cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public OleDbDataReader ExecuteReader(string cmdtext, CommandType tpye, OleDbParameter[] p)//geriye sqldatareader döndürür.//dışarıdan alıyoruz ınserti,updeteyi,deleteyi
        {
            cmd = new OleDbCommand(cmdtext, cn);
            cmd.CommandType = tpye;

            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);//Açık biyer olursa kapatıyor . işi bitince otomatik kapatır (connection behavior).
        }

        public OleDbDataReader ExecuteReader(string cmdtext, OleDbParameter[] p)//geriye sqldatareader döndürür.//dışarıdan alıyoruz ınserti,updeteyi,deleteyi
        {
            cmd = new OleDbCommand(cmdtext, cn);

            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);//Açık biyer olursa kapatıyor . işi bitince otomatik kapatır (connection behavior).
        }

        public DataTable MyDataTable(string cmdtext,CommandType Type, OleDbParameter[] p)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(cmdtext, cn);
            da.SelectCommand.CommandType = Type;//Gelen komut tipini store procedure olduğunu belirtmek için kullandık.
            if (p!=null)
            {
                da.SelectCommand.Parameters.AddRange(p);
            }
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
