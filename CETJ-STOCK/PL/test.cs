using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CETJ_STOCK.PL
{
    public partial class test : Form
    {
        SqlConnection con = new SqlConnection(@"Server = ALIWA-PC,1433; DataBase = CETJ_Stock; Integrated Security = false; User ID = ba; Password = ba; ");
        DataTable Dt = new DataTable();
        BL.CLS_Users us = new BL.CLS_Users();

        public test()
        {
            InitializeComponent();

            /* كومبو بوكس الاقسام */
            cmb_user.DataSource = us.GET_ALL_USERS();
            cmb_user.DisplayMember = "full_name";
            cmb_user.ValueMember = "user_id";


            /* كومبو بوكس الاقسام */
            cmb_priv.DataSource = us.GET_ALL_LISTS();
            cmb_priv.DisplayMember = "list_name";
            cmb_priv.ValueMember = "list_id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //dgv_users.Rows[i].Cells[0].Value
            int user_id = Convert.ToInt32(cmb_user.SelectedValue);
            for (int i = 0; i < dgv_users.Rows.Count; i++)
            {
                
                int screen_id = Convert.ToInt32(dgv_users.Rows[i].Cells[1].Value);
                Boolean dis = dgv_users.Rows[i].Cells[3].Value.Equals(true || false);
                Boolean add = dgv_users.Rows[i].Cells[4].Value.Equals(true || false);
                Boolean edit = dgv_users.Rows[i].Cells[5].Value.Equals(true || false);
                Boolean delete = dgv_users.Rows[i].Cells[6].Value.Equals(true || false);

                SqlCommand cmd1 = new SqlCommand("UPDATE TP_priv SET priv_display = @priv_display,priv_add = @priv_add ,priv_edit = @priv_edit ,priv_delete = @priv_delete WHERE user_id = @user_id and screen_id = @screen_id  ",con);
                cmd1.Parameters.Add(new SqlParameter("@priv_display", SqlDbType.Bit)).Value = dis;
                cmd1.Parameters.Add(new SqlParameter("@priv_add", SqlDbType.Bit)).Value = add;
                cmd1.Parameters.Add(new SqlParameter("@priv_edit", SqlDbType.Bit)).Value = edit;
                cmd1.Parameters.Add(new SqlParameter("@priv_delete", SqlDbType.Bit)).Value = delete;
                cmd1.Parameters.Add(new SqlParameter("@user_id", SqlDbType.Int)).Value = user_id;
                cmd1.Parameters.Add(new SqlParameter("@screen_id", SqlDbType.Int)).Value = screen_id;
                //us.UPDATE_PRIV(user_id,screen_id,dis,add,edit,delete);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgv_users.DataSource = Dt;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Dt = us.search_priv(Convert.ToInt32(cmb_user.SelectedValue), Convert.ToInt32(cmb_priv.SelectedValue));

            dgv_users.DataSource = Dt;
            dgv_users.Columns[0].Visible = false;
            dgv_users.Columns[1].Visible = false;
            dgv_users.Columns[2].HeaderText = "اسم الشاشة";
            dgv_users.Columns[3].HeaderText = "العرض";
            dgv_users.Columns[4].HeaderText = "الاضافة";
            dgv_users.Columns[5].HeaderText = "التعديل";
            dgv_users.Columns[6].HeaderText = "الحذف";
        }
    }
}
