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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlakaSorgu = new System.Windows.Forms.TextBox();
            this.btnPlakaSorgu = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtDt = new System.Windows.Forms.TextBox();
            this.txtTeklifTarihi = new System.Windows.Forms.TextBox();
            this.txtPoliceBaslangic = new System.Windows.Forms.TextBox();
            this.txtPoliceBitis = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnControl.Location = new System.Drawing.Point(832, 174);
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
            this.label1.Location = new System.Drawing.Point(204, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plaka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Belge No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürün:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teklif Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Poliçe Başlangıç Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Poliçe Bitiş Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Onay Durumu:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(290, 124);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(67, 20);
            this.txtTC.TabIndex = 10;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(290, 183);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(67, 20);
            this.txtPlaka.TabIndex = 12;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(477, 124);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(89, 20);
            this.txtBelgeNo.TabIndex = 13;
            // 
            // cbUrun
            // 
            this.cbUrun.FormattingEnabled = true;
            this.cbUrun.Location = new System.Drawing.Point(477, 152);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Size = new System.Drawing.Size(90, 21);
            this.cbUrun.TabIndex = 14;
            // 
            // cbOnay
            // 
            this.cbOnay.FormattingEnabled = true;
            this.cbOnay.Location = new System.Drawing.Point(726, 185);
            this.cbOnay.Name = "cbOnay";
            this.cbOnay.Size = new System.Drawing.Size(88, 21);
            this.cbOnay.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 471);
            this.dataGridView1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1042, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "PLAKA:";
            // 
            // txtPlakaSorgu
            // 
            this.txtPlakaSorgu.Location = new System.Drawing.Point(1016, 160);
            this.txtPlakaSorgu.Name = "txtPlakaSorgu";
            this.txtPlakaSorgu.Size = new System.Drawing.Size(100, 20);
            this.txtPlakaSorgu.TabIndex = 21;
            this.txtPlakaSorgu.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // btnPlakaSorgu
            // 
            this.btnPlakaSorgu.BackColor = System.Drawing.Color.White;
            this.btnPlakaSorgu.Location = new System.Drawing.Point(1028, 186);
            this.btnPlakaSorgu.Name = "btnPlakaSorgu";
            this.btnPlakaSorgu.Size = new System.Drawing.Size(75, 23);
            this.btnPlakaSorgu.TabIndex = 22;
            this.btnPlakaSorgu.Text = "SORGULA";
            this.btnPlakaSorgu.UseVisualStyleBackColor = false;
            this.btnPlakaSorgu.Click += new System.EventHandler(this.btnPlakaSorgu_Click);
            // 
            // txtDt
            // 
            this.txtDt.Location = new System.Drawing.Point(290, 155);
            this.txtDt.Name = "txtDt";
            this.txtDt.Size = new System.Drawing.Size(67, 20);
            this.txtDt.TabIndex = 28;
            this.txtDt.TextChanged += new System.EventHandler(this.txtDt_TextChanged);
            // 
            // txtTeklifTarihi
            // 
            this.txtTeklifTarihi.Location = new System.Drawing.Point(477, 182);
            this.txtTeklifTarihi.Name = "txtTeklifTarihi";
            this.txtTeklifTarihi.Size = new System.Drawing.Size(90, 20);
            this.txtTeklifTarihi.TabIndex = 29;
            this.txtTeklifTarihi.TextChanged += new System.EventHandler(this.txtTeklifTarihi_TextChanged);
            this.txtTeklifTarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeklifTarihi_KeyPress);
            // 
            // txtPoliceBaslangic
            // 
            this.txtPoliceBaslangic.Location = new System.Drawing.Point(726, 126);
            this.txtPoliceBaslangic.Name = "txtPoliceBaslangic";
            this.txtPoliceBaslangic.Size = new System.Drawing.Size(88, 20);
            this.txtPoliceBaslangic.TabIndex = 30;
            this.txtPoliceBaslangic.TextChanged += new System.EventHandler(this.txtPoliceBaslangic_TextChanged);
            // 
            // txtPoliceBitis
            // 
            this.txtPoliceBitis.Location = new System.Drawing.Point(726, 157);
            this.txtPoliceBitis.Name = "txtPoliceBitis";
            this.txtPoliceBitis.Size = new System.Drawing.Size(88, 20);
            this.txtPoliceBitis.TabIndex = 31;
            this.txtPoliceBitis.TextChanged += new System.EventHandler(this.txtPoliceBitis_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 67);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 54);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 727);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPoliceBitis);
            this.Controls.Add(this.txtPoliceBaslangic);
            this.Controls.Add(this.txtTeklifTarihi);
            this.Controls.Add(this.txtDt);
            this.Controls.Add(this.btnPlakaSorgu);
            this.Controls.Add(this.txtPlakaSorgu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPlakaSorgu;
        private System.Windows.Forms.Button btnPlakaSorgu;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtDt;
        private System.Windows.Forms.TextBox txtTeklifTarihi;
        private System.Windows.Forms.TextBox txtPoliceBaslangic;
        private System.Windows.Forms.TextBox txtPoliceBitis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

