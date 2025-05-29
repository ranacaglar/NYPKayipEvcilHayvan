using System;

using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıpEvcilHayvanTakipSistemi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            string adSoyad = txtAdSoyad.Text;
            string telefon = txtTelefon.Text;
            string eposta = txtEposta.Text;

            string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Sahipler (AdSoyad, Telefon, Eposta) VALUES (@AdSoyad, @Telefon, @Eposta)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);
                    cmd.Parameters.AddWithValue("@Telefon", telefon);
                    cmd.Parameters.AddWithValue("@Eposta", eposta);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    
                }

                MessageBox.Show("Sahip başarıyla kaydedildi!");

                ListeleSahipler();
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ListeleSahipler();
            ListeleHayvanlar();
            ListeleIlanlar();

            cmbCinsiyet.Items.Clear();
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Dişi");


            string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string querySahipler = "SELECT SahipID, AdSoyad FROM Sahipler";
                SqlDataAdapter da = new SqlDataAdapter(querySahipler, conn);
                DataTable dtSahipler = new DataTable();
                da.Fill(dtSahipler);

                cmbSahip.DataSource = dtSahipler;
                cmbSahip.DisplayMember = "AdSoyad";
                cmbSahip.ValueMember = "SahipID";

                
                string queryHayvanlar = "SELECT HayvanID, Ad FROM Hayvanlar";
                SqlDataAdapter daHayvan = new SqlDataAdapter(queryHayvanlar, conn);
                DataTable dtHayvanlar = new DataTable();
                daHayvan.Fill(dtHayvanlar);

                cmbHayvanlar.DataSource = dtHayvanlar;
                cmbHayvanlar.DisplayMember = "Ad";
                cmbHayvanlar.ValueMember = "HayvanID";

                
            }
        }

        private void btnHayvanKaydet_Click(object sender, EventArgs e)
        {
            
            string ad = txtHayvanAd.Text;
            string tur = txtTur.Text;
            string cins = txtCins.Text;
            string renk = txtRenk.Text;
            string cinsiyet = cmbCinsiyet.SelectedItem?.ToString() ?? "";
            DateTime kaybolmaTarihi = dtpKaybolma.Value;
            int sahipID = Convert.ToInt32(cmbSahip.SelectedValue);

            string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Hayvanlar (Ad, Tur, Cins, Renk, Cinsiyet, KaybolmaTarihi, SahipID) " +
                                   "VALUES (@Ad, @Tur, @Cins, @Renk, @Cinsiyet, @KaybolmaTarihi, @SahipID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Tur", tur);
                    cmd.Parameters.AddWithValue("@Cins", cins);
                    cmd.Parameters.AddWithValue("@Renk", renk);
                    cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@KaybolmaTarihi", kaybolmaTarihi);
                    cmd.Parameters.AddWithValue("@SahipID", sahipID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                }

                MessageBox.Show("Hayvan başarıyla kaydedildi!");

                ListeleHayvanlar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }

        }

        private void cmbHayvanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT HayvanID, Ad FROM Hayvanlar";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbHayvanlar.DisplayMember = "Ad";
                cmbHayvanlar.ValueMember = "HayvanID";
                
            }
        }

        private void btnIlanKaydet_Click(object sender, EventArgs e)
        {
            
            string aciklama = txtAciklama.Text;
            int hayvanID = Convert.ToInt32(cmbHayvanlar.SelectedValue);
            DateTime ilanTarihi = DateTime.Now; 

            string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Ilanlar (Aciklama, HayvanID, IlanTarihi) VALUES (@Aciklama, @HayvanID, @IlanTarihi)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Aciklama", aciklama);
                    cmd.Parameters.AddWithValue("@HayvanID", hayvanID);
                    cmd.Parameters.AddWithValue("@IlanTarihi", ilanTarihi);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("İlan başarıyla kaydedildi!");

                ListeleIlanlar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void grpIlan_Enter(object sender, EventArgs e)
        {

        }


        private void ListeleSahipler()
        {

            string connectionString = @"Data Source=DESKTOP-AJNP9HE\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SahipID, AdSoyad, Telefon, Eposta FROM Sahipler";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSahipler.AutoGenerateColumns = true;  
                dataGridViewSahipler.DataSource = dt;

                cmbSahip.DataSource = dt;
                cmbSahip.DisplayMember = "AdSoyad";
                cmbSahip.ValueMember = "SahipID";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewSahipler.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dataGridViewSahipler.SelectedRows[0].Cells["SahipID"].Value);

                string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Sahipler WHERE SahipID = @SahipID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SahipID", secilenID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Kayıt silindi!");
                    ListeleSahipler();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewHayvanlar.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dataGridViewHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);

                string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Hayvanlar WHERE HayvanID = @HayvanID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@HayvanID", secilenID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Hayvan silindi!");
                    ListeleHayvanlar();
                }
            }
            else
            {
                MessageBox.Show("Silinecek hayvanı seç tatlım!");
            }
        }

        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewIlanlar.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dataGridViewIlanlar.SelectedRows[0].Cells["IlanID"].Value);

                string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Ilanlar WHERE IlanID = @IlanID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IlanID", secilenID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("İlan silindi!");
                    ListeleIlanlar(); 
                }
            }
            else
            {
                MessageBox.Show("Silinecek ilanı seç canım!");
            }
        }

        private void ListeleHayvanlar()
        {
            string connectionString = @"Data Source=DESKTOP-AJNP9HE\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT HayvanID, Ad, Cinsiyet, Tur, Renk, Cins FROM Hayvanlar";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewHayvanlar.DataSource = dt;

                cmbHayvanlar.DataSource = dt;
                cmbHayvanlar.DisplayMember = "Ad";
                cmbHayvanlar.ValueMember = "HayvanID";
            }
        }


        private void ListeleIlanlar()
        {
            string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IlanID, HayvanID, IlanTarihi, Aciklama FROM Ilanlar";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewIlanlar.DataSource = dt;
            }
        }


       

        private void dataGridViewSahipler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridViewSahipler.Rows[e.RowIndex];

                
                txtAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEposta.Text = row.Cells["Eposta"].Value.ToString();
            }
        }

        private void btnGuncelleSahip_Click(object sender, EventArgs e)
        {
            if (dataGridViewSahipler.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dataGridViewSahipler.SelectedRows[0].Cells["SahipID"].Value);
                string yeniAdSoyad = txtAdSoyad.Text;
                string yeniTelefon = txtTelefon.Text;

                string connectionString = @"Data Source=DESKTOP-AJNP9HE\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Sahipler SET AdSoyad = @AdSoyad, Telefon = @Telefon WHERE SahipID = @SahipID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AdSoyad", yeniAdSoyad);
                    cmd.Parameters.AddWithValue("@Telefon", yeniTelefon);
                    cmd.Parameters.AddWithValue("@SahipID", secilenID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Sahip başarıyla güncellendi!");
                ListeleSahipler();
            }
            else
            {
                MessageBox.Show("Lütfen bir sahip seçin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridViewIlanlar.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dataGridViewIlanlar.SelectedRows[0].Cells["IlanID"].Value);
                int yeniHayvanID = Convert.ToInt32(cmbHayvanlar.SelectedValue);
                string yeniAciklama = txtAciklama.Text;
                DateTime yeniTarih = dtpIlanTarihi.Value;

                string connectionString = "Data Source=DESKTOP-AJNP9HE\\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Ilanlar SET HayvanID = @HayvanID, Aciklama = @Aciklama, IlanTarihi = @IlanTarihi WHERE IlanID = @IlanID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@HayvanID", yeniHayvanID);
                    cmd.Parameters.AddWithValue("@Aciklama", yeniAciklama);
                    cmd.Parameters.AddWithValue("@IlanTarihi", yeniTarih);
                    cmd.Parameters.AddWithValue("@IlanID", secilenID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("İlan başarıyla güncellendi!");
                ListeleIlanlar();
            }
            else
            {
                MessageBox.Show("Lütfen bir ilan seçin");
            }
        }


        private void btnGuncelleHayvan_Click(object sender, EventArgs e)
        {
            if (dataGridViewHayvanlar.SelectedRows.Count > 0)
            {
                int secilenID = Convert.ToInt32(dataGridViewHayvanlar.SelectedRows[0].Cells["HayvanID"].Value);
                string yeniAd = txtHayvanAd.Text;

                string connectionString = @"Data Source=DESKTOP-AJNP9HE\SQLEXPRESS;Initial Catalog=EvcilHayvanDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Hayvanlar SET Ad = @Ad WHERE HayvanID = @HayvanID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ad", yeniAd);
                    cmd.Parameters.AddWithValue("@HayvanID", secilenID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Hayvan başarıyla güncellendi!");
                ListeleHayvanlar();
            }
            else
            {
                MessageBox.Show("Lütfen bir hayvan seçin");
            }
        }

        private void dataGridViewHayvanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHayvanlar.Rows[e.RowIndex];

                txtHayvanAd.Text = row.Cells["Ad"].Value?.ToString() ?? "";
                cmbCinsiyet.Text = row.Cells["Cinsiyet"].Value?.ToString() ?? "";
                txtTur.Text = row.Cells["Tur"].Value?.ToString() ?? "";
                txtRenk.Text = row.Cells["Renk"].Value?.ToString() ?? "";
                txtCins.Text = row.Cells["Cins"].Value?.ToString() ?? "";
            }
        }

        private void dataGridViewIlanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewIlanlar.Rows[e.RowIndex];
                cmbHayvanlar.SelectedValue = Convert.ToInt32(row.Cells["HayvanID"].Value);
                txtAciklama.Text = row.Cells["Aciklama"].Value.ToString();
                dtpIlanTarihi.Value = Convert.ToDateTime(row.Cells["IlanTarihi"].Value);
            }
        }

        private void cmbSahip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSahipler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
