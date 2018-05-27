using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CETJ_STOCK.PL
{
    public partial class UserControl6 : UserControl
    {
        
        public UserControl6()
        {
            InitializeComponent();

           reSpend11.BringToFront();
        }

        private void tap_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            indicator.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            indicator.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            mf.label2.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            // CTL_Event.BringToFront();

        }

       

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            reSpend11.BringToFront();
            tap_Click(sender, e);
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            reSupplye1.BringToFront();
            tap_Click(sender, e);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            uc_FirstQTY1.BringToFront();
            tap_Click(sender, e);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            reCategory1.BringToFront();
            tap_Click(sender, e);
        }

     
    }
}
