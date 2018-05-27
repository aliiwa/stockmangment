namespace CETJ_STOCK.PL
{
    partial class frm_login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.BunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(333, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "تسجيل الدخول";
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "دخول";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = null;
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 0;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 70D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(329, 300);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(248, 48);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "دخول";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_username.Location = new System.Drawing.Point(329, 149);
            this.txt_username.Name = "txt_username";
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_username.Size = new System.Drawing.Size(248, 27);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_password.Location = new System.Drawing.Point(329, 217);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_password.Size = new System.Drawing.Size(248, 27);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // BunifuFlatButton10
            // 
            this.BunifuFlatButton10.Activecolor = System.Drawing.Color.Red;
            this.BunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuFlatButton10.BorderRadius = 0;
            this.BunifuFlatButton10.ButtonText = "";
            this.BunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.BunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.BunifuFlatButton10.Iconimage = ((System.Drawing.Image)(resources.GetObject("BunifuFlatButton10.Iconimage")));
            this.BunifuFlatButton10.Iconimage_right = null;
            this.BunifuFlatButton10.Iconimage_right_Selected = null;
            this.BunifuFlatButton10.Iconimage_Selected = null;
            this.BunifuFlatButton10.IconMarginLeft = 0;
            this.BunifuFlatButton10.IconMarginRight = 0;
            this.BunifuFlatButton10.IconRightVisible = false;
            this.BunifuFlatButton10.IconRightZoom = 0D;
            this.BunifuFlatButton10.IconVisible = true;
            this.BunifuFlatButton10.IconZoom = 65D;
            this.BunifuFlatButton10.IsTab = false;
            this.BunifuFlatButton10.Location = new System.Drawing.Point(572, 12);
            this.BunifuFlatButton10.Name = "BunifuFlatButton10";
            this.BunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.Red;
            this.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.BunifuFlatButton10.selected = false;
            this.BunifuFlatButton10.Size = new System.Drawing.Size(30, 30);
            this.BunifuFlatButton10.TabIndex = 7;
            this.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BunifuFlatButton10.Textcolor = System.Drawing.Color.White;
            this.BunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuFlatButton10.Click += new System.EventHandler(this.BunifuFlatButton10_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 384);
            this.Controls.Add(this.BunifuFlatButton10);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton10;
    }
}