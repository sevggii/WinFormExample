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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPDF = new DevExpress.XtraEditors.SimpleButton();
            this.cbOnay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbUrun = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnPlakaSorgu = new DevExpress.XtraEditors.SimpleButton();
            this.txtPlakaSorgu = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.datePoliceBitis = new DevExpress.XtraEditors.DateEdit();
            this.datePoliceBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.dateTeklifTarihi = new DevExpress.XtraEditors.DateEdit();
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
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.tcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belge_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teklif_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeBaslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeBitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUrun.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.advancedDataGridView1);
            this.panelControl1.Controls.Add(this.btnPDF);
            this.panelControl1.Controls.Add(this.cbOnay);
            this.panelControl1.Controls.Add(this.cbUrun);
            this.panelControl1.Controls.Add(this.btnPlakaSorgu);
            this.panelControl1.Controls.Add(this.txtPlakaSorgu);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Controls.Add(this.datePoliceBitis);
            this.panelControl1.Controls.Add(this.datePoliceBaslangic);
            this.panelControl1.Controls.Add(this.dateTeklifTarihi);
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
            this.panelControl1.Location = new System.Drawing.Point(1, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(941, 554);
            this.panelControl1.TabIndex = 0;
            // 
            // btnPDF
            // 
            this.btnPDF.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.printviapdf_32x32;
            this.btnPDF.Location = new System.Drawing.Point(804, 250);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(123, 38);
            this.btnPDF.TabIndex = 53;
            this.btnPDF.Text = "PDF AL";
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // cbOnay
            // 
            this.cbOnay.Location = new System.Drawing.Point(733, 185);
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
            // cbUrun
            // 
            this.cbUrun.Location = new System.Drawing.Point(442, 162);
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
            this.btnPlakaSorgu.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.lookup_reference_16x16;
            this.btnPlakaSorgu.Location = new System.Drawing.Point(187, 42);
            this.btnPlakaSorgu.Name = "btnPlakaSorgu";
            this.btnPlakaSorgu.Size = new System.Drawing.Size(57, 23);
            this.btnPlakaSorgu.TabIndex = 49;
            this.btnPlakaSorgu.Text = "ARA";
            this.btnPlakaSorgu.Click += new System.EventHandler(this.btnPlakaSorgu_Click);
            // 
            // txtPlakaSorgu
            // 
            this.txtPlakaSorgu.Location = new System.Drawing.Point(81, 44);
            this.txtPlakaSorgu.Name = "txtPlakaSorgu";
            this.txtPlakaSorgu.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlakaSorgu.Size = new System.Drawing.Size(100, 20);
            this.txtPlakaSorgu.TabIndex = 48;
            this.txtPlakaSorgu.TextChanged += new System.EventHandler(this.txtPlakaSorgu_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Plaka";
            // 
            // datePoliceBitis
            // 
            this.datePoliceBitis.EditValue = null;
            this.datePoliceBitis.Location = new System.Drawing.Point(733, 162);
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
            this.datePoliceBaslangic.Location = new System.Drawing.Point(733, 139);
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
            // dateTeklifTarihi
            // 
            this.dateTeklifTarihi.EditValue = null;
            this.dateTeklifTarihi.Location = new System.Drawing.Point(442, 185);
            this.dateTeklifTarihi.Name = "dateTeklifTarihi";
            this.dateTeklifTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTeklifTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTeklifTarihi.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTeklifTarihi.Properties.MaskSettings.Set("mask", "d/M/yyyy");
            this.dateTeklifTarihi.Size = new System.Drawing.Size(100, 20);
            this.dateTeklifTarihi.TabIndex = 43;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(442, 139);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(100, 20);
            this.txtBelgeNo.TabIndex = 42;
            this.txtBelgeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBelgeNo_KeyPress);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(201, 189);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 41;
            // 
            // dateDt
            // 
            this.dateDt.EditValue = null;
            this.dateDt.Location = new System.Drawing.Point(201, 162);
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
            this.txtTC.Location = new System.Drawing.Point(201, 139);
            this.txtTC.Name = "txtTC";
            this.txtTC.Properties.MaxLength = 11;
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 39;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Onay Durumu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Poliçe Bitiş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Poliçe Başlangıç Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Teklif Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ürün:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Belge No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "TC Kimlik No:";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.add_16x16;
            this.btnAdd.Location = new System.Drawing.Point(442, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 31);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "KAYIT EKLE";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AllowUserToResizeColumns = false;
            this.advancedDataGridView1.AllowUserToResizeRows = false;
            this.advancedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.advancedDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advancedDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.advancedDataGridView1.ColumnHeadersHeight = 20;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcNo,
            this.dogumTarihi,
            this.plakaa,
            this.belge_no,
            this.urun_,
            this.teklif_tarihi,
            this.policeBaslangic,
            this.policeBitis,
            this.onay});
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 304);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(947, 350);
            this.advancedDataGridView1.TabIndex = 55;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // tcNo
            // 
            this.tcNo.HeaderText = "TC Kimlik No";
            this.tcNo.MinimumWidth = 22;
            this.tcNo.Name = "tcNo";
            this.tcNo.ReadOnly = true;
            this.tcNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dogumTarihi
            // 
            this.dogumTarihi.HeaderText = "Doğum Tarihi";
            this.dogumTarihi.MinimumWidth = 22;
            this.dogumTarihi.Name = "dogumTarihi";
            this.dogumTarihi.ReadOnly = true;
            this.dogumTarihi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // plakaa
            // 
            this.plakaa.HeaderText = "Plaka";
            this.plakaa.MinimumWidth = 22;
            this.plakaa.Name = "plakaa";
            this.plakaa.ReadOnly = true;
            this.plakaa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // belge_no
            // 
            this.belge_no.HeaderText = "Belge No";
            this.belge_no.MinimumWidth = 22;
            this.belge_no.Name = "belge_no";
            this.belge_no.ReadOnly = true;
            this.belge_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // urun_
            // 
            this.urun_.HeaderText = "Ürün";
            this.urun_.MinimumWidth = 22;
            this.urun_.Name = "urun_";
            this.urun_.ReadOnly = true;
            this.urun_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // teklif_tarihi
            // 
            this.teklif_tarihi.HeaderText = "Teklif Tarihi";
            this.teklif_tarihi.MinimumWidth = 22;
            this.teklif_tarihi.Name = "teklif_tarihi";
            this.teklif_tarihi.ReadOnly = true;
            this.teklif_tarihi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // policeBaslangic
            // 
            this.policeBaslangic.HeaderText = "Poliçe Başlangıç";
            this.policeBaslangic.MinimumWidth = 22;
            this.policeBaslangic.Name = "policeBaslangic";
            this.policeBaslangic.ReadOnly = true;
            this.policeBaslangic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // policeBitis
            // 
            this.policeBitis.HeaderText = "Poliçe Bitiş";
            this.policeBitis.MinimumWidth = 22;
            this.policeBitis.Name = "policeBitis";
            this.policeBitis.ReadOnly = true;
            this.policeBitis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // onay
            // 
            this.onay.HeaderText = "Onay Durumu";
            this.onay.MinimumWidth = 22;
            this.onay.Name = "onay";
            this.onay.ReadOnly = true;
            this.onay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 661);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Poliçe Sorgu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUrun.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbOnay;
        private DevExpress.XtraEditors.ComboBoxEdit cbUrun;
        private DevExpress.XtraEditors.SimpleButton btnPlakaSorgu;
        private DevExpress.XtraEditors.TextEdit txtPlakaSorgu;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.DateEdit datePoliceBitis;
        private DevExpress.XtraEditors.DateEdit datePoliceBaslangic;
        private DevExpress.XtraEditors.DateEdit dateTeklifTarihi;
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
        private DevExpress.XtraEditors.SimpleButton btnPDF;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn belge_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_;
        private System.Windows.Forms.DataGridViewTextBoxColumn teklif_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeBaslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeBitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn onay;
    }
}