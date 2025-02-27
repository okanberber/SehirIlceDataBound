using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=DersOrnek; Integrated Security=True");
            cmd = con.CreateCommand();
        }
        public List<Sehir> SehirleriGetir()
        {
            List<Sehir> sehirler = new List<Sehir>();
            try
            {
                cmd.CommandText = "SELECT ID,Isim FROM Sehirler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sehir s = new Sehir();
                    s.ID = reader.GetInt32(0);
                    s.Isim = reader.GetString(1);
                    sehirler.Add(s);
                }
                return sehirler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Ilce> IlceleriGetir()
        {
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                cmd.CommandText = "SELECT ID,SehirID,Isim FROM Ilceler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ilce i = new Ilce();
                    i.ID = reader.GetInt32(0);
                    i.SehirID = reader.GetInt32(1);
                    i.Isim = reader.GetString(2);
                    ilceler.Add(i);
                }
                return ilceler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Ilce> IlceleriGetir(int sehirid)
        {
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                cmd.CommandText = "SELECT ID,SehirID,Isim FROM Ilceler WHERE SehirID=@sid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sid", sehirid);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ilce i = new Ilce();
                    i.ID = reader.GetInt32(0);
                    i.SehirID = reader.GetInt32(1);
                    i.Isim = reader.GetString(2);
                    ilceler.Add(i);
                }
                return ilceler;
            }
            catch
            {
                return null ;
            }
            finally
            {
                con.Close() ;
            }
        }
    }
}
