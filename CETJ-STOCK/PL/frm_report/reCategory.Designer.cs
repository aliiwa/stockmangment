namespace CETJ_STOCK.PL.frm_report
{
    partial class reCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reCategory));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_cat_code = new System.Windows.Forms.CheckBox();
            this.txt_serch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_dep = new System.Windows.Forms.CheckBox();
            this.cmb_dep = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_category = new System.Windows.Forms.CheckBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_category = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_print_all = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "القسم";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_cat_code);
            this.groupBox3.Controls.Add(this.txt_serch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(694, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(296, 88);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "رقم الاستلام";
            // 
            // chk_cat_code
            // 
            this.chk_cat_code.AutoSize = true;
            this.chk_cat_code.Location = new System.Drawing.Point(272, 41);
            this.chk_cat_code.Name = "chk_cat_code";
            this.chk_cat_code.Size = new System.Drawing.Size(15, 14);
            this.chk_cat_code.TabIndex = 48;
            this.chk_cat_code.UseVisualStyleBackColor = true;
            this.chk_cat_code.CheckedChanged += new System.EventHandler(this.chk_cat_code_CheckedChanged);
            // 
            // txt_serch
            // 
            this.txt_serch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serch.Location = new System.Drawing.Point(31, 33);
            this.txt_serch.Name = "txt_serch";
            this.txt_serch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_serch.Size = new System.Drawing.Size(174, 27);
            this.txt_serch.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = " :بحث ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_dep);
            this.groupBox1.Controls.Add(this.cmb_dep);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(344, 90);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث بين فترتين";
            // 
            // chk_dep
            // 
            this.chk_dep.AutoSize = true;
            this.chk_dep.Location = new System.Drawing.Point(284, 43);
            this.chk_dep.Name = "chk_dep";
            this.chk_dep.Size = new System.Drawing.Size(15, 14);
            this.chk_dep.TabIndex = 49;
            this.chk_dep.UseVisualStyleBackColor = true;
            this.chk_dep.CheckedChanged += new System.EventHandler(this.chk_dep_CheckedChanged);
            // 
            // cmb_dep
            // 
            this.cmb_dep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_dep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_dep.FormattingEnabled = true;
            this.cmb_dep.Location = new System.Drawing.Point(14, 38);
            this.cmb_dep.Name = "cmb_dep";
            this.cmb_dep.Size = new System.Drawing.Size(174, 21);
            this.cmb_dep.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(6, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 102);
            this.panel3.TabIndex = 131;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chk_category);
            this.groupBox2.Controls.Add(this.cmb_category);
            this.groupBox2.Location = new System.Drawing.Point(371, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(317, 88);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حسب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "التصنيف";
            // 
            // chk_category
            // 
            this.chk_category.AutoSize = true;
            this.chk_category.Location = new System.Drawing.Point(285, 41);
            this.chk_category.Name = "chk_category";
            this.chk_category.Size = new System.Drawing.Size(15, 14);
            this.chk_category.TabIndex = 48;
            this.chk_category.UseVisualStyleBackColor = true;
            this.chk_category.CheckedChanged += new System.EventHandler(this.chk_category_CheckedChanged);
            // 
            // cmb_category
            // 
            this.cmb_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(6, 36);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(174, 21);
            this.cmb_category.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgv_category);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_print_all);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Location = new System.Drawing.Point(6, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 389);
            this.panel1.TabIndex = 132;
            // 
            // dgv_category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_category.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.DoubleBuffered = true;
            this.dgv_category.EnableHeadersVisualStyles = false;
            this.dgv_category.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgv_category.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_category.Location = new System.Drawing.Point(14, 4);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.ReadOnly = true;
            this.dgv_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgv_category.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_category.Size = new System.Drawing.Size(980, 313);
            this.dgv_category.TabIndex = 136;
            // 
            // btn_search
            // 
            this.btn_search.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.BorderRadius = 0;
            this.btn_search.ButtonText = "بحث";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.DisabledColor = System.Drawing.Color.Gray;
            this.btn_search.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_search.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_search.Iconimage")));
            this.btn_search.Iconimage_right = null;
            this.btn_search.Iconimage_right_Selected = null;
            this.btn_search.Iconimage_Selected = null;
            this.btn_search.IconMarginLeft = 0;
            this.btn_search.IconMarginRight = 0;
            this.btn_search.IconRightVisible = true;
            this.btn_search.IconRightZoom = 0D;
            this.btn_search.IconVisible = true;
            this.btn_search.IconZoom = 70D;
            this.btn_search.IsTab = false;
            this.btn_search.Location = new System.Drawing.Point(14, 337);
            this.btn_search.Name = "btn_search";
            this.btn_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search.selected = false;
            this.btn_search.Size = new System.Drawing.Size(198, 48);
            this.btn_search.TabIndex = 140;
            this.btn_search.Text = "بحث";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Textcolor = System.Drawing.Color.White;
            this.btn_search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.BorderRadius = 0;
            this.btn_refresh.ButtonText = "تصدير الي ملف اكسل";
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.DisabledColor = System.Drawing.Color.Gray;
            this.btn_refresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_refresh.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Iconimage")));
            this.btn_refresh.Iconimage_right = null;
            this.btn_refresh.Iconimage_right_Selected = null;
            this.btn_refresh.Iconimage_Selected = null;
            this.btn_refresh.IconMarginLeft = 0;
            this.btn_refresh.IconMarginRight = 0;
            this.btn_refresh.IconRightVisible = true;
            this.btn_refresh.IconRightZoom = 0D;
            this.btn_refresh.IconVisible = true;
            this.btn_refresh.IconZoom = 70D;
            this.btn_refresh.IsTab = false;
            this.btn_refresh.Location = new System.Drawing.Point(288, 337);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_refresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_refresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_refresh.selected = false;
            this.btn_refresh.Size = new System.Drawing.Size(198, 48);
            this.btn_refresh.TabIndex = 139;
            this.btn_refresh.Text = "تصدير الي ملف اكسل";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.Textcolor = System.Drawing.Color.White;
            this.btn_refresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_print_all
            // 
            this.btn_print_all.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_print_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_print_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print_all.BorderRadius = 0;
            this.btn_print_all.ButtonText = "طباعة الكل";
            this.btn_print_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print_all.DisabledColor = System.Drawing.Color.Gray;
            this.btn_print_all.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_print_all.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_print_all.Iconimage")));
            this.btn_print_all.Iconimage_right = null;
            this.btn_print_all.Iconimage_right_Selected = null;
            this.btn_print_all.Iconimage_Selected = null;
            this.btn_print_all.IconMarginLeft = 0;
            this.btn_print_all.IconMarginRight = 0;
            this.btn_print_all.IconRightVisible = true;
            this.btn_print_all.IconRightZoom = 0D;
            this.btn_print_all.IconVisible = true;
            this.btn_print_all.IconZoom = 70D;
            this.btn_print_all.IsTab = false;
            this.btn_print_all.Location = new System.Drawing.Point(555, 337);
            this.btn_print_all.Name = "btn_print_all";
            this.btn_print_all.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_print_all.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_print_all.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_print_all.selected = false;
            this.btn_print_all.Size = new System.Drawing.Size(198, 48);
            this.btn_print_all.TabIndex = 138;
            this.btn_print_all.Text = "طباعة الكل";
            this.btn_print_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print_all.Textcolor = System.Drawing.Color.White;
            this.btn_print_all.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_all.Click += new System.EventHandler(this.btn_print_all_Click);
            // 
            // btn_print
            // 
            this.btn_print.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print.BorderRadius = 0;
            this.btn_print.ButtonText = "طباعة المحدد";
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.DisabledColor = System.Drawing.Color.Gray;
            this.btn_print.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_print.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_print.Iconimage")));
            this.btn_print.Iconimage_right = null;
            this.btn_print.Iconimage_right_Selected = null;
            this.btn_print.Iconimage_Selected = null;
            this.btn_print.IconMarginLeft = 0;
            this.btn_print.IconMarginRight = 0;
            this.btn_print.IconRightVisible = true;
            this.btn_print.IconRightZoom = 0D;
            this.btn_print.IconVisible = true;
            this.btn_print.IconZoom = 70D;
            this.btn_print.IsTab = false;
            this.btn_print.Location = new System.Drawing.Point(796, 337);
            this.btn_print.Name = "btn_print";
            this.btn_print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_print.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_print.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_print.selected = false;
            this.btn_print.Size = new System.Drawing.Size(198, 48);
            this.btn_print.TabIndex = 137;
            this.btn_print.Text = "طباعة المحدد";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print.Textcolor = System.Drawing.Color.White;
            this.btn_print.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // reCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "reCategory";
            this.Size = new System.Drawing.Size(1021, 511);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_cat_code;
        private System.Windows.Forms.TextBox txt_serch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_category;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_category;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search;
        private Bunifu.Framework.UI.BunifuFlatButton btn_refresh;
        private Bunifu.Framework.UI.BunifuFlatButton btn_print_all;
        private Bunifu.Framework.UI.BunifuFlatButton btn_print;
        private System.Windows.Forms.CheckBox chk_dep;
        private System.Windows.Forms.ComboBox cmb_dep;
    }
}
