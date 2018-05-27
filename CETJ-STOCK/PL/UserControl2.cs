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
    public partial class UserControl2 : UserControl
    {
        public string state = "add";
        BL.CLS_Spend SP = new BL.CLS_Spend();
        DataTable Dt = new DataTable();

        // اجراء لانشاء datatable
        void CreateDataTable()
        {
            Dt.Columns.Add("رقم الصنف");
            Dt.Columns.Add("اسم الصنف");
            Dt.Columns.Add("الوحدة");
            Dt.Columns.Add("الرصيد");
            Dt.Columns.Add("الكمية");

            dgv_spend.DataSource = Dt;
        }

        // تعديل قياسات داتا قيرد فيو
        void reSizeDGV()
        {

            this.dgv_spend.RowHeadersWidth = 199;
            this.dgv_spend.Columns[0].Width = 150;
            this.dgv_spend.Columns[1].Width = 168;
            this.dgv_spend.Columns[2].Width = 160;
            this.dgv_spend.Columns[3].Width = 160;
            this.dgv_spend.Columns[4].Width = 160;
        }

        public UserControl2()
        {
            InitializeComponent();

            CreateDataTable();
            //reSizeDGV();

            /*  تعبئة الكومبو بوكس الاقسام */
            cmb_department.DataSource = SP.GET_ALL_DEPARTMNT();
            cmb_department.DisplayMember = "dep_name";
            cmb_department.ValueMember = "dep_id";

            //this.dgv_spend.DataSource = SP.GET_ALL_SPEND();
        }

        // اجراء تنضيف الحقول 
        void ClearBoxes()
        {

            txt_cat_id.Clear();
            txt_cat_name.Clear();
            txt_cat_unit.Clear();
            txt_qte_in_stock.Clear();
            txt_qte.Clear();
            
            //txt_spend_code.Clear();

        }

        // التحقق من اذن الصرف اذا كان موجود او لا
        private void txt_spend_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SP.VerifySpend(txt_spend_code.Text);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("رقم اذن الصرف هذا موجود مسبقاً", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // زر الاضافة والحفظ
        private void btn_add_Click(object sender, EventArgs e)
        {

            
            if (txt_spend_code.Text != string.Empty )
            {
                SP.ADD_SPEND(txt_spend_code.Text, dt_spend.Value, Convert.ToInt32(cmb_department.SelectedValue));
                for(int i =0; i<dgv_spend.Rows.Count-1; i++)
                 {
                     SP.ADD_SPEND_DETALIS(
                         dgv_spend.Rows[i].Cells[0].Value.ToString(),
                         dgv_spend.Rows[i].Cells[1].Value.ToString(), 
                         dgv_spend.Rows[i].Cells[2].Value.ToString(),
                         Convert.ToInt32( dgv_spend.Rows[i].Cells[4].Value),
                         txt_spend_code.Text
                         );
                 }
                 MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                dgv_spend.DataSource = Dt;
                ClearBoxes();
                txt_spend_code.Clear();
                Dt.Rows.Clear();
                /*dgv_spend.DataSource = null;
                dgv_spend.Refresh();
                dgv_spend.Rows.Clear();
                /*this.dgv_spend.DataSource = SP.GET_ALL_DEPARTMNT();
                txt_spend_code.Clear();
                txt_dep_name.Clear();*/
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
            if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        

        // اجراء تعبئة قيم الحقول الي داتا قيرد فيو 
        private void txt_qte_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter && txt_qte.Text != string.Empty)
            {
                if(SP.VerifyQuantity(txt_cat_id.Text,Convert.ToInt32(txt_qte.Text)).Rows.Count <1 || Convert.ToInt32(txt_qte.Text) == 0 || Convert.ToInt32(txt_qte.Text) < 0)
                {
                    MessageBox.Show(" الكمية المدخلة غير موحودة", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_qte.Clear();
                    return;
                   
                }
                DataRow r = Dt.NewRow();

                for (int i = 0; i < dgv_spend.Rows.Count - 1; i++)
                {
                    if (dgv_spend.Rows[i].Cells[0].Value.ToString() == txt_cat_id.Text)
                    {
                        MessageBox.Show("هذا الصنف موجد مسبقاً", "تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                r[0] = txt_cat_id.Text ;
                r[1] = txt_cat_name.Text;
                r[2] = txt_cat_unit.Text;
                r[3] = txt_qte_in_stock.Text;
                r[4] = txt_qte.Text;
                //Dt.Rows.Clear();
                Dt.Rows.Add(r);
                dgv_spend.DataSource = Dt;
 
                ClearBoxes();
            }
        }

        // تعبة قيمة الداتا قيرد فيو في حقول الادخال لغرض التعديل فيها
        private void dgv_spend_DoubleClick(object sender, EventArgs e)
        {
            
            txt_cat_id.Text         = this.dgv_spend.CurrentRow.Cells[0].Value.ToString();
            txt_cat_name.Text       = this.dgv_spend.CurrentRow.Cells[1].Value.ToString();
            txt_cat_unit.Text       = this.dgv_spend.CurrentRow.Cells[2].Value.ToString();
            txt_qte_in_stock.Text   = this.dgv_spend.CurrentRow.Cells[3].Value.ToString();
            txt_qte.Text            = this.dgv_spend.CurrentRow.Cells[4].Value.ToString();
            dgv_spend.Rows.RemoveAt(dgv_spend.CurrentRow.Index);
            txt_qte.Focus();
        }

        // زر زيادة كمية الصنف
        private void button1_Click(object sender, EventArgs e)
        {
            //int qte = Convert.ToInt32(txt_qte.Text);
            //int qte_stock = Convert.ToInt32(txt_qte_in_stock.Text);
            //if( qte > qte_stock)
            //{
            //    MessageBox.Show

            //}

            if (txt_qte.Text == string.Empty )
            {
                txt_qte.Text = (Convert.ToInt32(1)).ToString();

            }
            else
            {
                txt_qte.Text = (Convert.ToInt32(txt_qte.Text) + 1).ToString();
            }
        }


        // زر انقاص الكمية 
        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_qte.Text = (Convert.ToInt32(txt_qte.Text) - 1).ToString();
        }


        // زر حذف المحدد
        private void btn_delete_Click(object sender, EventArgs e)
        {
            dgv_spend.Rows.RemoveAt(dgv_spend.CurrentRow.Index);
        }

        // زر حذف الكل
        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            dgv_spend.Refresh();
        }

        // زر البحث عن اذونات الصرف
        private void btn_serch_Click(object sender, EventArgs e)
        {
            frm_spend_serch FRM1 = new frm_spend_serch();
            FRM1.ShowDialog();
        }
    }



}
