using ADGV;
using DevExpress.XtraEditors;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = "server=127.0.0.1;user=root;password=ASHF#183SDfgh;database=policydb;";
        public Form2()
        {
            InitializeComponent();

            //this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            txtPlakaSorgu.TextChanged += txtPlakaSorgu_TextChanged; // Attach TextChanged event handler

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataGridViewData();
        }

        private void btnPlakaSorgu_Click(object sender, EventArgs e)
        {
            LoadDataGridViewDataByPlaka(txtPlakaSorgu.Text);
        }

        private void LoadDataGridViewData()
        {
            advancedDataGridView1.Rows.Clear();
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
                        row.CreateCells(advancedDataGridView1,
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
                        advancedDataGridView1.Rows.Add(row);
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
            advancedDataGridView1.Rows.Clear();

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
                            row.CreateCells(advancedDataGridView1,
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
                            advancedDataGridView1.Rows.Add(row);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string tcNo = txtTC.Text;
                string dogumTarihi = dateDt.Text;
                string plaka = txtPlaka.Text;
                string belgeNo = txtBelgeNo.Text;
                string urun = cbUrun.SelectedItem?.ToString();
                string teklifTarihi = dateTeklifTarihi.Text;
                string policeBaslangic = datePoliceBaslangic.Text;
                string policeBitis = datePoliceBitis.Text;
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

                advancedDataGridView1.Rows.Clear();
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

        private void txtPlakaSorgu_TextChanged(object sender, EventArgs e)
        {
            string plakaFilter = txtPlakaSorgu.Text.Trim();

            if (string.IsNullOrEmpty(plakaFilter))
            {
                LoadDataGridViewData();
            }
            else
            {
                LoadDataGridViewDataByPlaka(plakaFilter);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (advancedDataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "PDF_Raport.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter writer = PdfWriter.GetInstance(document, fileStream);

                            document.Open();

                            PdfPTable pTable = new PdfPTable(advancedDataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            
                            foreach (DataGridViewColumn col in advancedDataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }

                            /
                            foreach (DataGridViewRow viewRow in advancedDataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    string cellValue = dcell.Value != null ? dcell.Value.ToString() : "";
                                    pTable.AddCell(cellValue);
                                }
                            }

                            
                            document.Add(pTable);

                            document.Close();
                            fileStream.Close();

                            MessageBox.Show("PDF Başarılı Şekilde Kaydedildi");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu :( " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı", "Info");
            }
        }
    }
}