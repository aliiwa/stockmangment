using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CETJ_STOCK.PL
{
    public partial class uc_users : UserControl
    {
        BL.CLS_Users us = new BL.CLS_Users();
        DataTable dt = new DataTable();
        public string state = "add";
        public uc_users()
        {
            InitializeComponent();
            //dgv_users.DataSource = us.GET_ALL_USERS();
        }

        private void tap_Click1(object sender, EventArgs e)
        {

            mainForm mf = new mainForm();
            mf.label2.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            uc_user_control1.BringToFront();
            tap_Click1(sender, e);
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            
            /* كومبو بوكس الاقسام */
           uc_users_prmation1.cmb_user.DataSource = us.GET_ALL_USERS();
           uc_users_prmation1.cmb_user.DisplayMember = "full_name";
           uc_users_prmation1.cmb_user.ValueMember = "user_id";

            uc_users_prmation1.BringToFront();
            tap_Click1(sender, e);
        }

     

        //private string SHA512(string password)
        //{
        //    SHA512Managed SHA512 = new SHA512Managed();
        //    byte[] hash = System.Text.Encoding.UTF8.GetBytes(password);
        //    hash = SHA512.ComputeHash(hash);
        //    StringBuilder sb = new StringBuilder();
        //    foreach(byte b in hash)
        //    {
        //        sb.Append(b.ToString("x2").ToLower());
        //    }
        //    return sb.ToString();
        //}

        //private void btn_add_Click(object sender, EventArgs e)
        //{
        //    string hashPass = SHA512(txt_password.Text);

        //    if (state == "add")
        //    {
        //        if (txt_user_id.Text != string.Empty && txt_full_name.Text != string.Empty && txt_user_name.Text != string.Empty && txt_password.Text != string.Empty)
        //        {
        //            us.ADD_USERS(Convert.ToInt32(txt_user_id.Text), txt_full_name.Text, txt_user_name.Text, hashPass);
        //            // SqlCommand cmd = new SqlCommand("INSERT INTO TP_users values(@full_name,@user_name,@password)");
        //            MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.dgv_users.DataSource = us.GET_ALL_USERS();
        //        }
        //    }
        //    else
        //    {
        //         hashPass = SHA512(txt_password.Text);

        //        if ( txt_password.Text != string.Empty)
        //        {
        //            us.UPDATE_USERS(Convert.ToInt32(txt_user_id.Text), txt_full_name.Text, txt_user_name.Text, hashPass);
        //            // SqlCommand cmd = new SqlCommand("INSERT INTO TP_users values(@full_name,@user_name,@password)");
        //            MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.dgv_users.DataSource = us.GET_ALL_USERS();
        //        }
        //        else
        //        {
        //            us.UPDATE_USER_EX(Convert.ToInt32(txt_user_id.Text), txt_full_name.Text, txt_user_name.Text);
        //            // SqlCommand cmd = new SqlCommand("INSERT INTO TP_users values(@full_name,@user_name,@password)");
        //            MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.dgv_users.DataSource = us.GET_ALL_USERS();
        //        }
        //    }
        //}



        //private void txt_user_id_TextChanged(object sender, EventArgs e)
        //{
        //  /*   = us.MAX_USER_ID();

        //   txt_user_id = Convert.ToString(us.MAX_USER_ID());*/
        //}

        //private void btn_new_Click(object sender, EventArgs e)
        //{
        //    clearBox();
        //    txt_user_id.Text = us.MAX_USER_ID().Rows[0][0].ToString();
        //    btn_add.Enabled = true;
        //    btn_edit.Enabled = true;
        //    btn_delete.Enabled = true;
        //}

        //private void clearBox()
        //{
        //    txt_user_id.Clear();
        //    txt_full_name.Clear();
        //    txt_user_name.Clear();
        //    txt_password.Clear();


        //    //btn_new.Enabled = true;
        //}

        //private void btn_edit_Click(object sender, EventArgs e)
        //{
        //    txt_user_id.Text = this.dgv_users.CurrentRow.Cells[0].Value.ToString();
        //    txt_full_name.Text = this.dgv_users.CurrentRow.Cells[1].Value.ToString();
        //    txt_user_name.Text = this.dgv_users.CurrentRow.Cells[2].Value.ToString();

        //    btn_add.Enabled = true;
        //    state = "ubdate";
        //}

        //private void btn_delete_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        //    {
        //        us.DELETE_USERES(Convert.ToInt32( this.dgv_users.CurrentRow.Cells[0].Value.ToString()));
        //        MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.dgv_users.DataSource = us.GET_ALL_USERS();
        //    }
        //    else
        //    {
        //        MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
