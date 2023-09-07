using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class FirstCustomControl : UserControl
    {
        private string connectionString = "server=127.0.0.1;user=root;password=ASHF#183SDfgh;database=policydb;";
        public FirstCustomControl()
        {
            InitializeComponent();

            txtPlakaSorgu.TextChanged += txtPlakaSorgu_TextChanged; // Attach TextChanged event handler

            dateDt.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            dateDt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;

            datePoliceBaslangic.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            datePoliceBaslangic.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            datePoliceBitis.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            datePoliceBitis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
        }

        private void FirstControl_Load(object sender, EventArgs e)
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
                string query = "SELECT tcNo, dogumTarihi, plaka, belgeNo, urun, teklifTarihi, policeBaslangic, policeBitis, onayDurumu FROM policycheck ORDER BY policeBaslangic DESC";

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
                                   "WHERE plaka LIKE @plakaFilter " +
                                   "ORDER BY policeBaslangic DESC";


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
                save.FileName = "Report.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(PageSize.A4.Rotate());

                            Document document = new Document(pageSize, 10f, 10f, 10f, 10f);

                            PdfWriter writer = PdfWriter.GetInstance(document, fileStream);

                            document.Open();

                            PdfPTable pTable = new PdfPTable(advancedDataGridView1.Columns.Count);
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            string fontPath = "C:\\Windows\\Fonts\\arial.ttf";
                            iTextSharp.text.pdf.BaseFont baseFont = iTextSharp.text.pdf.BaseFont.CreateFont(fontPath, iTextSharp.text.pdf.BaseFont.IDENTITY_H, iTextSharp.text.pdf.BaseFont.EMBEDDED);

                            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

                            pTable.SpacingBefore = 10f;
                            pTable.SpacingAfter = 10f;

                            foreach (DataGridViewColumn col in advancedDataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, font));
                                pCell.HorizontalAlignment = Element.ALIGN_LEFT;
                                pCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pCell.PaddingTop = 10f;
                                pCell.PaddingBottom = 10f;
                                pCell.Border = PdfPCell.BOTTOM_BORDER;
                                pTable.AddCell(pCell);
                            }

                            foreach (DataGridViewRow viewRow in advancedDataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    string cellValue = "";
                                    if (dcell.Value != null)
                                    {
                                        if (dcell.Value is DateTime)
                                        {
                                            DateTime dateTime = (DateTime)dcell.Value;
                                            cellValue = dateTime.ToString("dd/MM/yyyy");
                                        }
                                        else
                                        {
                                            cellValue = dcell.Value.ToString();
                                        }
                                    }

                                    PdfPCell cell = new PdfPCell(new Phrase(cellValue, font));
                                    cell.HorizontalAlignment = Element.ALIGN_LEFT;
                                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    cell.PaddingTop = 10f;
                                    cell.PaddingBottom = 10f;
                                    cell.Border = PdfPCell.BOTTOM_BORDER;
                                    pTable.AddCell(cell);
                                }
                            }

                            float[] widths = new float[advancedDataGridView1.Columns.Count];
                            for (int i = 0; i < advancedDataGridView1.Columns.Count; i++)
                            {
                                widths[i] = 2f;
                            }
                            pTable.SetWidths(widths);

                            document.Add(pTable);

                            document.Close();
                            fileStream.Close();

                            System.Diagnostics.Process.Start(save.FileName);
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
                MessageBox.Show("Kayıt Bulunamadı", "Bilgi");
            }
        }


        private void advancedDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 1 || e.ColumnIndex == 1) //dogumTarihi
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    if (e.Value is DateTime)
                    {
                        DateTime dateTime = (DateTime)e.Value;
                        e.Value = dateTime.ToString("dd/MM/yyyy");
                        e.FormattingApplied = true;
                    }
                }
            }


            if (e.ColumnIndex == 5 || e.ColumnIndex == 5) //teklifTarihi
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    if (e.Value is DateTime)
                    {
                        DateTime dateTime = (DateTime)e.Value;
                        e.Value = dateTime.ToString("dd/MM/yyyy");
                        e.FormattingApplied = true;
                    }
                }
            }


            if (e.ColumnIndex == 6 || e.ColumnIndex == 6) //policeBaslangic
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    if (e.Value is DateTime)
                    {
                        DateTime dateTime = (DateTime)e.Value;
                        e.Value = dateTime.ToString("dd/MM/yyyy");
                        e.FormattingApplied = true;
                    }
                }
            }


            if (e.ColumnIndex == 7 || e.ColumnIndex == 7) //policeBitis
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    if (e.Value is DateTime)
                    {
                        DateTime dateTime = (DateTime)e.Value;
                        e.Value = dateTime.ToString("dd/MM/yyyy");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void txtBelgeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Accept only numbers and control keys (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// Reject keystroke
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
