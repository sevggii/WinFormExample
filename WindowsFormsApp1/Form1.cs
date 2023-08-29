using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Data.Connection con = new Data.Connection();

        public Form1()
        {
            InitializeComponent();
            lbl_error.Visible = false;
            lbl_success.Visible=false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_urun.Items.Add("Kasko");
            cb_urun.Items.Add("Kasko");
            cb_urun.Items.Add("Kasko");
            cb_urun.Items.Add("Kasko");
            cb_urun.Items.Add("Kasko");
            cb_urun.Items.Add("Kasko");
            cb_urun.Items.Add("Kasko");

            cb_onay.Items.Add("Onaylandı");
            cb_onay.Items.Add("Bekliyor");
            cb_onay.Items.Add("Onaylanmadı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }

            catch(Exception)
            {

            }
            finally
            {

            }
        }
    }
}
