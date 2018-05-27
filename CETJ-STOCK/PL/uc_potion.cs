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
    public partial class uc_potion : UserControl
    {
        public uc_potion()
        {
            InitializeComponent();
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            uc_option_db1.BringToFront();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
           uc_option_conect1.BringToFront();
        }
    }
}
