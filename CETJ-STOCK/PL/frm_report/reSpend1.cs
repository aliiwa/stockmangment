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
    public partial class reSpend1 : UserControl
    {
        BL.CLS_Reports_Screan RS = new BL.CLS_Reports_Screan();
        DataTable Dt = new DataTable();
        public reSpend1()
        {
            InitializeComponent();


            cmb_department.DataSource = RS.GET_ALL_DEPARTMNT();
            cmb_department.DisplayMember = "dep_name";
            cmb_department.ValueMember = "dep_id";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // بحث حسب رقم الصرف - القسم - بين تاريخين
            if( chk_dep.Checked || chk_b2d.Checked)
            { 
                Dt= RS.SEARCH_B2D_SPEND(txt_serch.Text,dt_from.Value,dt_to.Value,Convert.ToInt32(cmb_department.SelectedValue));
                this.dgv_spend.DataSource = Dt;
            }
            // بحث حسب رقم الصرف
             if(chk_spend_code.Checked)
            {
                Dt = RS.SEARCH_RE_SPEND_1(txt_serch.Text);
                this.dgv_spend.DataSource = Dt;
            }
            // بحث حسب القسم 
            if (chk_dep.Checked)
            {
                Dt = RS.SEARCH_RE_SPEND_2(Convert.ToInt32(cmb_department.SelectedValue));
                this.dgv_spend.DataSource = Dt;
            }

            // بحث حسب بين تاريخين 

            if (chk_b2d.Checked)
            {
                Dt = RS.SEARCH_RE_SPEND_3(dt_from.Value, dt_to.Value);
                this.dgv_spend.DataSource = Dt;
            }

            // بحث حسب تاريخ معين

            if (chk_date.Checked)
            {
                Dt = RS.SEARCH_RE_SPEND_4(dt_date.Value);
                this.dgv_spend.DataSource = Dt;
            }


           


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            RPT.rpt_spend_b2d rep = new RPT.rpt_spend_b2d();
            RPT.rpt_spend_code spc = new RPT.rpt_spend_code();
            RPT.rpt_spend_date rpd = new RPT.rpt_spend_date();
            RPT.rpt_spend_dep rpdp = new RPT.rpt_spend_dep();
            RPT.frm_report frm_rep = new RPT.frm_report();



            // بحث حسب تاريخ معين

            if (chk_b2d.Checked)
            {
                rep.SetDataSource(RS.SEARCH_RE_SPEND_3(dt_from.Value, dt_to.Value));
                frm_rep.crystalReportViewer1.ReportSource = rep;
                frm_rep.ShowDialog();
            }

            if (chk_date.Checked)
            {
               

                rpd.SetDataSource(RS.SEARCH_RE_SPEND_4(dt_date.Value));
                frm_rep.crystalReportViewer1.ReportSource = rpd;
                frm_rep.ShowDialog();
            }

            // بحث حسب رقم الصرف
            if (chk_spend_code.Checked)
            {
                
                spc.SetDataSource(RS.SEARCH_RE_SPEND_1(txt_serch.Text));
                frm_rep.crystalReportViewer1.ReportSource = spc;
                frm_rep.ShowDialog();
            }

            // بحث حسب القسم 
            if (chk_dep.Checked)
            {
                

                rpdp.SetDataSource(RS.SEARCH_RE_SPEND_2(Convert.ToInt32(cmb_department.SelectedValue)));
                frm_rep.crystalReportViewer1.ReportSource = rpdp;
                frm_rep.ShowDialog();
            }
        }

        private void dgv_spend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //طباعة المحدد
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            RPT.rpt_spend_1 rsp1 = new RPT.rpt_spend_1();
            RPT.frm_report frm = new RPT.frm_report();

            rsp1.SetDataSource(RS.SEARCH_RE_SPEND_1(this.dgv_spend.CurrentRow.Cells[1].Value.ToString()));
            frm.crystalReportViewer1.ReportSource = rsp1;
            frm.ShowDialog();

        }
    }
}
