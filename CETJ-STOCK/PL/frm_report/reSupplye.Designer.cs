﻿namespace CETJ_STOCK.PL.frm_report
{
    partial class reSupplye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reSupplye));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_supplyer = new System.Windows.Forms.CheckBox();
            this.chk_date = new System.Windows.Forms.CheckBox();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_supplye = new System.Windows.Forms.ComboBox();
            this.chk_suplye_code = new System.Windows.Forms.CheckBox();
            this.txt_serch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.chk_b2d = new System.Windows.Forms.CheckBox();
            this.btn_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_supplye = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplye)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "المورد :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "التاريخ :";
            // 
            // chk_supplyer
            // 
            this.chk_supplyer.AutoSize = true;
            this.chk_supplyer.Location = new System.Drawing.Point(287, 58);
            this.chk_supplyer.Name = "chk_supplyer";
            this.chk_supplyer.Size = new System.Drawing.Size(15, 14);
            this.chk_supplyer.TabIndex = 48;
            this.chk_supplyer.UseVisualStyleBackColor = true;
            // 
            // chk_date
            // 
            this.chk_date.AutoSize = true;
            this.chk_date.Location = new System.Drawing.Point(287, 23);
            this.chk_date.Name = "chk_date";
            this.chk_date.Size = new System.Drawing.Size(15, 14);
            this.chk_date.TabIndex = 47;
            this.chk_date.UseVisualStyleBackColor = true;
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(13, 17);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(174, 20);
            this.dt_date.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chk_supplyer);
            this.groupBox2.Controls.Add(this.chk_date);
            this.groupBox2.Controls.Add(this.cmb_supplye);
            this.groupBox2.Controls.Add(this.dt_date);
            this.groupBox2.Location = new System.Drawing.Point(371, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(317, 88);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حسب";
            // 
            // cmb_supplye
            // 
            this.cmb_supplye.FormattingEnabled = true;
            this.cmb_supplye.Location = new System.Drawing.Point(13, 51);
            this.cmb_supplye.Name = "cmb_supplye";
            this.cmb_supplye.Size = new System.Drawing.Size(174, 21);
            this.cmb_supplye.TabIndex = 46;
            // 
            // chk_suplye_code
            // 
            this.chk_suplye_code.AutoSize = true;
            this.chk_suplye_code.Location = new System.Drawing.Point(272, 41);
            this.chk_suplye_code.Name = "chk_suplye_code";
            this.chk_suplye_code.Size = new System.Drawing.Size(15, 14);
            this.chk_suplye_code.TabIndex = 48;
            this.chk_suplye_code.UseVisualStyleBackColor = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_suplye_code);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(6, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 102);
            this.panel3.TabIndex = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dt_to);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_from);
            this.groupBox1.Controls.Add(this.chk_b2d);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(344, 90);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث بين فترتين";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "إلي :";
            // 
            // dt_to
            // 
            this.dt_to.Location = new System.Drawing.Point(29, 55);
            this.dt_to.Name = "dt_to";
            this.dt_to.Size = new System.Drawing.Size(174, 20);
            this.dt_to.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "من :";
            // 
            // dt_from
            // 
            this.dt_from.Location = new System.Drawing.Point(29, 21);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(174, 20);
            this.dt_from.TabIndex = 43;
            // 
            // chk_b2d
            // 
            this.chk_b2d.AutoSize = true;
            this.chk_b2d.Location = new System.Drawing.Point(309, 30);
            this.chk_b2d.Name = "chk_b2d";
            this.chk_b2d.Size = new System.Drawing.Size(15, 14);
            this.chk_b2d.TabIndex = 42;
            this.chk_b2d.UseVisualStyleBackColor = true;
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
            this.btn_search.Location = new System.Drawing.Point(16, 452);
            this.btn_search.Name = "btn_search";
            this.btn_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search.selected = false;
            this.btn_search.Size = new System.Drawing.Size(198, 48);
            this.btn_search.TabIndex = 129;
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
            this.btn_refresh.Location = new System.Drawing.Point(290, 452);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_refresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_refresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_refresh.selected = false;
            this.btn_refresh.Size = new System.Drawing.Size(198, 48);
            this.btn_refresh.TabIndex = 128;
            this.btn_refresh.Text = "تصدير الي ملف اكسل";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.Textcolor = System.Drawing.Color.White;
            this.btn_refresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_delete
            // 
            this.btn_delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.BorderRadius = 0;
            this.btn_delete.ButtonText = "طباعة الكل";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_delete.Iconimage")));
            this.btn_delete.Iconimage_right = null;
            this.btn_delete.Iconimage_right_Selected = null;
            this.btn_delete.Iconimage_Selected = null;
            this.btn_delete.IconMarginLeft = 0;
            this.btn_delete.IconMarginRight = 0;
            this.btn_delete.IconRightVisible = true;
            this.btn_delete.IconRightZoom = 0D;
            this.btn_delete.IconVisible = true;
            this.btn_delete.IconZoom = 70D;
            this.btn_delete.IsTab = false;
            this.btn_delete.Location = new System.Drawing.Point(557, 452);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.selected = false;
            this.btn_delete.Size = new System.Drawing.Size(198, 48);
            this.btn_delete.TabIndex = 127;
            this.btn_delete.Text = "طباعة الكل";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Textcolor = System.Drawing.Color.White;
            this.btn_delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_supplye
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_supplye.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_supplye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_supplye.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_supplye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_supplye.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_supplye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_supplye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_supplye.DoubleBuffered = true;
            this.dgv_supplye.EnableHeadersVisualStyles = false;
            this.dgv_supplye.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgv_supplye.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_supplye.Location = new System.Drawing.Point(16, 119);
            this.dgv_supplye.Name = "dgv_supplye";
            this.dgv_supplye.ReadOnly = true;
            this.dgv_supplye.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_supplye.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgv_supplye.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_supplye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplye.Size = new System.Drawing.Size(980, 313);
            this.dgv_supplye.TabIndex = 124;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "supplye_id";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "supplye_code";
            this.Column2.HeaderText = "رقم الاستلام";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "supplye_date";
            this.Column3.HeaderText = "التاريخ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "supplyer_name";
            this.Column4.HeaderText = "المورد";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "invoice_number";
            this.Column5.HeaderText = "رقم الفاتورة";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Product_code";
            this.Column6.HeaderText = "رقم الصنف";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Product_name";
            this.Column7.HeaderText = "اسم الصنف";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Product_unit";
            this.Column8.HeaderText = "الوحدة";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Product_quantity";
            this.Column9.HeaderText = "الكمية";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "طباعة المحدد";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 70D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(798, 452);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton6.TabIndex = 126;
            this.bunifuFlatButton6.Text = "طباعة المحدد";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // reSupplye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.bunifuFlatButton6);
            this.Controls.Add(this.dgv_supplye);
            this.Name = "reSupplye";
            this.Size = new System.Drawing.Size(1021, 511);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_supplyer;
        private System.Windows.Forms.CheckBox chk_date;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_supplye;
        private System.Windows.Forms.CheckBox chk_suplye_code;
        private System.Windows.Forms.TextBox txt_serch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.CheckBox chk_b2d;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search;
        private Bunifu.Framework.UI.BunifuFlatButton btn_refresh;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delete;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_supplye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
    }
}
