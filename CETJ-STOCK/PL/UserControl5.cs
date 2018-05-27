using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CETJ_STOCK.PL
{
    public partial class UserControl5 : UserControl
    {
        BL.CLS_Supplyer SPP = new BL.CLS_Supplyer();
        DataTable Dt = new DataTable();

        // اجراء لانشاء datatable
        void CreateDataTable()
        {
            
            Dt.Columns.Add("اسم المورد");
            Dt.Columns.Add("رقم الهاتف");
            Dt.Columns.Add("العنوان");
            Dt.Columns.Add("ملاحظات");

            dgv_supplyer.DataSource = Dt;
        }

        public UserControl5()
        {
            InitializeComponent();

            //CreateDataTable();
           // dgv_supplyer.DataSource = Dt;
            /* تعبئة الداتا قيرد فيو */
            this.dgv_supplyer.DataSource = SPP.GET_ALL_SUPPLYER();
        }


        // التحقق من اسم المورد
        private void txt_supplyer_name_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SPP.VerifySupplyer(txt_supplyer_name.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("اسم المورد  هذا موجود مسبقاً", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        // زر الاضافة
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_supplyer_name.Text != null || txt_supplyer_addrees.Text != null || txt_notes.Text != null || txt_supplyer_phone.Text != null)
            {
                SPP.ADD_SUPPLYER(txt_supplyer_name.Text, txt_supplyer_phone.Text, txt_supplyer_addrees.Text, txt_notes.Text);

                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_supplyer.DataSource = SPP.GET_ALL_SUPPLYER();
                ClearBoxes();

            }
            else
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // زر حذف المحدد
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تأكيد عميلة الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SPP.DeleteSupplyer(this.dgv_supplyer.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_supplyer.DataSource = SPP.GET_ALL_SUPPLYER();
            }
            else
            {
                MessageBox.Show("تمت الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // زر حذف الكل
        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            dgv_supplyer.Refresh();
        }

        // اجراء تنضيف الحقول
        void ClearBoxes()
        {
            txt_notes.Clear();
            txt_supplyer_addrees.Clear();
            txt_supplyer_name.Clear();
            txt_supplyer_phone.Clear();

        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            Dt = SPP.SearchSupplyer(txt_serch.Text);
            this.dgv_supplyer.DataSource = Dt;
        }
    }
}
