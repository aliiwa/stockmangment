using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CETJ_STOCK.PL
{
    public partial class mainForm : Form
    {
        BL.CLS_Users us = new BL.CLS_Users();
        BL.CLS_Users USR = new BL.CLS_Users();
        uc_user_activities uac = new uc_user_activities(); 
        
        DataTable dt = new DataTable();
        string mode = Properties.Settings.Default.mode;
        public mainForm()
        {
            InitializeComponent();
            
            uc_main71.BringToFront();
            check_priv();
            
        }

        private void tap_Click(object sender, EventArgs e)
        {

            indicator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            indicator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            label1.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            userControl11.BringToFront();
            // CTL_Event.BringToFront();

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);

            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض ";
            string screens = "الاصناف";

            USR.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            userControl11.BringToFront();
            //PL.CTL_Product.BringToFront();
        }

        private void btnSpend_Click(object sender, EventArgs e)
        {

            
            tap_Click(sender, e);


            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض ";
            string screens = "الصرف";

            USR.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            userControl21.BringToFront();
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
           
            tap_Click(sender, e);


            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض ";
            string screens = "التوريد";

            USR.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            userControl31.BringToFront();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);
           uc_inv_back1.BringToFront();

        }

        private void btnSupplyer_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);


            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض ";
            string screens = "الموردين";

            USR.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            userControl51.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);


            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض ";
            string screens = "التقارير";

            USR.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            userControl61.BringToFront();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);


            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض ";
            string screens = "المستخدمين";

            USR.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            uc_users1.BringToFront();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);


            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض ";
            string screens = "الاحداث";

            USR.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            uc_user_activities1.BringToFront();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            tap_Click(sender, e);


            /****************************************************/
            int useer_id = Properties.Settings.Default.user_id;
            DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            string time = DateTime.Now.ToLongTimeString();
            string process = "عرض ";
            string screens = "الاعدادت";

            USR.ADD_MONITER(useer_id, date, time, process, screens);
            uac.dgv_users.DataSource = us.GET_ALL_MONITER();
            /****************************************************/

            uc_potion1.BringToFront();
        }


        private void check_priv()
        {
            int user_id = Properties.Settings.Default.user_id;

            dt = us.GET_ALL_DIS(user_id);
            //if(dt.Rows[0][0].ToString() == "false" || dt.Rows[0][0].ToString() == string.Empty)
            //{
            //    MessageBox.Show("لا يمكن عرض هذي الصفحة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }


        /* private void btnCategory_KeyDown(object sender, KeyEventArgs e)
         {
             if(e.KeyCode == Keys.C)
             {
                 //userControl11.BringToFront();
                 userControl61.BringToFront();
             }
         }*/
    }
}
