namespace CETJ_STOCK.PL
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_spend_code = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_spend = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qte_in_stock = new System.Windows.Forms.TextBox();
            this.txt_cat_unit = new System.Windows.Forms.TextBox();
            this.dgv_spend = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cat_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cat_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_remove_all = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_choes_cat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_serch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spend)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_department
            // 
            this.cmb_department.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(32, 29);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(188, 27);
            this.cmb_department.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "القسم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "التاريخ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(893, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "رقم اذن الصرف";
            // 
            // txt_spend_code
            // 
            this.txt_spend_code.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_spend_code.Location = new System.Drawing.Point(687, 29);
            this.txt_spend_code.Name = "txt_spend_code";
            this.txt_spend_code.Size = new System.Drawing.Size(188, 27);
            this.txt_spend_code.TabIndex = 2;
            this.txt_spend_code.Validated += new System.EventHandler(this.txt_spend_Validated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dt_spend);
            this.panel1.Controls.Add(this.cmb_department);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_spend_code);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 91);
            this.panel1.TabIndex = 2;
            // 
            // dt_spend
            // 
            this.dt_spend.Location = new System.Drawing.Point(349, 36);
            this.dt_spend.Name = "dt_spend";
            this.dt_spend.Size = new System.Drawing.Size(188, 20);
            this.dt_spend.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(178, 35);
            this.label4.TabIndex = 73;
            this.label4.Text = "الكمية";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_qte
            // 
            this.txt_qte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte.Location = new System.Drawing.Point(9, 57);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(178, 27);
            this.txt_qte.TabIndex = 72;
            this.txt_qte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qte_KeyDown);
            this.txt_qte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acceptOnlyNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 19);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(178, 35);
            this.label2.TabIndex = 69;
            this.label2.Text = "الرصيد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_qte_in_stock
            // 
            this.txt_qte_in_stock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte_in_stock.Location = new System.Drawing.Point(187, 57);
            this.txt_qte_in_stock.Name = "txt_qte_in_stock";
            this.txt_qte_in_stock.ReadOnly = true;
            this.txt_qte_in_stock.Size = new System.Drawing.Size(178, 27);
            this.txt_qte_in_stock.TabIndex = 68;
            this.txt_qte_in_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cat_unit
            // 
            this.txt_cat_unit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat_unit.Location = new System.Drawing.Point(366, 57);
            this.txt_cat_unit.Name = "txt_cat_unit";
            this.txt_cat_unit.ReadOnly = true;
            this.txt_cat_unit.Size = new System.Drawing.Size(178, 27);
            this.txt_cat_unit.TabIndex = 70;
            this.txt_cat_unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dgv_spend.ColumnHeadersVisible = false;
            this.dgv_spend.DoubleBuffered = true;
            this.dgv_spend.EnableHeadersVisualStyles = false;
            this.dgv_spend.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgv_spend.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_spend.Location = new System.Drawing.Point(9, 87);
            this.dgv_spend.MultiSelect = false;
            this.dgv_spend.Name = "dgv_spend";
            this.dgv_spend.ReadOnly = true;
            this.dgv_spend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_spend.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_spend.RowHeadersWidth = 35;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgv_spend.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_spend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_spend.Size = new System.Drawing.Size(927, 314);
            this.dgv_spend.TabIndex = 56;
            this.dgv_spend.DoubleClick += new System.EventHandler(this.dgv_spend_DoubleClick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(545, 19);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(178, 35);
            this.label7.TabIndex = 74;
            this.label7.Text = "اسم الصنف";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(366, 19);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(178, 35);
            this.label3.TabIndex = 75;
            this.label3.Text = "الوحدة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cat_name
            // 
            this.txt_cat_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat_name.Location = new System.Drawing.Point(545, 57);
            this.txt_cat_name.Name = "txt_cat_name";
            this.txt_cat_name.ReadOnly = true;
            this.txt_cat_name.Size = new System.Drawing.Size(178, 27);
            this.txt_cat_name.TabIndex = 71;
            this.txt_cat_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(724, 19);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(178, 35);
            this.label9.TabIndex = 79;
            this.label9.Text = "رقم الصنف";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_cat_id
            // 
            this.txt_cat_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat_id.Location = new System.Drawing.Point(724, 57);
            this.txt_cat_id.Name = "txt_cat_id";
            this.txt_cat_id.ReadOnly = true;
            this.txt_cat_id.Size = new System.Drawing.Size(178, 27);
            this.txt_cat_id.TabIndex = 76;
            this.txt_cat_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(908, 19);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(101, 35);
            this.label10.TabIndex = 78;
            this.label10.Text = "اختيار";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_remove_all);
            this.panel2.Controls.Add(this.btn_choes_cat);
            this.panel2.Controls.Add(this.btn_2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_serch);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_cat_id);
            this.panel2.Controls.Add(this.txt_cat_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_cat_unit);
            this.panel2.Controls.Add(this.txt_qte_in_stock);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_qte);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgv_spend);
            this.panel2.Location = new System.Drawing.Point(16, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 503);
            this.panel2.TabIndex = 6;
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_remove_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_remove_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remove_all.BorderRadius = 0;
            this.btn_remove_all.ButtonText = "حذف الكل";
            this.btn_remove_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove_all.DisabledColor = System.Drawing.Color.Gray;
            this.btn_remove_all.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_remove_all.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_remove_all.Iconimage")));
            this.btn_remove_all.Iconimage_right = null;
            this.btn_remove_all.Iconimage_right_Selected = null;
            this.btn_remove_all.Iconimage_Selected = null;
            this.btn_remove_all.IconMarginLeft = 0;
            this.btn_remove_all.IconMarginRight = 0;
            this.btn_remove_all.IconRightVisible = true;
            this.btn_remove_all.IconRightZoom = 0D;
            this.btn_remove_all.IconVisible = true;
            this.btn_remove_all.IconZoom = 70D;
            this.btn_remove_all.IsTab = false;
            this.btn_remove_all.Location = new System.Drawing.Point(400, 434);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_remove_all.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_remove_all.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_remove_all.selected = false;
            this.btn_remove_all.Size = new System.Drawing.Size(162, 48);
            this.btn_remove_all.TabIndex = 88;
            this.btn_remove_all.Text = "حذف الكل";
            this.btn_remove_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_remove_all.Textcolor = System.Drawing.Color.White;
            this.btn_remove_all.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_all.Click += new System.EventHandler(this.btn_remove_all_Click);
            // 
            // btn_choes_cat
            // 
            this.btn_choes_cat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_choes_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_choes_cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_choes_cat.BorderRadius = 0;
            this.btn_choes_cat.ButtonText = "اختيار";
            this.btn_choes_cat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choes_cat.DisabledColor = System.Drawing.Color.Gray;
            this.btn_choes_cat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choes_cat.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_choes_cat.Iconimage = null;
            this.btn_choes_cat.Iconimage_right = null;
            this.btn_choes_cat.Iconimage_right_Selected = null;
            this.btn_choes_cat.Iconimage_Selected = null;
            this.btn_choes_cat.IconMarginLeft = 0;
            this.btn_choes_cat.IconMarginRight = 0;
            this.btn_choes_cat.IconRightVisible = false;
            this.btn_choes_cat.IconRightZoom = 0D;
            this.btn_choes_cat.IconVisible = false;
            this.btn_choes_cat.IconZoom = 70D;
            this.btn_choes_cat.IsTab = false;
            this.btn_choes_cat.Location = new System.Drawing.Point(908, 55);
            this.btn_choes_cat.Name = "btn_choes_cat";
            this.btn_choes_cat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_choes_cat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_choes_cat.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_choes_cat.selected = false;
            this.btn_choes_cat.Size = new System.Drawing.Size(101, 27);
            this.btn_choes_cat.TabIndex = 87;
            this.btn_choes_cat.Text = "اختيار";
            this.btn_choes_cat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_choes_cat.Textcolor = System.Drawing.Color.White;
            this.btn_choes_cat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choes_cat.Click += new System.EventHandler(this.btn_choes_cat_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(942, 123);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(69, 35);
            this.btn_2.TabIndex = 86;
            this.btn_2.Text = "-";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 35);
            this.button1.TabIndex = 85;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_serch
            // 
            this.btn_serch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_serch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_serch.BorderRadius = 0;
            this.btn_serch.ButtonText = "بحث";
            this.btn_serch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_serch.DisabledColor = System.Drawing.Color.Gray;
            this.btn_serch.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_serch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_serch.Iconimage")));
            this.btn_serch.Iconimage_right = null;
            this.btn_serch.Iconimage_right_Selected = null;
            this.btn_serch.Iconimage_Selected = null;
            this.btn_serch.IconMarginLeft = 0;
            this.btn_serch.IconMarginRight = 0;
            this.btn_serch.IconRightVisible = true;
            this.btn_serch.IconRightZoom = 0D;
            this.btn_serch.IconVisible = true;
            this.btn_serch.IconZoom = 70D;
            this.btn_serch.IsTab = false;
            this.btn_serch.Location = new System.Drawing.Point(9, 434);
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_serch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_serch.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_serch.selected = false;
            this.btn_serch.Size = new System.Drawing.Size(162, 48);
            this.btn_serch.TabIndex = 84;
            this.btn_serch.Text = "بحث";
            this.btn_serch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_serch.Textcolor = System.Drawing.Color.White;
            this.btn_serch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.BorderRadius = 0;
            this.btn_delete.ButtonText = "حذف المحدد";
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
            this.btn_delete.Location = new System.Drawing.Point(587, 434);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.selected = false;
            this.btn_delete.Size = new System.Drawing.Size(162, 48);
            this.btn_delete.TabIndex = 82;
            this.btn_delete.Text = "حذف المحدد";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Textcolor = System.Drawing.Color.White;
            this.btn_delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 0;
            this.btn_add.ButtonText = "إضافة";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_add.Iconimage")));
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 0;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = true;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 70D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(776, 434);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(162, 48);
            this.btn_add.TabIndex = 81;
            this.btn_add.Text = "إضافة";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.BorderRadius = 0;
            this.btn_refresh.ButtonText = "جديد";
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
            this.btn_refresh.Location = new System.Drawing.Point(210, 434);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_refresh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_refresh.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_refresh.selected = false;
            this.btn_refresh.Size = new System.Drawing.Size(162, 48);
            this.btn_refresh.TabIndex = 89;
            this.btn_refresh.Text = "جديد";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.Textcolor = System.Drawing.Color.White;
            this.btn_refresh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1047, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spend)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_spend_code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_qte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qte_in_stock;
        private System.Windows.Forms.TextBox txt_cat_unit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_spend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cat_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cat_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_serch;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private System.Windows.Forms.DateTimePicker dt_spend;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_choes_cat;
        private Bunifu.Framework.UI.BunifuFlatButton btn_remove_all;
        private Bunifu.Framework.UI.BunifuFlatButton btn_refresh;
    }
}
