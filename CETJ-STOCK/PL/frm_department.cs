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
    public partial class frm_department : Form
    {
        mainForm MF = new mainForm();
        public string state = "add";
        BL.CLS_Department Dep = new BL.CLS_Department();
      
        public frm_department()
        {
            InitializeComponent();

            this.dgv_department.DataSource = Dep.GET_ALL_DEPARTMNT();
        }


        // اضافة والحفظ
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                Dep.ADD_DEPARTMINT(txt_dep_name.Text);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_department.DataSource = Dep.GET_ALL_DEPARTMNT();
                txt_dep_id.Clear();
                txt_dep_name.Clear();
                
            }
            else
            {
                Dep.UPDATE_DEPARTMINT(Convert.ToInt32(txt_dep_id.Text), txt_dep_name.Text);

                MessageBox.Show("تمت التعديل بنجاح ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_department.DataSource = Dep.GET_ALL_DEPARTMNT();
                txt_dep_id.Clear();
                txt_dep_name.Clear();
            }
        }

        // زر الحذف 
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dep.DELETE_DEPARTMINT(this.dgv_department.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_department.DataSource = Dep.GET_ALL_DEPARTMNT();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            txt_dep_id.Text = this.dgv_department.CurrentRow.Cells[0].Value.ToString();
            txt_dep_name.Text = this.dgv_department.CurrentRow.Cells[1].Value.ToString();
            

            state = "update";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_dep_id.Clear();
            txt_dep_name.Clear();
        }
    }
}
