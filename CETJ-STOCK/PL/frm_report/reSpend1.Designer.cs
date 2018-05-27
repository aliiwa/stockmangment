namespace CETJ_STOCK.PL.frm_report
{
    partial class reSpend1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reSpend1));
            this.dgv_spend = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.chk_b2d = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_spend_code = new System.Windows.Forms.CheckBox();
            this.txt_serch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_dep = new System.Windows.Forms.CheckBox();
            this.chk_date = new System.Windows.Forms.CheckBox();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spend)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_spend
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_spend.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_spend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_spend.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_spend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_spend.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_spend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_spend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_spend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_spend.DoubleBuffered = true;
            this.dgv_spend.EnableHeadersVisualStyles = false;
            this.dgv_spend.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgv_spend.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_spend.Location = new System.Drawing.Point(20, 119);
            this.dgv_spend.Name = "dgv_spend";
            this.dgv_spend.ReadOnly = true;
            this.dgv_spend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_spend.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgv_spend.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_spend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_spend.Size = new System.Drawing.Size(980, 313);
            this.dgv_spend.TabIndex = 118;
            this.dgv_spend.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_spend_CellContentClick);
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
            this.bunifuFlatButton6.Location = new System.Drawing.Point(802, 452);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(198, 48);
            this.bunifuFlatButton6.TabIndex = 120;
            this.bunifuFlatButton6.Text = "طباعة المحدد";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
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
            this.btn_delete.Location = new System.Drawing.Point(561, 452);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.selected = false;
            this.btn_delete.Size = new System.Drawing.Size(198, 48);
            this.btn_delete.TabIndex = 121;
            this.btn_delete.Text = "طباعة الكل";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Textcolor = System.Drawing.Color.White;
            this.btn_delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_refresh.Location = new System.Drawing.Point(294, 452);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_refresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_refresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_refresh.selected = false;
            this.btn_refresh.Size = new System.Drawing.Size(198, 48);
            this.btn_refresh.TabIndex = 122;
            this.btn_refresh.Text = "تصدير الي ملف اكسل";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.Textcolor = System.Drawing.Color.White;
            this.btn_refresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_search.Location = new System.Drawing.Point(20, 452);
            this.btn_search.Name = "btn_search";
            this.btn_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search.selected = false;
            this.btn_search.Size = new System.Drawing.Size(198, 48);
            this.btn_search.TabIndex = 123;
            this.btn_search.Text = "بحث";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Textcolor = System.Drawing.Color.White;
            this.btn_search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(10, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 102);
            this.panel3.TabIndex = 119;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_spend_code);
            this.groupBox3.Controls.Add(this.txt_serch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(694, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(296, 88);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "رقم الصرف";
            // 
            // chk_spend_code
            // 
            this.chk_spend_code.AutoSize = true;
            this.chk_spend_code.Location = new System.Drawing.Point(272, 41);
            this.chk_spend_code.Name = "chk_spend_code";
            this.chk_spend_code.Size = new System.Drawing.Size(15, 14);
            this.chk_spend_code.TabIndex = 48;
            this.chk_spend_code.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chk_dep);
            this.groupBox2.Controls.Add(this.chk_date);
            this.groupBox2.Controls.Add(this.cmb_department);
            this.groupBox2.Controls.Add(this.dt_date);
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
            this.label5.Location = new System.Drawing.Point(210, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "القسم :";
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
            // chk_dep
            // 
            this.chk_dep.AutoSize = true;
            this.chk_dep.Location = new System.Drawing.Point(287, 58);
            this.chk_dep.Name = "chk_dep";
            this.chk_dep.Size = new System.Drawing.Size(15, 14);
            this.chk_dep.TabIndex = 48;
            this.chk_dep.UseVisualStyleBackColor = true;
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
            // cmb_department
            // 
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(13, 51);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(174, 21);
            this.cmb_department.TabIndex = 46;
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(13, 17);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(174, 20);
            this.dt_date.TabIndex = 45;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "spend_id";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "spend_code";
            this.Column2.HeaderText = "رقم الصرف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "spend_date";
            this.Column3.HeaderText = "التاريخ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dep_name";
            this.Column4.HeaderText = "القسم";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "pro_code";
            this.Column5.HeaderText = "رقم الصنف";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "pro_name";
            this.Column6.HeaderText = "اسم الصنف";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "pro_unit";
            this.Column7.HeaderText = "الوحدة";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pro_quantity";
            this.Column8.HeaderText = "الكمية";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // reSpend1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.bunifuFlatButton6);
            this.Controls.Add(this.dgv_spend);
            this.Name = "reSpend1";
            this.Size = new System.Drawing.Size(1021, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_spend;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_refresh;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.CheckBox chk_b2d;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_spend_code;
        private System.Windows.Forms.TextBox txt_serch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_dep;
        private System.Windows.Forms.CheckBox chk_date;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
