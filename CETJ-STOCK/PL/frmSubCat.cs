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
    public partial class frmSubCat : Form
    {
        public string state = "add";
        BL.CLS_Sub_Cat SC = new BL.CLS_Sub_Cat();
        public frmSubCat()
        {
            InitializeComponent();
            this.dgv_sub_cat.DataSource = SC.GET_ALL_SUB_CAT();
        }

        //  زر جديد
        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_sub_cat_id.Clear();
            txt_sub_cat_name.Clear();
            
        }

       

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (state == "add")
            {
                SC.ADD_SUB_CAT(txt_sub_cat_name.Text);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_sub_cat.DataSource = SC.GET_ALL_SUB_CAT();
                txt_sub_cat_id.Clear();
                txt_sub_cat_name.Clear();

            }
            else
            {
                SC.UPDATE_SUB_CAT(Convert.ToInt32(txt_sub_cat_id.Text), txt_sub_cat_name.Text);

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_sub_cat.DataSource = SC.GET_ALL_SUB_CAT();
                txt_sub_cat_id.Clear();
                txt_sub_cat_name.Clear();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SC.DELETE_SUB_CAT(this.dgv_sub_cat.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_sub_cat.DataSource = SC.GET_ALL_SUB_CAT();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_sub_cat_id.Text = this.dgv_sub_cat.CurrentRow.Cells[0].Value.ToString();
            txt_sub_cat_name.Text = this.dgv_sub_cat.CurrentRow.Cells[1].Value.ToString();


            state = "update";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
