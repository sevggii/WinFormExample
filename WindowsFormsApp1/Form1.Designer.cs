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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnControl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtBelgeNo = new System.Windows.Forms.TextBox();
            this.cbUrun = new System.Windows.Forms.ComboBox();
            this.cbOnay = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlakaSorgu = new System.Windows.Forms.TextBox();
            this.btnPlakaSorgu = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dateTime_policeBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTime_dtarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTime_teklifTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTime_policeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teklifTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.police_baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.police_bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onay_durumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnControl.Location = new System.Drawing.Point(643, 82);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(122, 37);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "KONTROL";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plaka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Belge No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürün:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teklif Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Poliçe Başlangıç Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Poliçe Bitiş Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Onay Durumu:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(92, 62);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(96, 20);
            this.txtTC.TabIndex = 10;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(92, 121);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(96, 20);
            this.txtPlaka.TabIndex = 12;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(291, 61);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(94, 20);
            this.txtBelgeNo.TabIndex = 13;
            // 
            // cbUrun
            // 
            this.cbUrun.FormattingEnabled = true;
            this.cbUrun.Location = new System.Drawing.Point(291, 89);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Size = new System.Drawing.Size(95, 21);
            this.cbUrun.TabIndex = 14;
            // 
            // cbOnay
            // 
            this.cbOnay.FormattingEnabled = true;
            this.cbOnay.Location = new System.Drawing.Point(524, 120);
            this.cbOnay.Name = "cbOnay";
            this.cbOnay.Size = new System.Drawing.Size(97, 21);
            this.cbOnay.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(839, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "PLAKA:";
            // 
            // txtPlakaSorgu
            // 
            this.txtPlakaSorgu.Location = new System.Drawing.Point(813, 82);
            this.txtPlakaSorgu.Name = "txtPlakaSorgu";
            this.txtPlakaSorgu.Size = new System.Drawing.Size(100, 20);
            this.txtPlakaSorgu.TabIndex = 21;
            this.txtPlakaSorgu.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // btnPlakaSorgu
            // 
            this.btnPlakaSorgu.BackColor = System.Drawing.Color.White;
            this.btnPlakaSorgu.Location = new System.Drawing.Point(825, 108);
            this.btnPlakaSorgu.Name = "btnPlakaSorgu";
            this.btnPlakaSorgu.Size = new System.Drawing.Size(75, 23);
            this.btnPlakaSorgu.TabIndex = 22;
            this.btnPlakaSorgu.Text = "SORGULA";
            this.btnPlakaSorgu.UseVisualStyleBackColor = false;
            this.btnPlakaSorgu.Click += new System.EventHandler(this.btnPlakaSorgu_Click);
            // 
            // dateTime_policeBitis
            // 
            this.dateTime_policeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_policeBitis.Location = new System.Drawing.Point(524, 90);
            this.dateTime_policeBitis.Name = "dateTime_policeBitis";
            this.dateTime_policeBitis.Size = new System.Drawing.Size(97, 20);
            this.dateTime_policeBitis.TabIndex = 33;
            // 
            // dateTime_dtarihi
            // 
            this.dateTime_dtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_dtarihi.Location = new System.Drawing.Point(92, 94);
            this.dateTime_dtarihi.Name = "dateTime_dtarihi";
            this.dateTime_dtarihi.Size = new System.Drawing.Size(96, 20);
            this.dateTime_dtarihi.TabIndex = 34;
            // 
            // dateTime_teklifTarihi
            // 
            this.dateTime_teklifTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_teklifTarihi.Location = new System.Drawing.Point(291, 119);
            this.dateTime_teklifTarihi.Name = "dateTime_teklifTarihi";
            this.dateTime_teklifTarihi.Size = new System.Drawing.Size(95, 20);
            this.dateTime_teklifTarihi.TabIndex = 35;
            // 
            // dateTime_policeBaslangic
            // 
            this.dateTime_policeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_policeBaslangic.Location = new System.Drawing.Point(524, 59);
            this.dateTime_policeBaslangic.Name = "dateTime_policeBaslangic";
            this.dateTime_policeBaslangic.Size = new System.Drawing.Size(97, 20);
            this.dateTime_policeBaslangic.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-2, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 326);
            this.panel1.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(179)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(179)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tc_no,
            this.dtarihi,
            this.plaka,
            this.belgeNo,
            this.urun,
            this.teklifTarihi,
            this.police_baslangic,
            this.police_bitis,
            this.onay_durumu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(179)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 320);
            this.dataGridView1.TabIndex = 19;
            // 
            // tc_no
            // 
            this.tc_no.HeaderText = "TC Kimlik No";
            this.tc_no.Name = "tc_no";
            this.tc_no.ReadOnly = true;
            // 
            // dtarihi
            // 
            this.dtarihi.HeaderText = "Doğum Tarihi";
            this.dtarihi.Name = "dtarihi";
            this.dtarihi.ReadOnly = true;
            // 
            // plaka
            // 
            this.plaka.HeaderText = "Plaka";
            this.plaka.Name = "plaka";
            this.plaka.ReadOnly = true;
            // 
            // belgeNo
            // 
            this.belgeNo.HeaderText = "Belge No";
            this.belgeNo.Name = "belgeNo";
            this.belgeNo.ReadOnly = true;
            // 
            // urun
            // 
            this.urun.HeaderText = "Ürün";
            this.urun.Name = "urun";
            this.urun.ReadOnly = true;
            // 
            // teklifTarihi
            // 
            this.teklifTarihi.HeaderText = "Teklif Tarihi";
            this.teklifTarihi.Name = "teklifTarihi";
            this.teklifTarihi.ReadOnly = true;
            // 
            // police_baslangic
            // 
            this.police_baslangic.HeaderText = "Poliçe Başlangıç Tarihi";
            this.police_baslangic.Name = "police_baslangic";
            this.police_baslangic.ReadOnly = true;
            // 
            // police_bitis
            // 
            this.police_bitis.HeaderText = "Police Bitiş Tarihi";
            this.police_bitis.Name = "police_bitis";
            this.police_bitis.ReadOnly = true;
            // 
            // onay_durumu
            // 
            this.onay_durumu.HeaderText = "Onay Durumu";
            this.onay_durumu.Name = "onay_durumu";
            this.onay_durumu.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTime_policeBaslangic);
            this.Controls.Add(this.dateTime_teklifTarihi);
            this.Controls.Add(this.dateTime_dtarihi);
            this.Controls.Add(this.dateTime_policeBitis);
            this.Controls.Add(this.btnPlakaSorgu);
            this.Controls.Add(this.txtPlakaSorgu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbOnay);
            this.Controls.Add(this.cbUrun);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORGU SAYFASI";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtBelgeNo;
        private System.Windows.Forms.ComboBox cbUrun;
        private System.Windows.Forms.ComboBox cbOnay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPlakaSorgu;
        private System.Windows.Forms.Button btnPlakaSorgu;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DateTimePicker dateTime_policeBitis;
        private System.Windows.Forms.DateTimePicker dateTime_dtarihi;
        private System.Windows.Forms.DateTimePicker dateTime_teklifTarihi;
        private System.Windows.Forms.DateTimePicker dateTime_policeBaslangic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn plaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn teklifTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn police_baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn police_bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn onay_durumu;
    }
}

