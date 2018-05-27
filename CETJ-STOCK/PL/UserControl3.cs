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
    public partial class UserControl3 : UserControl
    {
        BL.CLS_Supplye SPY = new BL.CLS_Supplye();
        DataTable Dt = new DataTable();

        // اجراء لانشاء datatable
        void CreateDataTable()
        {
            Dt.Columns.Add("رقم الصنف");
            Dt.Columns.Add("اسم الصنف");
            Dt.Columns.Add("الوحدة");
            Dt.Columns.Add("الرصيد");
            Dt.Columns.Add("الكمية");

            dgv_supplye.DataSource = Dt;
        }

        /*void reSizeDGV()
        {

            this.dgv_supplye.RowHeadersWidth = 199;
            this.dgv_supplye.Columns[0].Width = 150;
            this.dgv_supplye.Columns[1].Width = 168;
            this.dgv_supplye.Columns[2].Width = 160;
            this.dgv_supplye.Columns[3].Width = 160;
            this.dgv_supplye.Columns[4].Width = 160;
        }
        */
        public UserControl3()
        {
            InitializeComponent();
            CreateDataTable();
            /*  تعبئة الكومبو بوكس الاقسام */
            cmb_supplyer_id.DataSource = SPY.GET_ALL_SUPPLYER();
            cmb_supplyer_id.DisplayMember = "supplyer_name";
            cmb_supplyer_id.ValueMember = "supplyer_id";

        }

        // اجراء تنضيف الحقول
        void ClearBoxes()
        {
            txt_supplye_code.Clear();
            txt_invoice.Clear();

        }

        void ClearTextBoxes()
        {

            txt_cat_id.Clear();
            txt_cat_name.Clear();
            txt_cat_unit.Clear();
            txt_qte_in_stock.Clear();
            txt_qte.Clear();

        }

        // التحقق من اذن الاستلام هل هو موجوج او لا
        private void txt_supplye_code_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SPY.VerifySupplye(txt_supplye_code.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("رقم اذن الصرف هذا موجود مسبقاً", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // زر الحفظ والاضافة
       private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_supplye_code.Text != string.Empty && txt_invoice.Text != string.Empty)
            {
                SPY.ADD_SUPPLYE(txt_supplye_code.Text,dt_supplye.Value,Convert.ToInt32(cmb_supplyer_id.SelectedValue),Convert.ToInt32(txt_invoice.Text));

                for (int i = 0; i < dgv_supplye.Rows.Count - 1; i++)
                {
                    SPY.ADD_SUPPLYE_DETAILS(
                        dgv_supplye.Rows[i].Cells[0].Value.ToString(),
                        dgv_supplye.Rows[i].Cells[1].Value.ToString(),
                        dgv_supplye.Rows[i].Cells[2].Value.ToString(),
                        Convert.ToInt32(dgv_supplye.Rows[i].Cells[4].Value),
                        txt_supplye_code.Text
                        );
                }
                MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // جلب قيم الاصناف من فورم اخيار الاصناف 
        private void btn_choes_cat_Click(object sender, EventArgs e)
        {
            frm_chose_cat frm = new frm_chose_cat();
            frm.ShowDialog();
            txt_cat_id.Text = frm.dgv_choes_cat.CurrentRow.Cells[0].Value.ToString();
            txt_cat_name.Text = frm.dgv_choes_cat.CurrentRow.Cells[1].Value.ToString();
            txt_cat_unit.Text = frm.dgv_choes_cat.CurrentRow.Cells[2].Value.ToString();
            txt_qte_in_stock.Text = frm.dgv_choes_cat.CurrentRow.Cells[5].Value.ToString();
            txt_qte.Focus();
        }

        // منع ادخال القيم الغير رقيمة الي الحقل
        private void acceptOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_qte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_qte.Text != string.Empty)
            {

                DataRow r = Dt.NewRow();

                if (Convert.ToInt32(txt_qte.Text) == 0 || Convert.ToInt32(txt_qte.Text) < 0)
                {
                    MessageBox.Show(" الكمية المدخلة غير موحودة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_qte.Clear();
                    return;

                }

                for (int i = 0; i < dgv_supplye.Rows.Count - 1; i++)
                {
                    if (dgv_supplye.Rows[i].Cells[0].Value.ToString() == txt_cat_id.Text)
                    {
                        MessageBox.Show("هذا الصنف موجد مسبقاً", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                r[0] = txt_cat_id.Text;
                r[1] = txt_cat_name.Text;
                r[2] = txt_cat_unit.Text;
                r[3] = txt_qte_in_stock.Text;
                r[4] = txt_qte.Text;

                Dt.Rows.Add(r);
                dgv_supplye.DataSource = Dt;

                ClearTextBoxes();
            }
        }

       

        // تعبة قيمة الداتا قيرد فيو في حقول الادخال لغرض التعديل فيها
        private void dgv_supplye_DoubleClick_1(object sender, EventArgs e)
        {
            txt_cat_id.Text = this.dgv_supplye.CurrentRow.Cells[0].Value.ToString();
            txt_cat_name.Text = this.dgv_supplye.CurrentRow.Cells[1].Value.ToString();
            txt_cat_unit.Text = this.dgv_supplye.CurrentRow.Cells[2].Value.ToString();
            txt_qte_in_stock.Text = this.dgv_supplye.CurrentRow.Cells[3].Value.ToString();
            txt_qte.Text = this.dgv_supplye.CurrentRow.Cells[4].Value.ToString();
            dgv_supplye.Rows.RemoveAt(dgv_supplye.CurrentRow.Index);
            txt_qte.Focus();
        }

        // زر حذف المحدد
        private void btn_delete_Click(object sender, EventArgs e)
        {
            dgv_supplye.Rows.RemoveAt(dgv_supplye.CurrentRow.Index);
        }

        // زر حذف الكل
        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            dgv_supplye.Refresh();
        }
    }
}
