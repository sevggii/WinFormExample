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
            this.txt_plaka_sorgu = new System.Windows.Forms.TextBox();
            this.btn_plaka_sorgu = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtDt = new System.Windows.Forms.TextBox();
            this.txtTeklifTarih = new System.Windows.Forms.TextBox();
            this.txtPoliceBaslangic = new System.Windows.Forms.TextBox();
            this.txtPoliceBitis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(1039, 89);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(122, 25);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "KONTROL";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.button1_Click);
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
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(152, 61);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(140, 20);
            this.txtTC.TabIndex = 10;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(152, 120);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(140, 20);
            this.txtPlaka.TabIndex = 12;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(457, 61);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(200, 20);
            this.txtBelgeNo.TabIndex = 13;
            // 
            // cbUrun
            // 
            this.cbUrun.FormattingEnabled = true;
            this.cbUrun.Location = new System.Drawing.Point(457, 89);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Size = new System.Drawing.Size(201, 21);
            this.cbUrun.TabIndex = 14;
            // 
            // cbOnay
            // 
            this.cbOnay.FormattingEnabled = true;
            this.cbOnay.Location = new System.Drawing.Point(793, 120);
            this.cbOnay.Name = "cbOnay";
            this.cbOnay.Size = new System.Drawing.Size(200, 21);
            this.cbOnay.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 450);
            this.dataGridView1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1123, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "PLAKA:";
            // 
            // txt_plaka_sorgu
            // 
            this.txt_plaka_sorgu.Location = new System.Drawing.Point(1100, 238);
            this.txt_plaka_sorgu.Name = "txt_plaka_sorgu";
            this.txt_plaka_sorgu.Size = new System.Drawing.Size(100, 20);
            this.txt_plaka_sorgu.TabIndex = 21;
            // 
            // btn_plaka_sorgu
            // 
            this.btn_plaka_sorgu.Location = new System.Drawing.Point(1110, 264);
            this.btn_plaka_sorgu.Name = "btn_plaka_sorgu";
            this.btn_plaka_sorgu.Size = new System.Drawing.Size(75, 23);
            this.btn_plaka_sorgu.TabIndex = 22;
            this.btn_plaka_sorgu.Text = "SORGULA";
            this.btn_plaka_sorgu.UseVisualStyleBackColor = true;
            this.btn_plaka_sorgu.Click += new System.EventHandler(this.btn_plaka_sorgu_Click);
            // 
            // txtDt
            // 
            this.txtDt.Location = new System.Drawing.Point(152, 92);
            this.txtDt.Name = "txtDt";
            this.txtDt.Size = new System.Drawing.Size(140, 20);
            this.txtDt.TabIndex = 28;
            this.txtDt.TextChanged += new System.EventHandler(this.txtDt_TextChanged);
            // 
            // txtTeklifTarih
            // 
            this.txtTeklifTarih.Location = new System.Drawing.Point(457, 124);
            this.txtTeklifTarih.Name = "txtTeklifTarih";
            this.txtTeklifTarih.Size = new System.Drawing.Size(201, 20);
            this.txtTeklifTarih.TabIndex = 29;
            // 
            // txtPoliceBaslangic
            // 
            this.txtPoliceBaslangic.Location = new System.Drawing.Point(793, 61);
            this.txtPoliceBaslangic.Name = "txtPoliceBaslangic";
            this.txtPoliceBaslangic.Size = new System.Drawing.Size(200, 20);
            this.txtPoliceBaslangic.TabIndex = 30;
            // 
            // txtPoliceBitis
            // 
            this.txtPoliceBitis.Location = new System.Drawing.Point(793, 92);
            this.txtPoliceBitis.Name = "txtPoliceBitis";
            this.txtPoliceBitis.Size = new System.Drawing.Size(200, 20);
            this.txtPoliceBitis.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 727);
            this.Controls.Add(this.txtPoliceBitis);
            this.Controls.Add(this.txtPoliceBaslangic);
            this.Controls.Add(this.txtTeklifTarih);
            this.Controls.Add(this.txtDt);
            this.Controls.Add(this.btn_plaka_sorgu);
            this.Controls.Add(this.txt_plaka_sorgu);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_plaka_sorgu;
        private System.Windows.Forms.Button btn_plaka_sorgu;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtDt;
        private System.Windows.Forms.TextBox txtTeklifTarih;
        private System.Windows.Forms.TextBox txtPoliceBaslangic;
        private System.Windows.Forms.TextBox txtPoliceBitis;
    }
}

