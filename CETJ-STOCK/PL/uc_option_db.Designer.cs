namespace CETJ_STOCK.PL
{
    partial class uc_option_db
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_option_db));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_create = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_close1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_chose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_restor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_chose1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_re_fileName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 254);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_create);
            this.groupBox1.Controls.Add(this.btn_close1);
            this.groupBox1.Controls.Add(this.btn_chose);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_fileName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(990, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انشاء نسخة احتياطية";
            // 
            // btn_create
            // 
            this.btn_create.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create.BorderRadius = 0;
            this.btn_create.ButtonText = "انشاء";
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.DisabledColor = System.Drawing.Color.Gray;
            this.btn_create.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_create.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_create.Iconimage")));
            this.btn_create.Iconimage_right = null;
            this.btn_create.Iconimage_right_Selected = null;
            this.btn_create.Iconimage_Selected = null;
            this.btn_create.IconMarginLeft = 0;
            this.btn_create.IconMarginRight = 0;
            this.btn_create.IconRightVisible = true;
            this.btn_create.IconRightZoom = 0D;
            this.btn_create.IconVisible = true;
            this.btn_create.IconZoom = 60D;
            this.btn_create.IsTab = false;
            this.btn_create.Location = new System.Drawing.Point(550, 149);
            this.btn_create.Margin = new System.Windows.Forms.Padding(5);
            this.btn_create.Name = "btn_create";
            this.btn_create.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_create.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_create.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_create.selected = false;
            this.btn_create.Size = new System.Drawing.Size(208, 46);
            this.btn_create.TabIndex = 21;
            this.btn_create.Text = "انشاء";
            this.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_create.Textcolor = System.Drawing.Color.White;
            this.btn_create.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_close1
            // 
            this.btn_close1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_close1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_close1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close1.BorderRadius = 0;
            this.btn_close1.ButtonText = "الغاء";
            this.btn_close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close1.DisabledColor = System.Drawing.Color.Gray;
            this.btn_close1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_close1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_close1.Iconimage")));
            this.btn_close1.Iconimage_right = null;
            this.btn_close1.Iconimage_right_Selected = null;
            this.btn_close1.Iconimage_Selected = null;
            this.btn_close1.IconMarginLeft = 0;
            this.btn_close1.IconMarginRight = 0;
            this.btn_close1.IconRightVisible = true;
            this.btn_close1.IconRightZoom = 0D;
            this.btn_close1.IconVisible = true;
            this.btn_close1.IconZoom = 60D;
            this.btn_close1.IsTab = false;
            this.btn_close1.Location = new System.Drawing.Point(332, 149);
            this.btn_close1.Margin = new System.Windows.Forms.Padding(5);
            this.btn_close1.Name = "btn_close1";
            this.btn_close1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_close1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_close1.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_close1.selected = false;
            this.btn_close1.Size = new System.Drawing.Size(208, 46);
            this.btn_close1.TabIndex = 20;
            this.btn_close1.Text = "الغاء";
            this.btn_close1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close1.Textcolor = System.Drawing.Color.White;
            this.btn_close1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_chose
            // 
            this.btn_chose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_chose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_chose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chose.BorderRadius = 0;
            this.btn_chose.ButtonText = "اختار";
            this.btn_chose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chose.DisabledColor = System.Drawing.Color.Gray;
            this.btn_chose.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_chose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_chose.Iconimage")));
            this.btn_chose.Iconimage_right = null;
            this.btn_chose.Iconimage_right_Selected = null;
            this.btn_chose.Iconimage_Selected = null;
            this.btn_chose.IconMarginLeft = 0;
            this.btn_chose.IconMarginRight = 0;
            this.btn_chose.IconRightVisible = true;
            this.btn_chose.IconRightZoom = 0D;
            this.btn_chose.IconVisible = true;
            this.btn_chose.IconZoom = 60D;
            this.btn_chose.IsTab = false;
            this.btn_chose.Location = new System.Drawing.Point(332, 42);
            this.btn_chose.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chose.Name = "btn_chose";
            this.btn_chose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_chose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_chose.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_chose.selected = false;
            this.btn_chose.Size = new System.Drawing.Size(86, 37);
            this.btn_chose.TabIndex = 19;
            this.btn_chose.Text = "اختار";
            this.btn_chose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_chose.Textcolor = System.Drawing.Color.White;
            this.btn_chose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chose.Click += new System.EventHandler(this.btn_chose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(827, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "اختار مسار الحفظ";
            // 
            // txt_fileName
            // 
            this.txt_fileName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fileName.Location = new System.Drawing.Point(425, 47);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.ReadOnly = true;
            this.txt_fileName.Size = new System.Drawing.Size(349, 27);
            this.txt_fileName.TabIndex = 17;
            this.txt_fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(3, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 254);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_restor);
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_chose1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_re_fileName);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(994, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "استعادة نسخة احتياطية";
            // 
            // btn_restor
            // 
            this.btn_restor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_restor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_restor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_restor.BorderRadius = 0;
            this.btn_restor.ButtonText = "استعادة";
            this.btn_restor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_restor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_restor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_restor.Iconimage")));
            this.btn_restor.Iconimage_right = null;
            this.btn_restor.Iconimage_right_Selected = null;
            this.btn_restor.Iconimage_Selected = null;
            this.btn_restor.IconMarginLeft = 0;
            this.btn_restor.IconMarginRight = 0;
            this.btn_restor.IconRightVisible = true;
            this.btn_restor.IconRightZoom = 0D;
            this.btn_restor.IconVisible = true;
            this.btn_restor.IconZoom = 60D;
            this.btn_restor.IsTab = false;
            this.btn_restor.Location = new System.Drawing.Point(550, 155);
            this.btn_restor.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_restor.Name = "btn_restor";
            this.btn_restor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_restor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_restor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_restor.selected = false;
            this.btn_restor.Size = new System.Drawing.Size(208, 46);
            this.btn_restor.TabIndex = 26;
            this.btn_restor.Text = "استعادة";
            this.btn_restor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_restor.Textcolor = System.Drawing.Color.White;
            this.btn_restor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restor.Click += new System.EventHandler(this.btn_restor_Click);
            // 
            // btn_close
            // 
            this.btn_close.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.BorderRadius = 0;
            this.btn_close.ButtonText = "الغاء";
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DisabledColor = System.Drawing.Color.Gray;
            this.btn_close.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_close.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_close.Iconimage")));
            this.btn_close.Iconimage_right = null;
            this.btn_close.Iconimage_right_Selected = null;
            this.btn_close.Iconimage_Selected = null;
            this.btn_close.IconMarginLeft = 0;
            this.btn_close.IconMarginRight = 0;
            this.btn_close.IconRightVisible = true;
            this.btn_close.IconRightZoom = 0D;
            this.btn_close.IconVisible = true;
            this.btn_close.IconZoom = 60D;
            this.btn_close.IsTab = false;
            this.btn_close.Location = new System.Drawing.Point(332, 155);
            this.btn_close.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_close.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_close.selected = false;
            this.btn_close.Size = new System.Drawing.Size(208, 46);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = "الغاء";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Textcolor = System.Drawing.Color.White;
            this.btn_close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_chose1
            // 
            this.btn_chose1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_chose1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_chose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chose1.BorderRadius = 0;
            this.btn_chose1.ButtonText = "اختار";
            this.btn_chose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chose1.DisabledColor = System.Drawing.Color.Gray;
            this.btn_chose1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_chose1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_chose1.Iconimage")));
            this.btn_chose1.Iconimage_right = null;
            this.btn_chose1.Iconimage_right_Selected = null;
            this.btn_chose1.Iconimage_Selected = null;
            this.btn_chose1.IconMarginLeft = 0;
            this.btn_chose1.IconMarginRight = 0;
            this.btn_chose1.IconRightVisible = true;
            this.btn_chose1.IconRightZoom = 0D;
            this.btn_chose1.IconVisible = true;
            this.btn_chose1.IconZoom = 60D;
            this.btn_chose1.IsTab = false;
            this.btn_chose1.Location = new System.Drawing.Point(332, 54);
            this.btn_chose1.Margin = new System.Windows.Forms.Padding(5);
            this.btn_chose1.Name = "btn_chose1";
            this.btn_chose1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_chose1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_chose1.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_chose1.selected = false;
            this.btn_chose1.Size = new System.Drawing.Size(86, 37);
            this.btn_chose1.TabIndex = 24;
            this.btn_chose1.Text = "اختار";
            this.btn_chose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_chose1.Textcolor = System.Drawing.Color.White;
            this.btn_chose1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chose1.Click += new System.EventHandler(this.btn_chose1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(827, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "اختار مسار الحفظ";
            // 
            // txt_re_fileName
            // 
            this.txt_re_fileName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_re_fileName.Location = new System.Drawing.Point(425, 59);
            this.txt_re_fileName.Name = "txt_re_fileName";
            this.txt_re_fileName.ReadOnly = true;
            this.txt_re_fileName.Size = new System.Drawing.Size(349, 27);
            this.txt_re_fileName.TabIndex = 22;
            this.txt_re_fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uc_option_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_option_db";
            this.Size = new System.Drawing.Size(1021, 543);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fileName;
        private Bunifu.Framework.UI.BunifuFlatButton btn_chose;
        private Bunifu.Framework.UI.BunifuFlatButton btn_create;
        private Bunifu.Framework.UI.BunifuFlatButton btn_close1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_restor;
        private Bunifu.Framework.UI.BunifuFlatButton btn_close;
        private Bunifu.Framework.UI.BunifuFlatButton btn_chose1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_re_fileName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
