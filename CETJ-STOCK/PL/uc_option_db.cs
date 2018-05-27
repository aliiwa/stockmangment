using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CETJ_STOCK.PL
{
    public partial class uc_option_db : UserControl
    {
        //CETJ_Stock
        //; User ID = ba; Password = ba; 
        SqlConnection con = new SqlConnection (@"Server = ALIWA-PC,1433; DataBase = master; Integrated Security = true");
        SqlCommand cmd ;
        public uc_option_db()
        {
            InitializeComponent();
        }

        private void btn_chose_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_fileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            //try
            //    {
                //+DateTime.Now.ToShortDateString().Replace('/','-')+"-"+DateTime.Now.ToLongTimeString().Replace(':', '-')
                string fileName = txt_fileName.Text + "\\" + Properties.Settings.Default.Database + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string srtQuery = "Backup Database CETJ_Stock to Disk ='" + fileName + ".bak'";
                cmd = new SqlCommand(srtQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم انشاء النسخة", "انشاء النسخة الاحتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void btn_restor_Click(object sender, EventArgs e)
        {
            string srtQuery = "ALTER database CETJ_Stock set OFFLINE with rollback immediate; Restore Database CETJ_Stock from Disk ='" + txt_re_fileName.Text + "'";
            cmd = new SqlCommand(srtQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة النسخة", "استعادة النسخة الاحتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_chose1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_re_fileName.Text = openFileDialog1.FileName;
            }
            
        }
    }
}
