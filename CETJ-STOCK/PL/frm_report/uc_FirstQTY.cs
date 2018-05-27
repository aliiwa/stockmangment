using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CETJ_STOCK.PL.frm_report
{
    public partial class uc_FirstQTY : UserControl
    {
        BL.CLS_Reports_Screan RS = new BL.CLS_Reports_Screan();
        DataTable Dt = new DataTable();
        public uc_FirstQTY()
        {
            InitializeComponent();
            Dt = RS.GET_FIRST_QTE();
            this.dgv_supplye.DataSource = Dt;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Dt = RS.SearchCategory(txt_serch.Text)
            Dt = RS.SERACH_FIRST_QTY(dt_date.Value);
            this.dgv_supplye.DataSource = Dt;
        }

        private void txt_serch_TextChanged(object sender, EventArgs e)
        {
           // Dt = RS.SearchCategory(txt_serch.Text);
            this.dgv_supplye.DataSource = Dt;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm_close_QTY frm = new frm_close_QTY();
            frm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            RPT.rpt_first_qty qty = new RPT.rpt_first_qty();
            RPT.frm_report frm = new RPT.frm_report();

            qty.SetDataSource(RS.GET_FIRST_QTE_PRINT(Convert.ToDateTime( this.dgv_supplye.CurrentRow.Cells[0].Value.ToString())));
            frm.crystalReportViewer1.ReportSource = qty;
            frm.ShowDialog();
        }
    }
}
