using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=127.0.0.1;user=root;password=ASHF#183SDfgh;database=policydb;";

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();
            LoadDataGridViewData();

           cb_filter.Items.AddRange(new string[] { "Last 7 Days", "Last 10 Days", "Last 30 Days" });
            cb_filter.SelectedIndex = 0;

        }

        private void InitializeDataGridViewColumns()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("tcNo", "TC No");
            dataGridView1.Columns.Add("dogumTarihi", "Doğum Tarihi");
            dataGridView1.Columns.Add("plaka", "Plaka");
            dataGridView1.Columns.Add("belgeNo", "Belge No");
            dataGridView1.Columns.Add("urun", "Ürün");
            dataGridView1.Columns.Add("teklifTarihi", "Teklif Tarihi");
            dataGridView1.Columns.Add("policeBaslangic", "Poliçe Başlangıç");
            dataGridView1.Columns.Add("policeBitis", "Poliçe Bitiş");
            dataGridView1.Columns.Add("onayDurumu", "Onay Durumu");
        }

        private void LoadDataGridViewData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT tcNo, dogumTarihi, plaka, belgeNo, urun, teklifTarihi, policeBaslangic, policeBitis, onayDurumu FROM policycheck";

                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1,
                            reader["tcNo"],
                            reader["dogumTarihi"],
                            reader["plaka"],
                            reader["belgeNo"],
                            reader["urun"],
                            reader["teklifTarihi"],
                            reader["policeBaslangic"],
                            reader["policeBitis"],
                            reader["onayDurumu"]
                        );
                        dataGridView1.Rows.Add(row);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadDataGridViewDataByPlaka(string plaka)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT tcNo, dogumTarihi, plaka, belgeNo, urun, teklifTarihi, policeBaslangic, policeBitis, onayDurumu " +
                               "FROM policycheck " +
                               "WHERE plaka = @plaka";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@plaka", plaka);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1,
                            reader["tcNo"],
                            reader["dogumTarihi"],
                            reader["plaka"],
                            reader["belgeNo"],
                            reader["urun"],
                            reader["teklifTarihi"],
                            reader["policeBaslangic"],
                            reader["policeBitis"],
                            reader["onayDurumu"]
                        );
                        dataGridView1.Rows.Add(row);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadDataGridViewDataByDateRange(DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT tcNo, dogumTarihi, plaka, belgeNo, urun, teklifTarihi, policeBaslangic, policeBitis, onayDurumu " +
                               "FROM policycheck " +
                               "WHERE teklifTarihi >= @startDate AND teklifTarihi <= @endDate";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1,
                            reader["tcNo"],
                            reader["dogumTarihi"],
                            reader["plaka"],
                            reader["belgeNo"],
                            reader["urun"],
                            reader["teklifTarihi"],
                            reader["policeBaslangic"],
                            reader["policeBitis"],
                            reader["onayDurumu"]
                        );
                        dataGridView1.Rows.Add(row);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cb_urun.Items.AddRange(new string[] { "Kasko", "Trafik", "Sağlık", "Dask", "Konut", "Yangın", "Diğer" });
            cb_onay.Items.AddRange(new string[] { "Onaylandı", "Bekliyor", "Onaylanmadı" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string tcNo = txt_tc.Text;
                string dogumTarihi =dateTime_dogumTarihi.Text;
                string plaka = txt_plaka.Text;
                string belgeNo = txt_belge.Text;
                string urun = cb_urun.SelectedItem?.ToString();
                string teklifTarihi = dateTime_teklif.Text;
                string policeBaslangic = dateTime_policeBaslangic.Text;
                string policeBitis = dateTime_policeBitis.Text;
                string onayDurumu = cb_onay.SelectedItem?.ToString();

                string query = "INSERT INTO policycheck (tcNo, dogumTarihi,plaka,belgeNo,urun,teklifTarihi,policeBaslangic,policeBitis,onayDurumu) " +
                    "VALUES (@tcNo, @dogumTarihi, @plaka, @belgeNo, @urun, @teklifTarihi, @policeBaslangic, @policeBitis, @onayDurumu)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@tcNo", tcNo);
                cmd.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                cmd.Parameters.AddWithValue("@plaka", plaka);
                cmd.Parameters.AddWithValue("@belgeNo", belgeNo);
                cmd.Parameters.AddWithValue("@urun", urun);
                cmd.Parameters.AddWithValue("@teklifTarihi", teklifTarihi);
                cmd.Parameters.AddWithValue("@policeBaslangic", policeBaslangic);
                cmd.Parameters.AddWithValue("@policeBitis", policeBitis);
                cmd.Parameters.AddWithValue("@onayDurumu", onayDurumu);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Veri Başarıyla Eklendi!");

                dataGridView1.Rows.Clear();
                LoadDataGridViewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_plaka_sorgu_Click(object sender, EventArgs e)
        {
            LoadDataGridViewDataByPlaka(txt_plaka_sorgu.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            string selectedOption = cb_filter.SelectedItem.ToString();
            int days;

            switch (selectedOption)
            {
                case "Last 7 Days":
                    days = 7;
                    break;
                case "Last 10 Days":
                    days = 10;
                    break;
                case "Last 30 Days":
                    days = 30;
                    break;
                default:
                    return; // Invalid option, do nothing
            }

            FilterDataByDays(days);
        }

        private void FilterDataByDays(int days)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT tcNo, dogumTarihi, plaka, belgeNo, urun, teklifTarihi, policeBaslangic, policeBitis, onayDurumu " +
                               "FROM policycheck " +
                               "WHERE teklifTarihi >= DATE_SUB(NOW(), INTERVAL @days DAY)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@days", days);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1,
                            reader["tcNo"],
                            reader["dogumTarihi"],
                            reader["plaka"],
                            reader["belgeNo"],
                            reader["urun"],
                            reader["teklifTarihi"],
                            reader["policeBaslangic"],
                            reader["policeBitis"],
                            reader["onayDurumu"]
                        );
                        dataGridView1.Rows.Add(row);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
