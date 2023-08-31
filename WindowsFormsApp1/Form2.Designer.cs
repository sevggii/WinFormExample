namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnPlakaSorgu = new DevExpress.XtraEditors.SimpleButton();
            this.txtPlakaSorgu = new DevExpress.XtraEditors.TextEdit();
            this.datePoliceBitis = new DevExpress.XtraEditors.DateEdit();
            this.datePoliceBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.dateTeklifTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.dateDt = new DevExpress.XtraEditors.DateEdit();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cbUrun = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbOnay = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlakaSorgu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTeklifTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTeklifTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOnay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Plaka :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Belge No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Teklif Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Poliçe Başlangıç Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Poliçe Bitiş Tarihi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Onay Durumu :";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(237)))));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(171)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(838, 283);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Plaka :";
            // 
            // btnPlakaSorgu
            // 
            this.btnPlakaSorgu.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.lookup_reference_16x16;
            this.btnPlakaSorgu.Location = new System.Drawing.Point(160, 12);
            this.btnPlakaSorgu.Name = "btnPlakaSorgu";
            this.btnPlakaSorgu.Size = new System.Drawing.Size(57, 23);
            this.btnPlakaSorgu.TabIndex = 26;
            this.btnPlakaSorgu.Text = "ARA";
            this.btnPlakaSorgu.Click += new System.EventHandler(this.btnPlakaSorgu_Click);
            // 
            // txtPlakaSorgu
            // 
            this.txtPlakaSorgu.Location = new System.Drawing.Point(54, 14);
            this.txtPlakaSorgu.Name = "txtPlakaSorgu";
            this.txtPlakaSorgu.Size = new System.Drawing.Size(100, 20);
            this.txtPlakaSorgu.TabIndex = 25;
            // 
            // datePoliceBitis
            // 
            this.datePoliceBitis.EditValue = null;
            this.datePoliceBitis.Location = new System.Drawing.Point(610, 117);
            this.datePoliceBitis.Name = "datePoliceBitis";
            this.datePoliceBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePoliceBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePoliceBitis.Properties.MaskSettings.Set("mask", "d");
            this.datePoliceBitis.Size = new System.Drawing.Size(100, 20);
            this.datePoliceBitis.TabIndex = 22;
            // 
            // datePoliceBaslangic
            // 
            this.datePoliceBaslangic.EditValue = null;
            this.datePoliceBaslangic.Location = new System.Drawing.Point(610, 94);
            this.datePoliceBaslangic.Name = "datePoliceBaslangic";
            this.datePoliceBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePoliceBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePoliceBaslangic.Properties.MaskSettings.Set("mask", "d");
            this.datePoliceBaslangic.Size = new System.Drawing.Size(100, 20);
            this.datePoliceBaslangic.TabIndex = 21;
            // 
            // dateTeklifTarihi
            // 
            this.dateTeklifTarihi.EditValue = null;
            this.dateTeklifTarihi.Location = new System.Drawing.Point(362, 140);
            this.dateTeklifTarihi.Name = "dateTeklifTarihi";
            this.dateTeklifTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTeklifTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTeklifTarihi.Properties.MaskSettings.Set("mask", "d");
            this.dateTeklifTarihi.Size = new System.Drawing.Size(100, 20);
            this.dateTeklifTarihi.TabIndex = 20;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(362, 94);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(100, 20);
            this.txtBelgeNo.TabIndex = 14;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(172, 144);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 13;
            // 
            // dateDt
            // 
            this.dateDt.EditValue = null;
            this.dateDt.Location = new System.Drawing.Point(172, 117);
            this.dateDt.Name = "dateDt";
            this.dateDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDt.Properties.MaskSettings.Set("mask", "d");
            this.dateDt.Size = new System.Drawing.Size(100, 20);
            this.dateDt.TabIndex = 12;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(172, 94);
            this.txtTC.Name = "txtTC";
            this.txtTC.Properties.MaxLength = 11;
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.add_16x16;
            this.btnAdd.Location = new System.Drawing.Point(362, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "KAYIT EKLE";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbUrun
            // 
            this.cbUrun.Location = new System.Drawing.Point(362, 117);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUrun.Properties.Items.AddRange(new object[] {
            "Kasko",
            "Trafik",
            "Sağlık",
            "Dask",
            "Konut",
            "Yangın",
            "Diğer"});
            this.cbUrun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbUrun.Size = new System.Drawing.Size(100, 20);
            this.cbUrun.TabIndex = 27;
            // 
            // cbOnay
            // 
            this.cbOnay.Location = new System.Drawing.Point(610, 140);
            this.cbOnay.Name = "cbOnay";
            this.cbOnay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOnay.Properties.Items.AddRange(new object[] {
            "Onaylandı",
            "Bekliyor",
            "Onaylanmadı"});
            this.cbOnay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbOnay.Size = new System.Drawing.Size(100, 20);
            this.cbOnay.TabIndex = 28;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 499);
            this.Controls.Add(this.cbOnay);
            this.Controls.Add(this.cbUrun);
            this.Controls.Add(this.btnPlakaSorgu);
            this.Controls.Add(this.txtPlakaSorgu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datePoliceBitis);
            this.Controls.Add(this.datePoliceBaslangic);
            this.Controls.Add(this.dateTeklifTarihi);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.dateDt);
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
            this.Controls.Add(this.btnAdd);
            this.Name = "Form2";
            this.Text = "Poliçe Sorgu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlakaSorgu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTeklifTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTeklifTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOnay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.DateEdit dateDt;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.DateEdit dateTeklifTarihi;
        private DevExpress.XtraEditors.DateEdit datePoliceBaslangic;
        private DevExpress.XtraEditors.DateEdit datePoliceBitis;
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
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtPlakaSorgu;
        private DevExpress.XtraEditors.SimpleButton btnPlakaSorgu;
        private DevExpress.XtraEditors.ComboBoxEdit cbUrun;
        private DevExpress.XtraEditors.ComboBoxEdit cbOnay;
    }
}