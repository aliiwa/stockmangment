using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CETJ_STOCK.PL
{
    public partial class UserControl1 : UserControl
    {
        public string state = "add";
        BL.CLS_Category CAT = new BL.CLS_Category();
        BL.CLS_Users USR = new BL.CLS_Users();
        public UserControl1()
        {
            InitializeComponent();
            /*  تعبئة الكومبو بوكس */
                /* كومبو بكوس الوحدات */
            cmb_units.DataSource = CAT.GET_ALL_UNITS();
            cmb_units.DisplayMember = "unit_name";
            cmb_units.ValueMember = "unit_id";
            cmb_units.SelectedItem = null;
            cmb_units.SelectedText = "-- اختار --";


            /* كومبو بوكس الاقسام */
            cmb_department.DataSource = CAT.GET_ALL_DEPARTMNT();
            cmb_department.DisplayMember = "dep_name";
            cmb_department.ValueMember = "dep_id";
            cmb_department.SelectedItem = null;
            cmb_department.SelectedText = "-- اختار --";

            /* كومبو بوكس التصنيفات */
            cmb_sub_cat.DataSource = CAT.GET_ALL_SUB_CAT();
            cmb_sub_cat.DisplayMember = "sub_cat_name";
            cmb_sub_cat.ValueMember = "sub_cat_id";
            cmb_sub_cat.SelectedItem = null;
            cmb_sub_cat.SelectedText = "-- اختار --";

            /* تعبئة الداتا قيرد فيو */
            this.dgv_cat.DataSource = CAT.GET_ALL_CATEGORY();
            /*******************************************/
        }



        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }

        
        // اجراء الحفظ
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_ID_Cat.Text == string.Empty && txt_cat_name.Text == string.Empty && txt_quantity.Text == string.Empty)
            
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (state == "add")
            {
                CAT.ADD_CATEGORY(
                txt_ID_Cat.Text, txt_cat_name.Text, txt_quantity.Text, Convert.ToInt32(cmb_department.SelectedValue),
                Convert.ToInt32(cmb_units.SelectedValue), Convert.ToInt32(cmb_sub_cat.SelectedValue));

                int useer_id =  Properties.Settings.Default.user_id;
                DateTime date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                string time = DateTime.Now.ToLongTimeString();
                string process = "اضافة";
                string screens = "الاصناف";

                USR.ADD_MONITER(useer_id, date, time, process, screens);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_cat.DataSource = CAT.GET_ALL_CATEGORY();
                txt_ID_Cat.Text = " ";
                txt_cat_name.Text = " ";
                cmb_units.Text = " ";
                cmb_department.Text = " ";
                cmb_sub_cat.Text = " ";
                txt_quantity.Text = " ";
            }
            else
            {
                CAT.UPDATE_CATEGORY(
                txt_ID_Cat.Text, txt_cat_name.Text, txt_quantity.Text, Convert.ToInt32(cmb_department.SelectedValue),
                Convert.ToInt32(cmb_units.SelectedValue), Convert.ToInt32(cmb_sub_cat.SelectedValue));

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_cat.DataSource = CAT.GET_ALL_CATEGORY();
                txt_ID_Cat.Text = " ";
                txt_cat_name.Text = " ";
                cmb_units.Text = " ";
                cmb_department.Text = " ";
                cmb_sub_cat.Text = " ";
                txt_quantity.Text = " ";
            }

            
        }


        // اجراء للتحقق من النص اذا كان رقم او حرف
        private void only_numper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // اجراء البحث
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CAT.SearchCategory(txt_search.Text);
            this.dgv_cat.DataSource = dt;
        }
        // اجراء الحذف
        private void btn_delate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                CAT.DeleteCategory(this.dgv_cat.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_cat.DataSource = CAT.GET_ALL_CATEGORY();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // زر التعديل
        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_ID_Cat.Text = this.dgv_cat.CurrentRow.Cells[0].Value.ToString();
            txt_cat_name.Text = this.dgv_cat.CurrentRow.Cells[1].Value.ToString();
            cmb_units.Text = this.dgv_cat.CurrentRow.Cells[2].Value.ToString();
            cmb_sub_cat.Text = this.dgv_cat.CurrentRow.Cells[3].Value.ToString();
            cmb_department.Text = this.dgv_cat.CurrentRow.Cells[4].Value.ToString();
            txt_quantity.Text = this.dgv_cat.CurrentRow.Cells[5].Value.ToString();
            
            
    
            state = "update";
            txt_ID_Cat.ReadOnly = true;
            txt_quantity.ReadOnly = true;
            btn_save.Enabled = true;
        }


        // زر جديد
        private void btn_new_Click(object sender, EventArgs e)
        {

            txt_ID_Cat.Text = " ";
            txt_cat_name.Text = " ";
            cmb_units.Text = " ";
            cmb_department.Text = " ";
            cmb_sub_cat.Text = " ";
            txt_quantity.Text = " ";
            txt_ID_Cat.Text = CAT.MAX_CAT_ID().Rows[0][0].ToString();
            btn_save.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // cmb_department.ValueMember = "dep_id";
            //textBox1.Text = cmb_department.SelectedValue(;
           // cmb_department.ValueMember = "dep_id";
        }

        // عرض فورم الحودات
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            frm_units frm = new frm_units();
            frm.ShowDialog();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            frm_department frm = new frm_department();
            
            frm.ShowDialog();
            

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            frmSubCat frm = new frmSubCat();
            frm.ShowDialog();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
