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
    public partial class uc_user_activities : UserControl
    {
        BL.CLS_Users us = new BL.CLS_Users();
        public uc_user_activities()
        {
            InitializeComponent();
           dgv_users.DataSource = us.GET_ALL_MONITER();
        }

        private void uc_user_activities_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            dgv_users.DataSource = us.GET_ALL_MONITER();
        }
    }
}
