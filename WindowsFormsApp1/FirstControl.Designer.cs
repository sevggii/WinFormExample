namespace WindowsFormsApp1
{
    partial class FirstCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstCustomControl));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPDF = new DevExpress.XtraEditors.SimpleButton();
            this.cbUrun = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnPlakaSorgu = new DevExpress.XtraEditors.SimpleButton();
            this.txtPlakaSorgu = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.datePoliceBitis = new DevExpress.XtraEditors.DateEdit();
            this.datePoliceBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.dateDt = new DevExpress.XtraEditors.DateEdit();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teklifTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeBaslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeBitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onayDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbOnay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTeklifTarihi = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlakaSorgu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTeklifTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTeklifTarihi.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.dateTeklifTarihi);
            this.panelControl1.Controls.Add(this.label11);
            this.panelControl1.Controls.Add(this.cbFilter);
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Controls.Add(this.btnPDF);
            this.panelControl1.Controls.Add(this.cbOnay);
            this.panelControl1.Controls.Add(this.cbUrun);
            this.panelControl1.Controls.Add(this.btnPlakaSorgu);
            this.panelControl1.Controls.Add(this.txtPlakaSorgu);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Controls.Add(this.datePoliceBitis);
            this.panelControl1.Controls.Add(this.datePoliceBaslangic);
            this.panelControl1.Controls.Add(this.txtBelgeNo);
            this.panelControl1.Controls.Add(this.txtPlaka);
            this.panelControl1.Controls.Add(this.dateDt);
            this.panelControl1.Controls.Add(this.txtTC);
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Location = new System.Drawing.Point(0, -47);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(965, 570);
            this.panelControl1.TabIndex = 1;
            // 
            // btnPDF
            // 
            this.btnPDF.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.printviapdf_32x32;
            this.btnPDF.Location = new System.Drawing.Point(906, 295);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(39, 32);
            this.btnPDF.TabIndex = 53;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // cbUrun
            // 
            this.cbUrun.Location = new System.Drawing.Point(467, 184);
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
            this.cbUrun.TabIndex = 50;
            // 
            // btnPlakaSorgu
            // 
            this.btnPlakaSorgu.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlakaSorgu.Appearance.Options.UseBorderColor = true;
            this.btnPlakaSorgu.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.lookup_reference_16x16;
            this.btnPlakaSorgu.Location = new System.Drawing.Point(220, 121);
            this.btnPlakaSorgu.Name = "btnPlakaSorgu";
            this.btnPlakaSorgu.Size = new System.Drawing.Size(25, 20);
            this.btnPlakaSorgu.TabIndex = 49;
            // 
            // txtPlakaSorgu
            // 
            this.txtPlakaSorgu.Location = new System.Drawing.Point(124, 121);
            this.txtPlakaSorgu.Name = "txtPlakaSorgu";
            this.txtPlakaSorgu.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlakaSorgu.Size = new System.Drawing.Size(100, 20);
            this.txtPlakaSorgu.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(76, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Plaka:";
            // 
            // datePoliceBitis
            // 
            this.datePoliceBitis.EditValue = null;
            this.datePoliceBitis.Location = new System.Drawing.Point(782, 184);
            this.datePoliceBitis.Name = "datePoliceBitis";
            this.datePoliceBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePoliceBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePoliceBitis.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.datePoliceBitis.Properties.MaskSettings.Set("mask", "d/M/yyyy");
            this.datePoliceBitis.Size = new System.Drawing.Size(100, 20);
            this.datePoliceBitis.TabIndex = 45;
            // 
            // datePoliceBaslangic
            // 
            this.datePoliceBaslangic.EditValue = null;
            this.datePoliceBaslangic.Location = new System.Drawing.Point(782, 161);
            this.datePoliceBaslangic.Name = "datePoliceBaslangic";
            this.datePoliceBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePoliceBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePoliceBaslangic.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.datePoliceBaslangic.Properties.MaskSettings.Set("mask", "d/M/yyyy");
            this.datePoliceBaslangic.Size = new System.Drawing.Size(100, 20);
            this.datePoliceBaslangic.TabIndex = 44;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(467, 161);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(100, 20);
            this.txtBelgeNo.TabIndex = 42;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(200, 207);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 41;
            // 
            // dateDt
            // 
            this.dateDt.EditValue = null;
            this.dateDt.Location = new System.Drawing.Point(200, 184);
            this.dateDt.Name = "dateDt";
            this.dateDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDt.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateDt.Properties.MaskSettings.Set("mask", "d/M/yyyy");
            this.dateDt.Size = new System.Drawing.Size(100, 20);
            this.dateDt.TabIndex = 40;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(200, 161);
            this.txtTC.Name = "txtTC";
            this.txtTC.Properties.MaxLength = 11;
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(640, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Onay Durumu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(640, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Poliçe Bitiş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(640, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Poliçe Başlangıç Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(371, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Teklif Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(371, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ürün:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(371, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Belge No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(77, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(77, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "TC Kimlik No:";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(467, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnAdd.Size = new System.Drawing.Size(100, 37);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "KAYIT EKLE";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcNo,
            this.dogumTarihi,
            this.plaka,
            this.belgeNo,
            this.urun,
            this.teklifTarihi,
            this.policeBaslangic,
            this.policeBitis,
            this.onayDurumu});
            this.dataGridView1.Location = new System.Drawing.Point(3, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(959, 246);
            this.dataGridView1.TabIndex = 56;
            // 
            // tcNo
            // 
            this.tcNo.HeaderText = "TC Kimlik No";
            this.tcNo.Name = "tcNo";
            this.tcNo.ReadOnly = true;
            // 
            // dogumTarihi
            // 
            this.dogumTarihi.HeaderText = "Doğum Tarihi";
            this.dogumTarihi.Name = "dogumTarihi";
            this.dogumTarihi.ReadOnly = true;
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
            // policeBaslangic
            // 
            this.policeBaslangic.HeaderText = "Poliçe Başlangıç";
            this.policeBaslangic.Name = "policeBaslangic";
            this.policeBaslangic.ReadOnly = true;
            // 
            // policeBitis
            // 
            this.policeBitis.HeaderText = "Poliçe Bitiş";
            this.policeBitis.Name = "policeBitis";
            this.policeBitis.ReadOnly = true;
            // 
            // onayDurumu
            // 
            this.onayDurumu.HeaderText = "Onay Durumu";
            this.onayDurumu.Name = "onayDurumu";
            this.onayDurumu.ReadOnly = true;
            // 
            // cbOnay
            // 
            this.cbOnay.Location = new System.Drawing.Point(782, 207);
            this.cbOnay.Name = "cbOnay";
            this.cbOnay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOnay.Properties.Items.AddRange(new object[] {
            "Onaylandı",
            "Bekliyor",
            "Onaylanmadı"});
            this.cbOnay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbOnay.Size = new System.Drawing.Size(100, 20);
            this.cbOnay.TabIndex = 51;
            // 
            // cbFilter
            // 
            this.cbFilter.EditValue = "Hepsi";
            this.cbFilter.Location = new System.Drawing.Point(800, 301);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFilter.Properties.Items.AddRange(new object[] {
            "Hepsi",
            "Son 15 Gün",
            "Son 30 Gün",
            "Son 45 Gün"});
            this.cbFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFilter.Size = new System.Drawing.Size(100, 20);
            this.cbFilter.TabIndex = 57;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(751, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Filtrele:";
            // 
            // dateTeklifTarihi
            // 
            this.dateTeklifTarihi.EditValue = null;
            this.dateTeklifTarihi.Location = new System.Drawing.Point(467, 207);
            this.dateTeklifTarihi.Name = "dateTeklifTarihi";
            this.dateTeklifTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTeklifTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTeklifTarihi.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTeklifTarihi.Properties.MaskSettings.Set("mask", "d/M/yyyy");
            this.dateTeklifTarihi.Size = new System.Drawing.Size(100, 20);
            this.dateTeklifTarihi.TabIndex = 59;
            // 
            // FirstCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "FirstCustomControl";
            this.Size = new System.Drawing.Size(965, 532);
            this.Load += new System.EventHandler(this.FirstControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlakaSorgu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePoliceBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTeklifTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTeklifTarihi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPDF;
        private DevExpress.XtraEditors.ComboBoxEdit cbUrun;
        private DevExpress.XtraEditors.SimpleButton btnPlakaSorgu;
        private DevExpress.XtraEditors.TextEdit txtPlakaSorgu;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.DateEdit datePoliceBitis;
        private DevExpress.XtraEditors.DateEdit datePoliceBaslangic;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private DevExpress.XtraEditors.DateEdit dateDt;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn plaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn teklifTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeBaslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeBitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn onayDurumu;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.ComboBoxEdit cbFilter;
        private DevExpress.XtraEditors.ComboBoxEdit cbOnay;
        private DevExpress.XtraEditors.DateEdit dateTeklifTarihi;
    }
}
