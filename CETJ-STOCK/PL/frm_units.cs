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
    public partial class frm_units : Form
    {
        //internal static readonly object showDi;
        public string state = "add";
        BL.CLS_Units UN = new BL.CLS_Units();
        public frm_units()
        {
            InitializeComponent();
            this.dgv_unit.DataSource = UN.GET_ALL_UNITS();
        }
       
        // زر الخروج
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Close();
        }
        // زر التعديل
      /*  private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_unit_id.Text = this.dgv_unit.CurrentRow.Cells[0].Value.ToString();
            txt_unit_name.Text = this.dgv_unit.CurrentRow.Cells[1].Value.ToString();
            txt_unit_code_ar.Text = this.dgv_unit.CurrentRow.Cells[2].Value.ToString();
            txt_unit_code_en.Text = this.dgv_unit.CurrentRow.Cells[3].Value.ToString();

            state = "update";

            
        }*/
        // زر التعديل
        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            txt_unit_id.Text = this.dgv_unit.CurrentRow.Cells[0].Value.ToString();
            txt_unit_name.Text = this.dgv_unit.CurrentRow.Cells[1].Value.ToString();
            txt_unit_code_ar.Text = this.dgv_unit.CurrentRow.Cells[2].Value.ToString();
            txt_unit_code_en.Text = this.dgv_unit.CurrentRow.Cells[3].Value.ToString();

            state = "update";
        }


        // زر الحذف
        private void btn_deleate_unit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                UN.DeleteUnit(this.dgv_unit.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_unit.DataSource = UN.GET_ALL_UNITS();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }


        // زر الحفظ ( الاضافة والتعديل) ت
        private void btn_save_unit_Click_1(object sender, EventArgs e)
        {
            if (state == "add")
            {
                UN.ADD_UNITS(txt_unit_name.Text, txt_unit_code_ar.Text, txt_unit_code_en.Text);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_unit.DataSource = UN.GET_ALL_UNITS();
                txt_unit_id.Clear();
                txt_unit_name.Clear();
                txt_unit_code_ar.Clear();
                txt_unit_code_en.Clear();
            }
            else
            {
                UN.UPDATE_UNITS(Convert.ToInt32(txt_unit_id.Text), txt_unit_name.Text, txt_unit_code_ar.Text, txt_unit_code_en.Text);

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_unit.DataSource = UN.GET_ALL_UNITS();
                txt_unit_id.Clear();
                txt_unit_name.Clear();
                txt_unit_code_ar.Clear();
                txt_unit_code_en.Clear();
            }
        }
        // زر الخرود
        private void btn_colse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_unit_id.Clear();
            txt_unit_name.Clear();
            txt_unit_code_ar.Clear();
            txt_unit_code_en.Clear();
        }
    }
}
