using ADGV;
using DevExpress.Utils.Extensions;
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

using iTextSharp.text;

namespace WindowsFormsApp1
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            firstCustomControl1.BringToFront();
            button1.BackColor = Color.FromArgb(227, 239, 255);

            /* this.StartPosition = FormStartPosition.CenterScreen;
             this.WindowState = FormWindowState.Normal;*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
            button1.BackColor = Color.FromArgb(227, 239, 255);
            button2.BackColor = Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            secondCustomControl1.BringToFront();
            button2.BackColor = Color.FromArgb(227, 239, 255);
            button1.BackColor = Color.White;

        }
    }
}