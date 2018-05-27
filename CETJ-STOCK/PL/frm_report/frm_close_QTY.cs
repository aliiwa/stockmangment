using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CETJ_STOCK.PL.frm_report
{
    public partial class frm_close_QTY : Form
    {
        BL.CLS_Reports_Screan RC = new BL.CLS_Reports_Screan();
        public frm_close_QTY()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RC.ADD_FIRST_QTY(dt_qty.Value);
            MessageBox.Show("تمت الاضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
