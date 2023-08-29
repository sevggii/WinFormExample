namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.txt_belge = new System.Windows.Forms.TextBox();
            this.cb_urun = new System.Windows.Forms.ComboBox();
            this.cb_onay = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_plaka_sorgu = new System.Windows.Forms.TextBox();
            this.btn_plaka_sorgu = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.dateTime_teklif = new System.Windows.Forms.DateTimePicker();
            this.dateTime_policeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTime_policeBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTime_dogumTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(999, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "KONTROL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plaka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Belge No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürün";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teklif Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Poliçe Başlangıç Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Poliçe Bitiş Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Onay Durumu";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(152, 65);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(140, 20);
            this.txt_tc.TabIndex = 10;
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(152, 120);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(140, 20);
            this.txt_plaka.TabIndex = 12;
            // 
            // txt_belge
            // 
            this.txt_belge.Location = new System.Drawing.Point(457, 61);
            this.txt_belge.Name = "txt_belge";
            this.txt_belge.Size = new System.Drawing.Size(200, 20);
            this.txt_belge.TabIndex = 13;
            // 
            // cb_urun
            // 
            this.cb_urun.FormattingEnabled = true;
            this.cb_urun.Location = new System.Drawing.Point(457, 89);
            this.cb_urun.Name = "cb_urun";
            this.cb_urun.Size = new System.Drawing.Size(201, 21);
            this.cb_urun.TabIndex = 14;
            // 
            // cb_onay
            // 
            this.cb_onay.FormattingEnabled = true;
            this.cb_onay.Location = new System.Drawing.Point(793, 120);
            this.cb_onay.Name = "cb_onay";
            this.cb_onay.Size = new System.Drawing.Size(200, 21);
            this.cb_onay.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 450);
            this.dataGridView1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1099, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "PLAKA:";
            // 
            // txt_plaka_sorgu
            // 
            this.txt_plaka_sorgu.Location = new System.Drawing.Point(1076, 249);
            this.txt_plaka_sorgu.Name = "txt_plaka_sorgu";
            this.txt_plaka_sorgu.Size = new System.Drawing.Size(100, 20);
            this.txt_plaka_sorgu.TabIndex = 21;
            // 
            // btn_plaka_sorgu
            // 
            this.btn_plaka_sorgu.Location = new System.Drawing.Point(1086, 275);
            this.btn_plaka_sorgu.Name = "btn_plaka_sorgu";
            this.btn_plaka_sorgu.Size = new System.Drawing.Size(75, 23);
            this.btn_plaka_sorgu.TabIndex = 22;
            this.btn_plaka_sorgu.Text = "SORGULA";
            this.btn_plaka_sorgu.UseVisualStyleBackColor = true;
            this.btn_plaka_sorgu.Click += new System.EventHandler(this.btn_plaka_sorgu_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(1015, 178);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(121, 21);
            this.cb_filter.TabIndex = 23;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(1142, 176);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 24;
            this.btn_filter.Text = "FİLTRELE";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // dateTime_teklif
            // 
            this.dateTime_teklif.Location = new System.Drawing.Point(457, 124);
            this.dateTime_teklif.Name = "dateTime_teklif";
            this.dateTime_teklif.Size = new System.Drawing.Size(200, 20);
            this.dateTime_teklif.TabIndex = 25;
            // 
            // dateTime_policeBaslangic
            // 
            this.dateTime_policeBaslangic.Location = new System.Drawing.Point(793, 66);
            this.dateTime_policeBaslangic.Name = "dateTime_policeBaslangic";
            this.dateTime_policeBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dateTime_policeBaslangic.TabIndex = 26;
            // 
            // dateTime_policeBitis
            // 
            this.dateTime_policeBitis.Location = new System.Drawing.Point(793, 94);
            this.dateTime_policeBitis.Name = "dateTime_policeBitis";
            this.dateTime_policeBitis.Size = new System.Drawing.Size(200, 20);
            this.dateTime_policeBitis.TabIndex = 27;
            // 
            // dateTime_dogumTarihi
            // 
            this.dateTime_dogumTarihi.Location = new System.Drawing.Point(152, 89);
            this.dateTime_dogumTarihi.Name = "dateTime_dogumTarihi";
            this.dateTime_dogumTarihi.Size = new System.Drawing.Size(140, 20);
            this.dateTime_dogumTarihi.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 727);
            this.Controls.Add(this.dateTime_dogumTarihi);
            this.Controls.Add(this.dateTime_policeBitis);
            this.Controls.Add(this.dateTime_policeBaslangic);
            this.Controls.Add(this.dateTime_teklif);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.btn_plaka_sorgu);
            this.Controls.Add(this.txt_plaka_sorgu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_onay);
            this.Controls.Add(this.cb_urun);
            this.Controls.Add(this.txt_belge);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Windows.Forms.TextBox txt_belge;
        private System.Windows.Forms.ComboBox cb_urun;
        private System.Windows.Forms.ComboBox cb_onay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_plaka_sorgu;
        private System.Windows.Forms.Button btn_plaka_sorgu;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DateTimePicker dateTime_teklif;
        private System.Windows.Forms.DateTimePicker dateTime_policeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTime_policeBitis;
        private System.Windows.Forms.DateTimePicker dateTime_dogumTarihi;
    }
}

