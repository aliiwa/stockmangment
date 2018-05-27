namespace CETJ_STOCK.PL
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_cat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID_Cat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cat_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.التصنيف = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_delate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_new = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.cmb_sub_cat = new System.Windows.Forms.ComboBox();
            this.cmb_units = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgv_cat);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(16, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 326);
            this.panel2.TabIndex = 1;
            // 
            // dgv_cat
            // 
            this.dgv_cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_cat.Location = new System.Drawing.Point(9, 85);
            this.dgv_cat.Name = "dgv_cat";
            this.dgv_cat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_cat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cat.Size = new System.Drawing.Size(991, 226);
            this.dgv_cat.TabIndex = 58;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cat_code";
            this.Column1.HeaderText = "رقم الصنف";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cat_name";
            this.Column2.HeaderText = "اسم الصنف";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "unit_name";
            this.Column3.HeaderText = "الوحدة";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sub_cat_name";
            this.Column4.HeaderText = "التصنيف";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dep_name";
            this.Column5.HeaderText = "القسم";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "quantity_in_stock";
            this.Column6.HeaderText = "الكمية";
            this.Column6.Name = "Column6";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_search);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 72);
            this.panel3.TabIndex = 57;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(517, 21);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(391, 27);
            this.txt_search.TabIndex = 17;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(930, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = " :بحث ";
            // 
            // txt_ID_Cat
            // 
            this.txt_ID_Cat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_Cat.Location = new System.Drawing.Point(713, 54);
            this.txt_ID_Cat.Name = "txt_ID_Cat";
            this.txt_ID_Cat.Size = new System.Drawing.Size(188, 27);
            this.txt_ID_Cat.TabIndex = 0;
            this.txt_ID_Cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(919, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "رقم الصنف";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(918, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 28);
            this.label12.TabIndex = 17;
            this.label12.Text = "القسم";
            // 
            // txt_cat_name
            // 
            this.txt_cat_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat_name.Location = new System.Drawing.Point(355, 54);
            this.txt_cat_name.Name = "txt_cat_name";
            this.txt_cat_name.Size = new System.Drawing.Size(188, 27);
            this.txt_cat_name.TabIndex = 1;
            this.txt_cat_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "اسم الصنف";
            // 
            // التصنيف
            // 
            this.التصنيف.AutoSize = true;
            this.التصنيف.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.التصنيف.Location = new System.Drawing.Point(561, 91);
            this.التصنيف.Name = "التصنيف";
            this.التصنيف.Size = new System.Drawing.Size(71, 28);
            this.التصنيف.TabIndex = 21;
            this.التصنيف.Text = "التصنيف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "الوحدة";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(50, 54);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(188, 27);
            this.txt_quantity.TabIndex = 2;
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.only_numper_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "الكمية";
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "إضافة";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save.Enabled = false;
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_save.Iconimage")));
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
            this.btn_save.Location = new System.Drawing.Point(541, 204);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(198, 48);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "إضافة";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delate
            // 
            this.btn_delate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_delate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_delate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delate.BorderRadius = 0;
            this.btn_delate.ButtonText = "حذف";
            this.btn_delate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delate.DisabledColor = System.Drawing.Color.Gray;
            this.btn_delate.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_delate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_delate.Iconimage")));
            this.btn_delate.Iconimage_right = null;
            this.btn_delate.Iconimage_right_Selected = null;
            this.btn_delate.Iconimage_Selected = null;
            this.btn_delate.IconMarginLeft = 0;
            this.btn_delate.IconMarginRight = 0;
            this.btn_delate.IconRightVisible = true;
            this.btn_delate.IconRightZoom = 0D;
            this.btn_delate.IconVisible = true;
            this.btn_delate.IconZoom = 70D;
            this.btn_delate.IsTab = false;
            this.btn_delate.Location = new System.Drawing.Point(17, 204);
            this.btn_delate.Name = "btn_delate";
            this.btn_delate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_delate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_delate.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delate.selected = false;
            this.btn_delate.Size = new System.Drawing.Size(198, 48);
            this.btn_delate.TabIndex = 14;
            this.btn_delate.Text = "حذف";
            this.btn_delate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delate.Textcolor = System.Drawing.Color.White;
            this.btn_delate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delate.Click += new System.EventHandler(this.btn_delate_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.BorderRadius = 0;
            this.btn_edit.ButtonText = "تعديل";
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_edit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_edit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_edit.Iconimage")));
            this.btn_edit.Iconimage_right = null;
            this.btn_edit.Iconimage_right_Selected = null;
            this.btn_edit.Iconimage_Selected = null;
            this.btn_edit.IconMarginLeft = 0;
            this.btn_edit.IconMarginRight = 0;
            this.btn_edit.IconRightVisible = true;
            this.btn_edit.IconRightZoom = 0D;
            this.btn_edit.IconVisible = true;
            this.btn_edit.IconZoom = 70D;
            this.btn_edit.IsTab = false;
            this.btn_edit.Location = new System.Drawing.Point(285, 204);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(198, 48);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.White;
            this.btn_edit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.BorderRadius = 0;
            this.btn_new.ButtonText = "جديد";
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.DisabledColor = System.Drawing.Color.Gray;
            this.btn_new.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_new.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_new.Iconimage")));
            this.btn_new.Iconimage_right = null;
            this.btn_new.Iconimage_right_Selected = null;
            this.btn_new.Iconimage_Selected = null;
            this.btn_new.IconMarginLeft = 0;
            this.btn_new.IconMarginRight = 0;
            this.btn_new.IconRightVisible = true;
            this.btn_new.IconRightZoom = 0D;
            this.btn_new.IconVisible = true;
            this.btn_new.IconZoom = 70D;
            this.btn_new.IsTab = false;
            this.btn_new.Location = new System.Drawing.Point(803, 204);
            this.btn_new.Name = "btn_new";
            this.btn_new.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_new.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_new.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_new.selected = false;
            this.btn_new.Size = new System.Drawing.Size(198, 48);
            this.btn_new.TabIndex = 16;
            this.btn_new.Text = "جديد";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new.Textcolor = System.Drawing.Color.White;
            this.btn_new.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // cmb_department
            // 
            this.cmb_department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_department.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(713, 97);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(188, 27);
            this.cmb_department.TabIndex = 3;
            // 
            // cmb_sub_cat
            // 
            this.cmb_sub_cat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_sub_cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_sub_cat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sub_cat.FormattingEnabled = true;
            this.cmb_sub_cat.Location = new System.Drawing.Point(355, 95);
            this.cmb_sub_cat.Name = "cmb_sub_cat";
            this.cmb_sub_cat.Size = new System.Drawing.Size(188, 27);
            this.cmb_sub_cat.TabIndex = 4;
            // 
            // cmb_units
            // 
            this.cmb_units.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_units.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_units.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_units.FormattingEnabled = true;
            this.cmb_units.Location = new System.Drawing.Point(50, 92);
            this.cmb_units.Name = "cmb_units";
            this.cmb_units.Size = new System.Drawing.Size(188, 27);
            this.cmb_units.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.bunifuFlatButton8);
            this.panel1.Controls.Add(this.bunifuFlatButton7);
            this.panel1.Controls.Add(this.bunifuFlatButton6);
            this.panel1.Controls.Add(this.cmb_units);
            this.panel1.Controls.Add(this.cmb_sub_cat);
            this.panel1.Controls.Add(this.cmb_department);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delate);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.التصنيف);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_cat_name);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_ID_Cat);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 281);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(713, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 55;
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 30D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(322, 95);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(27, 27);
            this.bunifuFlatButton8.TabIndex = 54;
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 30D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(680, 97);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(27, 27);
            this.bunifuFlatButton7.TabIndex = 53;
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "";
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
            this.bunifuFlatButton6.IconZoom = 30D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(17, 95);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(27, 27);
            this.bunifuFlatButton6.TabIndex = 52;
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // btn1
            // 
            this.btn1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.BorderRadius = 0;
            this.btn1.ButtonText = "";
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.DisabledColor = System.Drawing.Color.Gray;
            this.btn1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn1.Iconimage")));
            this.btn1.Iconimage_right = null;
            this.btn1.Iconimage_right_Selected = null;
            this.btn1.Iconimage_Selected = null;
            this.btn1.IconMarginLeft = 0;
            this.btn1.IconMarginRight = 0;
            this.btn1.IconRightVisible = true;
            this.btn1.IconRightZoom = 0D;
            this.btn1.IconVisible = true;
            this.btn1.IconZoom = 30D;
            this.btn1.IsTab = false;
            this.btn1.Location = new System.Drawing.Point(541, 140);
            this.btn1.Name = "btn1";
            this.btn1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn1.OnHoverTextColor = System.Drawing.Color.White;
            this.btn1.selected = false;
            this.btn1.Size = new System.Drawing.Size(27, 27);
            this.btn1.TabIndex = 56;
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.Textcolor = System.Drawing.Color.White;
            this.btn1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1047, 640);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID_Cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cat_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label التصنيف;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delate;
        private Bunifu.Framework.UI.BunifuFlatButton btn_edit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_new;
        private System.Windows.Forms.ComboBox cmb_sub_cat;
        private System.Windows.Forms.ComboBox cmb_units;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private System.Windows.Forms.DataGridView dgv_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn1;
    }
}
