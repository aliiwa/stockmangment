using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CETJ_STOCK.PL.frm_report
{
    public partial class reSupplye : UserControl
    {
        BL.CLS_Reports_Screan RS = new BL.CLS_Reports_Screan();
        DataTable Dt = new DataTable();
        public reSupplye()
        {
            InitializeComponent();

            cmb_supplye.DataSource = RS.GET_ALL_SUPPLYER();
            cmb_supplye.DisplayMember = "supplyer_name";
            cmb_supplye.ValueMember = "supplyer_id";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            // بحث حسب رقم الاستلام
            if (chk_suplye_code.Checked)
            {
                Dt = RS.SEARCH_RE_SUPPLYE_1(txt_serch.Text);
                this.dgv_supplye.DataSource = Dt;
            }

            // حسب المورد
            if (chk_supplyer.Checked)
            {
                Dt = RS.SEARCH_RE_SUPPLYE_2(Convert.ToInt32(cmb_supplye.SelectedValue));
                this.dgv_supplye.DataSource = Dt;
            }

            // بحث حسب بين تاريخين 

            if (chk_b2d.Checked)
            {
                Dt = RS.SEARCH_RE_SUPPLYE_3(dt_from.Value, dt_to.Value);
                this.dgv_supplye.DataSource = Dt;
            }

            // بحث حسب التاريخ 

            if (chk_date.Checked)
            {
                Dt = RS.SEARCH_RE_SUPPLYE_4(dt_date.Value);
                this.dgv_supplye.DataSource = Dt;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            RPT.rpt_supplaye_code rpc = new RPT.rpt_supplaye_code();
            RPT.rpt_supplay_date rpd = new RPT.rpt_supplay_date();
            RPT.rpt_supplay_b2d b2d = new RPT.rpt_supplay_b2d();
            RPT.frm_report frm_rep = new RPT.frm_report();

            // بحث حسب رقم الصرف
            if (chk_suplye_code.Checked)
            {

                rpc.SetDataSource(RS.SEARCH_RE_SUPPLYE_1(txt_serch.Text));
                frm_rep.crystalReportViewer1.ReportSource = rpc;
                frm_rep.ShowDialog();
            }
            // بحث حسب التاريخ
            if (chk_date.Checked)
            {
                rpd.SetDataSource(RS.SEARCH_RE_SUPPLYE_4(dt_date.Value));
                frm_rep.crystalReportViewer1.ReportSource = rpd;
                frm_rep.ShowDialog();
            }

            // بحث حسب بين تاريخين 

            if (chk_b2d.Checked)
            {
             
                b2d.SetDataSource(RS.SEARCH_RE_SUPPLYE_3(dt_from.Value, dt_to.Value));
                frm_rep.crystalReportViewer1.ReportSource = b2d;
                frm_rep.ShowDialog();
            }

        }
    }
}
