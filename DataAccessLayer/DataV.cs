using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataV
    {
        SqlConnection con; SqlCommand cmd;

        public DataV()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Giriş

        public Yonetici AdminGiris(string kullaniciAdi, string sifre)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Yoneticiler WHERE KullaniciAdi=@ka AND Sifre=@sif";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sif", sifre);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi > 0)
                {
                    cmd.CommandText = "SELECT Y.ID, Y.YoneticiTur_ID, YT.Isim, YT.KullaniciAdi, Y.Isim, Y.Soyisim, Y.KullaniciAdi, Y.Mail, Y.Sifre, Y.KayitTarihi, Y.Durum FROM Yoneticiler AS Y JOIN YoneticiTurleri AS YT ON Y.YoneticiTur_ID = YT.ID WHERE Y.KullaniciAdi = @ka AND Y.Sifre = @sif ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sif", sifre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Yonetici y = new Yonetici();
                    while (reader.Read())
                    {
                        y.ID = reader.GetInt32(0);
                        y.YoneticiTur_ID = reader.GetInt32(1);
                        y.YoneticiTur = reader.GetString(2);
                        y.Isim = reader.GetString(3);
                        y.KullaniciAdi = reader.GetString(4);
                        y.Soyisim = reader.GetString(5);
                        y.KullaniciAdi = reader.GetString(6);
                        y.Mail = reader.GetString(7);
                        y.Sifre = reader.GetString(8);
                        y.KayitTarihi = reader.GetDateTime(9);
                        y.KayitTarihiStr = y.KayitTarihi.ToShortDateString();
                        y.Durum = reader.GetBoolean(10);
                    }
                    return y;
                }
                return null;
            }
            catch { return null; }
            finally { con.Close(); }
        }


        #endregion

        #region kategori

        public bool KategoriEkle(Kategori model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Kategoriler(Isim, Durum) VALUES(@i, @d)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@i", model.Isim);
                cmd.Parameters.AddWithValue("@d", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            { con.Close(); }

        }

        public List<Kategori> KategoriListele()
        {
            try
            {
                List<Kategori> kategoriler = new List<Kategori>();
                cmd.CommandText = "SELECT ID, Isim, Durum FROM Kategoriler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Kategori k = new Kategori();
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                    k.Durum = reader.GetBoolean(2);
                    kategoriler.Add(k);
                }
                return kategoriler;
            }
            catch
            { return null; }
            finally { con.Close(); }
        }

        public List<Kategori> KategoriListele(bool durum)
        {
            try
            {
                List<Kategori> kategoriler = new List<Kategori>();
                cmd.CommandText = "SELECT ID, Isim, Durum FROM Kategoriler WHERE Durum = @durum";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@durum", durum);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategori k = new Kategori();
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                    k.Durum = reader.GetBoolean(2);
                    kategoriler.Add(k);
                }
                return kategoriler;
            }
            catch { return null; }
            finally { con.Close(); }
        }

        public void KategoriDurum(int id)
        {
            try
            {
                cmd.CommandText = "SELECT Durum FROM Kategoriler WHERE ID =@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                bool durum = Convert.ToBoolean(cmd.ExecuteScalar());
                cmd.CommandText = "UPDATE Kategoriler SET Durum =@d WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@d", !durum);
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }

        }

        public void KategoriSil(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Kategoriler WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }

        public Kategori KategoriGetir(int id)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Kategoriler WHERE ID =@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                Kategori kt = null;
                while(reader.Read())
                {
                    kt = new Kategori();
                    kt.ID = reader.GetInt32(0);
                    kt.Isim = reader.GetString(1);
                    kt.Durum = reader.GetBoolean(2);
                }
                return kt;
            }
            catch { return null; }
            finally { con.Close(); }
        }

        public bool KategoriDuzenle(Kategori model)
        {
            try
            {
                cmd.CommandText = "UPDATE Kategoriler SET Isim =@isim, Durum=@durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@isim", model.Isim);
                cmd.Parameters.AddWithValue("durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            { con.Close(); }
        }



        #endregion

        #region Notlar

        public bool NotEkle(Notlar not)
        { 
            try
            {
                cmd.CommandText = "INSERT INTO Notlar(Kategori_ID, Yazar_ID, Baslik, Ozet, Icerik, EklenmeTarih, Durum) VALUES(@kategori_ID, @yazar_ID, @baslik, @ozet, @icerik, @eklemeTarih, @durum)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@kategori_ID", not.Kategori_ID);
                cmd.Parameters.AddWithValue("@yazar_ID", not.Yazar_ID);
                cmd.Parameters.AddWithValue("@baslik", not.Baslik);
                cmd.Parameters.AddWithValue("@ozet", not.Ozet);
                cmd.Parameters.AddWithValue("@icerik", not.Icerik);
                cmd.Parameters.AddWithValue("@eklemeTarih", not.EklenmeTarih);
                cmd.Parameters.AddWithValue("@durum", not.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }


        public List<Notlar> NotListele()
        {
            try
            {
                List<Notlar> Not = new List<Notlar>();
                cmd.CommandText = "SELECT N.ID, N.Kategori_ID, K.Isim, N.Yazar_ID, Y.KullaniciAdi, N.Baslik, N.Ozet, N.Icerik, N.EklenmeTarih, N.Durum FROM Notlar AS N JOIN Kategoriler AS K ON N.Kategori_ID = K.ID JOIN Yoneticiler AS Y ON N.Yazar_ID = Y.ID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Notlar nt = new Notlar();
                    nt.ID = reader.GetInt32(0);
                    nt.Kategori_ID = reader.GetInt32(1);
                    nt.Kategori = reader.GetString(2);
                    nt.Yazar_ID = reader.GetInt32(3);
                    nt.Yazar = reader.GetString(4);
                    nt.Baslik = reader.GetString(5);
                    nt.Ozet = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                    nt.Icerik = reader.GetString(7);
                    nt.EklenmeTarih = reader.GetDateTime(8);
                    nt.Durum = reader.GetBoolean(9);
                    Not.Add(nt);
                }
                return Not;
                
            }
            catch { 
            return null;}
            finally { con.Close(); }
        }

        public List<Notlar> NotListele(bool durum)
        {
            try
            {
                List<Notlar> ntt = new List<Notlar>();
                cmd.CommandText = "SELECT N.ID, N.Kategori_ID, K.Isim, N.Yazar_ID, Y.KullaniciAdi, N.Baslik, N.Ozet, N.Icerik, N.EklenmeTarih, N.Durum FROM Notlar AS N JOIN Kategoriler AS K ON N.Kategori_ID = K.ID JOIN Yoneticiler AS Y ON N.Yazar_ID = Y.ID WHERE Durum = @durum";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Notlar nt = new Notlar();
                    nt.ID = reader.GetInt32(0);
                    nt.Kategori_ID = reader.GetInt32(1);
                    nt.Kategori = reader.GetString(2);
                    nt.Yazar_ID = reader.GetInt32(3);
                    nt.Yazar = reader.GetString(4);
                    nt.Baslik = reader.GetString(5);
                    nt.Ozet = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                    nt.Icerik = reader.GetString(7);
                    nt.EklenmeTarih = reader.GetDateTime(8);
                    nt.Durum = reader.GetBoolean(9);
                    ntt.Add(nt);
                }
                return ntt;
            }
            catch
            {  return null; }
            finally { con.Close(); }
        }

        public Notlar NotGetir(int id)
        {
            try
            {
                cmd.CommandText = "SELECT N.ID, N.Kategori_ID, K.Isim, N.Yazar_ID, Y.KullaniciAdi, N.Baslik, N.Ozet, N.Icerik, N.EklenmeTarih, N.Durum FROM Notlar AS N JOIN Kategoriler AS K ON N.Kategori_ID = K.ID JOIN Yoneticiler AS Y ON N.Yazar_ID = Y.ID WHERE N.ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Notlar nt = new Notlar();
                while(reader.Read())
                {
                    nt.ID = reader.GetInt32(0);
                    nt.Kategori_ID = reader.GetInt32(1);
                    nt.Kategori = reader.GetString(2);
                    nt.Yazar_ID = reader.GetInt32(3);
                    nt.Yazar = reader.GetString(4);
                    nt.Baslik = reader.GetString(5);
                    nt.Ozet = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                    nt.Icerik = reader.GetString(7);
                    nt.EklenmeTarih = reader.GetDateTime(8);
                    nt.Durum = reader.GetBoolean(9);

                }
                return nt;
            }
            catch { return null;}

            finally
            { con.Close(); }
        }

        public void NotDurum(int id)
        {
            try
            {
                cmd.CommandText = "SELECT Durum From Notlar WHERE ID =@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                bool durum = Convert.ToBoolean(cmd.ExecuteScalar());
                cmd.CommandText = "UPDATE Notlar SET Durum =@d WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@d", !durum);
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }

        public void NotSil(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Notlar WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }

        public bool NotDuzenle(Notlar V)
        {
            try
            {
                cmd.CommandText = "UPDATE Notlar SET Baslik =@baslik, Ozet=@ozet, Icerik=@icerik, Durum=@durum WHERE ID=@id ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", V.ID);
                cmd.Parameters.AddWithValue("@baslik", V.Baslik);
                cmd.Parameters.AddWithValue("@ozet", V.Ozet);
                cmd.Parameters.AddWithValue("@icerik", V.Icerik);
                cmd.Parameters.AddWithValue("@durum", V.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { con.Close(); }
        }

        #endregion
    }
}
