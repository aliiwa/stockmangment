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
    public partial class uc_users_prmation : UserControl
    {
        //SqlConnection con = new SqlConnection(@"Server = ALIWA-PC,1433; DataBase = CETJ_Stock; Integrated Security = false; User ID = ba; Password = ba; ");
        //SqlDataAdapter Da;

        BL.CLS_Users us = new BL.CLS_Users();
        uc_user_activities uac = new uc_user_activities();
        DataTable dt = new DataTable();
        public string state = "add";
        DataTable Dt = new DataTable();

        void CreateDataTable()
        {
            Dt.Columns.Add("رقم المستخدم");
            Dt.Columns.Add("رقم  الشاشة");
            Dt.Columns.Add("اسم الشاشة");
            Dt.Columns.Add("العرض");
            Dt.Columns.Add("الاضافة");
            Dt.Columns.Add("التعديل");
            Dt.Columns.Add("الحذف");
            dgv_users.DataSource = Dt;
        }
        public uc_users_prmation()
        {
            InitializeComponent();
            //CreateDataTable();
            /* كومبو بوكس الاقسام */
            cmb_user.DataSource = us.GET_ALL_USERS();
            cmb_user.DisplayMember = "full_name";
            cmb_user.ValueMember = "user_id";


            /* كومبو بوكس الاقسام */
            cmb_priv.DataSource = us.GET_ALL_LISTS();
            cmb_priv.DisplayMember = "list_name";
            cmb_priv.ValueMember = "list_id";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Dt = us.search_priv(Convert.ToInt32(cmb_user.SelectedValue),Convert.ToInt32(cmb_priv.SelectedValue));

            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض الصلاحيات للمستخدم  " +cmb_user.SelectedText +" "+ cmb_priv.SelectedText;
            string screens = "الصلاحيات";

            us.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            dgv_users.DataSource = Dt;
            dgv_users.Columns[0].Visible = false;
            dgv_users.Columns[1].Visible = false;
            dgv_users.Columns[2].HeaderText = "اسم الشاشة";

            string cDis = dgv_users.Rows[0].Cells[3].Value.ToString();
            string cAdd = dgv_users.Rows[0].Cells[4].Value.ToString();
            string cEdit = dgv_users.Rows[0].Cells[5].Value.ToString();
            string cDelete = dgv_users.Rows[0].Cells[6].Value.ToString();

            if(cDis == "True")
            {
                chk_dis.Checked = true;
            }

            if (cAdd == "True")
            {
                chk_add.Checked = true;
            }

            if (cEdit == "True")
            {
                chk_dis.Checked = true;
            }

            if (cDelete == "True")
            {
                chk_delete.Checked = true;
            }

            //dgv_users.Columns[3].HeaderText = "العرض";
            //dgv_users.Columns[4].HeaderText = "الاضافة";
            //dgv_users.Columns[5].HeaderText = "التعديل";
            //dgv_users.Columns[6].HeaderText = "الحذف";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //int user_id = Convert.ToInt32(cmb_user.SelectedValue) ;
            //try
            //{
                for (int i = 0; i < dgv_users.Rows.Count; i++)
                {
                //Boolean dis = false, add = false, edit = false, delete = false;

                int user_id = Convert.ToInt32(dgv_users.Rows[i].Cells[0].Value);
                int screen_id = Convert.ToInt32(dgv_users.Rows[i].Cells[1].Value);
                //Boolean dis = dgv_users.Rows[i].Cells[3].Value.Equals(true || false);
                //Boolean add = dgv_users.Rows[i].Cells[4].Value.Equals(true || false);
                //Boolean edit = dgv_users.Rows[i].Cells[5].Value.Equals(true || false);
                //Boolean delete = dgv_users.Rows[i].Cells[6].Value.Equals(true || false);
                // if(dgv_users.Rows[i].Cells[3].Value)

                Boolean cDis ;
                Boolean cAdd ;
                Boolean cEdit ;
                Boolean cDelete ;

                if (chk_dis.CheckState == CheckState.Unchecked)
                {
                    cDis = false;
                }
                else
                {
                    cDis = true;
                }

                if (chk_add.CheckState == CheckState.Unchecked)
                {
                    cAdd = false;
                }
                else
                {
                    cAdd = true;
                }

                if (chk_edit.CheckState == CheckState.Unchecked)
                {
                    cEdit = false;
                }
                else
                {
                    cEdit = true;
                }

                if (chk_delete.CheckState == CheckState.Unchecked)
                {
                    cDelete = false;
                }
                else
                {
                    cDelete = true;
                }



                us.UPDATE_PRIV(user_id, screen_id, cDis, cAdd, cEdit, cDelete);

                //SqlCommand cmd1 = new SqlCommand("UPDATE TP_priv SET priv_display = @priv_display,priv_add = @priv_add ,priv_edit = @priv_edit ,priv_delete = @priv_delete WHERE user_id = @user_id and screen_id = @screen_id  ");
                //cmd1.Parameters.Add(new SqlParameter("@priv_display", SqlDbType.Bit)).Value = dis;
                //cmd1.Parameters.Add(new SqlParameter("@priv_add", SqlDbType.Bit)).Value = add;
                //cmd1.Parameters.Add(new SqlParameter("@priv_edit", SqlDbType.Bit)).Value = edit;
                //cmd1.Parameters.Add(new SqlParameter("@priv_delete", SqlDbType.Bit)).Value = delete;
                //cmd1.Parameters.Add(new SqlParameter("@user_id", SqlDbType.Int)).Value = user_id;
                //cmd1.Parameters.Add(new SqlParameter("@screen_id", SqlDbType.Int)).Value = screen_id;

                //con.Open();
                //cmd1.ExecuteNonQuery();
                //con.Close();
                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            dgv_users.DataSource = Dt;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //ex.Message("","",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Warning);
            //}
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.dgv_users.Refresh();
        }
    }
}
