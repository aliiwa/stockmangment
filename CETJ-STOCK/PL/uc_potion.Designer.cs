namespace CETJ_STOCK.PL
{
    partial class uc_potion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_priv = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_user = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_option_db1 = new CETJ_STOCK.PL.uc_option_db();
            this.uc_option_conect1 = new CETJ_STOCK.PL.uc_option_conect();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_priv);
            this.panel1.Controls.Add(this.btn_add_user);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 71);
            this.panel1.TabIndex = 5;
            // 
            // btn_priv
            // 
            this.btn_priv.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_priv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_priv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_priv.BorderRadius = 0;
            this.btn_priv.ButtonText = "قاعدة البيانات";
            this.btn_priv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_priv.DisabledColor = System.Drawing.Color.Gray;
            this.btn_priv.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_priv.Iconimage = null;
            this.btn_priv.Iconimage_right = null;
            this.btn_priv.Iconimage_right_Selected = null;
            this.btn_priv.Iconimage_Selected = null;
            this.btn_priv.IconMarginLeft = 0;
            this.btn_priv.IconMarginRight = 0;
            this.btn_priv.IconRightVisible = true;
            this.btn_priv.IconRightZoom = 0D;
            this.btn_priv.IconVisible = true;
            this.btn_priv.IconZoom = 70D;
            this.btn_priv.IsTab = false;
            this.btn_priv.Location = new System.Drawing.Point(26, 12);
            this.btn_priv.Name = "btn_priv";
            this.btn_priv.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_priv.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_priv.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_priv.selected = false;
            this.btn_priv.Size = new System.Drawing.Size(483, 48);
            this.btn_priv.TabIndex = 93;
            this.btn_priv.Text = "قاعدة البيانات";
            this.btn_priv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_priv.Textcolor = System.Drawing.Color.White;
            this.btn_priv.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_priv.Click += new System.EventHandler(this.btn_priv_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_add_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_user.BorderRadius = 0;
            this.btn_add_user.ButtonText = "بيانات الاتصال";
            this.btn_add_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_user.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_user.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_user.Iconimage = null;
            this.btn_add_user.Iconimage_right = null;
            this.btn_add_user.Iconimage_right_Selected = null;
            this.btn_add_user.Iconimage_Selected = null;
            this.btn_add_user.IconMarginLeft = 0;
            this.btn_add_user.IconMarginRight = 0;
            this.btn_add_user.IconRightVisible = true;
            this.btn_add_user.IconRightZoom = 0D;
            this.btn_add_user.IconVisible = true;
            this.btn_add_user.IconZoom = 70D;
            this.btn_add_user.IsTab = false;
            this.btn_add_user.Location = new System.Drawing.Point(515, 12);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btn_add_user.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_add_user.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_user.selected = false;
            this.btn_add_user.Size = new System.Drawing.Size(483, 48);
            this.btn_add_user.TabIndex = 91;
            this.btn_add_user.Text = "بيانات الاتصال";
            this.btn_add_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_user.Textcolor = System.Drawing.Color.White;
            this.btn_add_user.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.uc_option_conect1);
            this.panel2.Controls.Add(this.uc_option_db1);
            this.panel2.Location = new System.Drawing.Point(13, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 543);
            this.panel2.TabIndex = 6;
            // 
            // uc_option_db1
            // 
            this.uc_option_db1.Location = new System.Drawing.Point(0, 6);
            this.uc_option_db1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_option_db1.Name = "uc_option_db1";
            this.uc_option_db1.Size = new System.Drawing.Size(1532, 1170);
            this.uc_option_db1.TabIndex = 0;
            // 
            // uc_option_conect1
            // 
            this.uc_option_conect1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_option_conect1.Location = new System.Drawing.Point(0, 3);
            this.uc_option_conect1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uc_option_conect1.Name = "uc_option_conect1";
            this.uc_option_conect1.Size = new System.Drawing.Size(1021, 543);
            this.uc_option_conect1.TabIndex = 1;
            // 
            // uc_potion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_potion";
            this.Size = new System.Drawing.Size(1047, 640);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_priv;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_user;
        private System.Windows.Forms.Panel panel2;
        private uc_option_conect uc_option_conect1;
        private uc_option_db uc_option_db1;
    }
}
