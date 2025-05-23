﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



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
            InitializeDateTimePicker();

            //this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.WindowState = FormWindowState.Normal;
            
        }

        private void InitializeDateTimePicker()
        {
            dateTime_dtarihi.Format = DateTimePickerFormat.Custom;
            dateTime_dtarihi.CustomFormat = "dd/MM/yyyy";

            dateTime_teklifTarihi.Format = DateTimePickerFormat.Custom;
            dateTime_teklifTarihi.CustomFormat = "dd/MM/yyyy";

            dateTime_policeBaslangic.Format = DateTimePickerFormat.Custom;
            dateTime_policeBaslangic.CustomFormat = "dd/MM/yyyy";

            dateTime_policeBitis.Format = DateTimePickerFormat.Custom;
            dateTime_policeBitis.CustomFormat = "dd/MM/yyyy";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbUrun.Items.AddRange(new string[] { "Kasko", "Trafik", "Sağlık", "Dask", "Konut", "Yangın", "Diğer" });
            cbOnay.Items.AddRange(new string[] { "Onaylandı", "Bekliyor", "Onaylanmadı" });

        }

        private void InitializeDataGridViewColumns()
        {
          /*dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("tcNo", "TC No");
            dataGridView1.Columns.Add("dogumTarihi", "Doğum Tarihi");
            dataGridView1.Columns.Add("plaka", "Plaka");
            dataGridView1.Columns.Add("belgeNo", "Belge No");
            dataGridView1.Columns.Add("urun", "Ürün");
            dataGridView1.Columns.Add("teklifTarihi", "Teklif Tarihi");
            dataGridView1.Columns.Add("policeBaslangic", "Poliçe Başlangıç");
            dataGridView1.Columns.Add("policeBitis", "Poliçe Bitiş");
            dataGridView1.Columns.Add("onayDurumu", "Onay Durumu"); */
        }

        private void LoadDataGridViewData()
        {
            dataGridView1.Rows.Clear();
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
            dataGridView1.Rows.Clear();

            if (plaka.Length > 0) 
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT tcNo, dogumTarihi, plaka, belgeNo, urun, teklifTarihi, policeBaslangic, policeBitis, onayDurumu " +
                                   "FROM policycheck " +
                                   "WHERE plaka LIKE @plakaFilter";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@plakaFilter", plaka + "%"); 

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
        }


        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Sadece sayı girişi yapabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // blocks character entry
                e.Handled = true;
            }

            
            if (txtTC.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string tcNo = txtTC.Text;
                string dogumTarihi = dateTime_dtarihi.Text;
                string plaka = txtPlaka.Text;
                string belgeNo = txtBelgeNo.Text;
                string urun = cbUrun.SelectedItem?.ToString();
                string teklifTarihi = dateTime_teklifTarihi.Text;
                string policeBaslangic = dateTime_policeBaslangic.Text;
                string policeBitis = dateTime_policeBitis.Text;
                string onayDurumu = cbOnay.SelectedItem?.ToString();

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

        private void txtTeklifTarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Sadece sayı girişi yapabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Handled = true;
            }


            if (txtTC.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPlakaSorgu_Click(object sender, EventArgs e)
        {
            LoadDataGridViewDataByPlaka(txtPlakaSorgu.Text);
        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            string plakaFilter = txtPlaka.Text.Trim();

            if (string.IsNullOrEmpty(plakaFilter))
            {

                LoadDataGridViewData(); 
            }
            else
            {
                LoadDataGridViewDataByPlaka(txtPlaka.Text.Trim());
            }
        }

     /* private void txtPoliceBaslangic_TextChanged(object sender, EventArgs e)
        {
            string cleanedText = txtPoliceBaslangic.Text.Replace("/", "");


            string formattedText = "";
            for (int i = 0; i < cleanedText.Length; i++)
            {
                if (char.IsDigit(cleanedText[i]))
                {
                    if (formattedText.Length == 2 || formattedText.Length == 5)
                    {
                        formattedText += "/";
                    }
                    formattedText += cleanedText[i];
                }
            }

            if (formattedText.Length > 11)
            {
                formattedText = formattedText.Substring(0, 10);
            }

            txtPoliceBaslangic.Text = formattedText;
            txtPoliceBaslangic.SelectionStart = formattedText.Length;
        }*/

      /*private void txtPoliceBitis_TextChanged(object sender, EventArgs e)
        {
            string cleanedText = txtPoliceBitis.Text.Replace("/", "");


            string formattedText = "";
            for (int i = 0; i < cleanedText.Length; i++)
            {
                if (char.IsDigit(cleanedText[i]))
                {
                    if (formattedText.Length == 2 || formattedText.Length == 5)
                    {
                        formattedText += "/";
                    }
                    formattedText += cleanedText[i];
                }
            }

            if (formattedText.Length > 11)
            {
                formattedText = formattedText.Substring(0, 10);
            }

            txtPoliceBitis.Text = formattedText;
            txtPoliceBitis.SelectionStart = formattedText.Length;
        }*/
    }
}
