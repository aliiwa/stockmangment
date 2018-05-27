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
    public partial class reCategory : UserControl
    {
        BL.CLS_Reports_Screan RS = new BL.CLS_Reports_Screan();
        BL.CLS_Category CAT = new BL.CLS_Category();
        DataTable Dt = new DataTable();
        public reCategory()
        {
            InitializeComponent();
            Dt = RS.GET_ALL_CATEGORY();
            this.dgv_category.DataSource = Dt;

            /* كومبو بوكس الاقسام */
            cmb_dep.DataSource = CAT.GET_ALL_DEPARTMNT();
            cmb_dep.DisplayMember = "dep_name";
            cmb_dep.ValueMember = "dep_id";
            cmb_dep.SelectedItem = null;
            cmb_dep.SelectedText = "-- اختار --";

            /* كومبو بوكس التصنيفات */
            cmb_category.DataSource = CAT.GET_ALL_SUB_CAT();
            cmb_category.DisplayMember = "sub_cat_name";
            cmb_category.ValueMember = "sub_cat_id";
            cmb_category.SelectedItem = null;
            cmb_category.SelectedText = "-- اختار --";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(chk_cat_code.Checked == true)
            {
                
                Dt = RS.SearchCategory(txt_serch.Text);
                this.dgv_category.DataSource = Dt;
            }
            if(chk_category.Checked == true)
            {
            
                Dt = RS.SEARCH_RE_CAT_SUB_CAT(Convert.ToInt32(cmb_category.SelectedValue));
                this.dgv_category.DataSource = Dt;
            }

            if (chk_dep.Checked == true)
            {
                
                Dt = RS.SEARCH_RE_CAT_DEP(Convert.ToInt32(cmb_dep.SelectedValue));
                this.dgv_category.DataSource = Dt;
            }
        }


        /**************************************************************************************************/
        private void chk_cat_code_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cat_code.Checked == true)
            {
                chk_category.Checked = false;
                chk_dep.Checked = false;

            }
        }

        private void chk_category_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_category.Checked == true)
            {
                chk_cat_code.Checked = false;
                chk_dep.Checked = false;

            }
        }

        private void chk_dep_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_dep.Checked == true)
            {
                chk_category.Checked = false;
                chk_cat_code.Checked = false;
            }
        }

        private void btn_print_all_Click(object sender, EventArgs e)
        {
            RPT.rpt_category_dep cdp = new RPT.rpt_category_dep();
            RPT.rpt_cat_sub_cat csc = new RPT.rpt_cat_sub_cat();
            RPT.frm_report frm_rep = new RPT.frm_report();

            if (chk_dep.Checked)
            {
                cdp.SetDataSource(RS.SEARCH_RE_CAT_DEP(Convert.ToInt32(cmb_dep.SelectedValue)));
                frm_rep.crystalReportViewer1.ReportSource = cdp;
                frm_rep.ShowDialog();
            }

            if (chk_category.Checked)
            {

                cdp.SetDataSource(RS.SEARCH_RE_CAT_SUB_CAT(Convert.ToInt32(cmb_category.SelectedValue)));
                frm_rep.crystalReportViewer1.ReportSource = cdp;
                frm_rep.ShowDialog();
            }
        }
    }
}
