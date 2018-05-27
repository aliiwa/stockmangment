using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CETJ_STOCK.PL
{
    public partial class frm_login : Form
    {
        BL.CLS_Users us = new BL.CLS_Users();
        
        uc_user_activities uac = new uc_user_activities();
        DataTable dt = new DataTable();
       
        public frm_login()
        {
            InitializeComponent();
        }


        private string SHA512(string password)
        {
            SHA512Managed SHA512 = new SHA512Managed();
            byte[] hash = System.Text.Encoding.UTF8.GetBytes(password);
            hash = SHA512.ComputeHash(hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }


        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string sha_password = SHA512(txt_password.Text);
            string sha_username = SHA512(txt_username.Text);
            DataTable user_id = us.GET_USER_ID(txt_username.Text);
           
            dt = us.SP_LOGIN(txt_username.Text, sha_password);


           

           if(dt.Rows.Count >0)
            {
                /*MessageBox.Show("اهلا وسهلاً ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                Properties.Settings.Default.username = txt_username.Text;
                Properties.Settings.Default.user_password = sha_password;
                Properties.Settings.Default.user_id = Convert.ToInt32(user_id.Rows[0][0].ToString());

                /****************************************************/
                int useer_id = Properties.Settings.Default.user_id;
                DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                string time = DateTime.Now.ToLongTimeString();
                string process = "تسجيل الدخول  " + Properties.Settings.Default.username  ;
                string screens = "تسجيل الدخول";

                us.ADD_MONITER(useer_id, date, time, process, screens);
                uac.dgv_users.DataSource = us.GET_ALL_MONITER();
                /****************************************************/


                mainForm mf = new mainForm();
                mf.ShowDialog();

                //string t = Convert.ToString( Properties.Settings.Default.user_id);
                //MessageBox.Show( t , "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*frm_login lg = new frm_login();
                lg.Close();*/
            }
            else
            {
                

                MessageBox.Show(" الرجاء ادخال البيانات الصحيحة ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sha_password = SHA512(txt_password.Text);
                string sha_username = SHA512(txt_username.Text);
                DataTable user_id = us.GET_USER_ID(txt_username.Text);

                dt = us.SP_LOGIN(txt_username.Text, sha_password);

                if (dt.Rows.Count > 0)


                {
                    Properties.Settings.Default.username = txt_username.Text;
                    Properties.Settings.Default.user_password = sha_password;
                    Properties.Settings.Default.user_id = Convert.ToInt32(user_id.Rows[0][0].ToString());

                    /****************************************************/
                    int useer_id = Properties.Settings.Default.user_id;
                    DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    string time = DateTime.Now.ToLongTimeString();
                    string process = "تسجيل الدخول  " + Properties.Settings.Default.username;
                    string screens = "تسجيل الدخول";

                    us.ADD_MONITER(useer_id, date, time, process, screens);
                    uac.dgv_users.DataSource = us.GET_ALL_MONITER();
                    /****************************************************/

                    mainForm mf = new mainForm();
                    mf.ShowDialog();

                }
                else
                {

                   

                    MessageBox.Show(" الرجاء ادخال البيانات الصحيحة ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }

            }

        private void BunifuFlatButton10_Click(object sender, EventArgs e)
        {
            //Close();
        }
    }
}
