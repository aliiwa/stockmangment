using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CETJ_STOCK.PL
{

    public partial class uc_inv_back : UserControl
    {
        BL.CLS_inv_back inb = new BL.CLS_inv_back();
        BL.CLS_Reports_Screan rpt = new BL.CLS_Reports_Screan();
        DataTable Dt = new DataTable();

        void CreateDataTable()
        {
           

           // dgv_inv_back.DataSource = Dt;
        }

        public uc_inv_back()
        {
            InitializeComponent();

           // this.dgv_inv_back.DataSource = inb.SEARCH_INV_BACK_1();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // this.dgv_inv_back.DataSource = inb.SEARCH_INV_BACK_2(textBox1.Text);
            
        }

        private void dgv_inv_back_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string colName = dgv_inv_back.Columns(e,columns).Name();
            //this.dgv_category.DataSource = rpt.SEARCH_RE_SPEND_1(dgv_inv_back.CurrentRow.Cells[3].Value.ToString());
        }

        private void dgv_inv_back_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //for (int i = 0; i < dgv_inv_back.Rows.Count - 1; i++)
            //{
            //    dgv_inv_back.Rows[i].Cells[0].Value = "موافق";
            //    dgv_inv_back.Rows[i].Cells[1].Value = "عرض";

            //    this.dgv_inv_back.Columns[0].Width = 130;
            //    this.dgv_inv_back.Columns[1].Width = 130;

            //    dgv_inv_back.Rows[0].Height = 30;
            //    dgv_inv_back.Rows[1].Height = 30;
            //}
        }

       

        private void btn_search_Click(object sender, EventArgs e)
        {
           // txt_spend_code.Text = r ;
            this.dgv_category.DataSource = rpt.SEARCH_RE_SPEND_1(txt_search.Text);
        }
    }
}
