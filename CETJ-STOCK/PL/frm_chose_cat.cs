using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CETJ_STOCK.PL
{
    
    public partial class frm_chose_cat : Form
    {
        BL.CLS_Category CCat = new BL.CLS_Category();
        public frm_chose_cat()
        {
            InitializeComponent();
            this.dgv_choes_cat.DataSource = CCat.GET_ALL_CATEGORY();
        }

        private void txt_spend_code_TextChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = CCat.SearchCategory(txt_spend_code.Text);
            this.dgv_choes_cat.DataSource = dt1;
        }

        private void dgv_choes_cat_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }


    }
}
