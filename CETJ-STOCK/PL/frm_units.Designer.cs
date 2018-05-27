namespace CETJ_STOCK.PL
{
    partial class frm_units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_units));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_deleate_unit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_save_unit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_unit = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_colse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_unit_code_en = new System.Windows.Forms.TextBox();
            this.txt_unit_id = new System.Windows.Forms.TextBox();
            this.txt_unit_code_ar = new System.Windows.Forms.TextBox();
            this.txt_unit_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_new = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "الوحدات";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_edit.Location = new System.Drawing.Point(254, 414);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(100, 48);
            this.btn_edit.TabIndex = 89;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.White;
            this.btn_edit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click_1);
            // 
            // btn_deleate_unit
            // 
            this.btn_deleate_unit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_deleate_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_deleate_unit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deleate_unit.BorderRadius = 0;
            this.btn_deleate_unit.ButtonText = "حذف";
            this.btn_deleate_unit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleate_unit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_deleate_unit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_deleate_unit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_deleate_unit.Iconimage")));
            this.btn_deleate_unit.Iconimage_right = null;
            this.btn_deleate_unit.Iconimage_right_Selected = null;
            this.btn_deleate_unit.Iconimage_Selected = null;
            this.btn_deleate_unit.IconMarginLeft = 0;
            this.btn_deleate_unit.IconMarginRight = 0;
            this.btn_deleate_unit.IconRightVisible = true;
            this.btn_deleate_unit.IconRightZoom = 0D;
            this.btn_deleate_unit.IconVisible = true;
            this.btn_deleate_unit.IconZoom = 70D;
            this.btn_deleate_unit.IsTab = false;
            this.btn_deleate_unit.Location = new System.Drawing.Point(141, 414);
            this.btn_deleate_unit.Name = "btn_deleate_unit";
            this.btn_deleate_unit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_deleate_unit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_deleate_unit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_deleate_unit.selected = false;
            this.btn_deleate_unit.Size = new System.Drawing.Size(100, 48);
            this.btn_deleate_unit.TabIndex = 88;
            this.btn_deleate_unit.Text = "حذف";
            this.btn_deleate_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_deleate_unit.Textcolor = System.Drawing.Color.White;
            this.btn_deleate_unit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleate_unit.Click += new System.EventHandler(this.btn_deleate_unit_Click_1);
            // 
            // btn_save_unit
            // 
            this.btn_save_unit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_save_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_save_unit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save_unit.BorderRadius = 0;
            this.btn_save_unit.ButtonText = "إضافة";
            this.btn_save_unit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_unit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_save_unit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save_unit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_save_unit.Iconimage")));
            this.btn_save_unit.Iconimage_right = null;
            this.btn_save_unit.Iconimage_right_Selected = null;
            this.btn_save_unit.Iconimage_Selected = null;
            this.btn_save_unit.IconMarginLeft = 0;
            this.btn_save_unit.IconMarginRight = 0;
            this.btn_save_unit.IconRightVisible = true;
            this.btn_save_unit.IconRightZoom = 0D;
            this.btn_save_unit.IconVisible = true;
            this.btn_save_unit.IconZoom = 70D;
            this.btn_save_unit.IsTab = false;
            this.btn_save_unit.Location = new System.Drawing.Point(26, 414);
            this.btn_save_unit.Name = "btn_save_unit";
            this.btn_save_unit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_save_unit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_save_unit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save_unit.selected = false;
            this.btn_save_unit.Size = new System.Drawing.Size(100, 48);
            this.btn_save_unit.TabIndex = 87;
            this.btn_save_unit.Text = "إضافة";
            this.btn_save_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save_unit.Textcolor = System.Drawing.Color.White;
            this.btn_save_unit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_unit.Click += new System.EventHandler(this.btn_save_unit_Click_1);
            // 
            // dgv_unit
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_unit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_unit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_unit.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_unit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_unit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_unit.ColumnHeadersVisible = false;
            this.dgv_unit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_unit.DoubleBuffered = true;
            this.dgv_unit.EnableHeadersVisualStyles = false;
            this.dgv_unit.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgv_unit.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_unit.Location = new System.Drawing.Point(26, 165);
            this.dgv_unit.Name = "dgv_unit";
            this.dgv_unit.ReadOnly = true;
            this.dgv_unit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_unit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_unit.Size = new System.Drawing.Size(435, 236);
            this.dgv_unit.TabIndex = 86;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "unit_id";
            this.Column1.FillWeight = 101.5228F;
            this.Column1.HeaderText = "رقم الوحدة";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "unit_name";
            this.Column2.FillWeight = 99.49239F;
            this.Column2.HeaderText = "اسم الوحدة";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "code_ar";
            this.Column3.FillWeight = 99.49239F;
            this.Column3.HeaderText = "رمز الوحدة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "code_en";
            this.Column4.FillWeight = 99.49239F;
            this.Column4.HeaderText = "رمز لاتيني";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btn_colse
            // 
            this.btn_colse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_colse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_colse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_colse.BorderRadius = 0;
            this.btn_colse.ButtonText = "الرجوع";
            this.btn_colse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_colse.DisabledColor = System.Drawing.Color.Gray;
            this.btn_colse.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_colse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_colse.Iconimage")));
            this.btn_colse.Iconimage_right = null;
            this.btn_colse.Iconimage_right_Selected = null;
            this.btn_colse.Iconimage_Selected = null;
            this.btn_colse.IconMarginLeft = 0;
            this.btn_colse.IconMarginRight = 0;
            this.btn_colse.IconRightVisible = true;
            this.btn_colse.IconRightZoom = 0D;
            this.btn_colse.IconVisible = true;
            this.btn_colse.IconZoom = 70D;
            this.btn_colse.IsTab = false;
            this.btn_colse.Location = new System.Drawing.Point(363, 414);
            this.btn_colse.Name = "btn_colse";
            this.btn_colse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_colse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_colse.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_colse.selected = false;
            this.btn_colse.Size = new System.Drawing.Size(100, 48);
            this.btn_colse.TabIndex = 90;
            this.btn_colse.Text = "الرجوع";
            this.btn_colse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_colse.Textcolor = System.Drawing.Color.White;
            this.btn_colse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colse.Click += new System.EventHandler(this.btn_colse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 63);
            this.panel1.TabIndex = 95;
            // 
            // txt_unit_code_en
            // 
            this.txt_unit_code_en.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_code_en.Location = new System.Drawing.Point(364, 137);
            this.txt_unit_code_en.Name = "txt_unit_code_en";
            this.txt_unit_code_en.Size = new System.Drawing.Size(97, 27);
            this.txt_unit_code_en.TabIndex = 85;
            // 
            // txt_unit_id
            // 
            this.txt_unit_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_id.Location = new System.Drawing.Point(66, 137);
            this.txt_unit_id.Name = "txt_unit_id";
            this.txt_unit_id.ReadOnly = true;
            this.txt_unit_id.Size = new System.Drawing.Size(100, 27);
            this.txt_unit_id.TabIndex = 91;
            // 
            // txt_unit_code_ar
            // 
            this.txt_unit_code_ar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_code_ar.Location = new System.Drawing.Point(266, 137);
            this.txt_unit_code_ar.Name = "txt_unit_code_ar";
            this.txt_unit_code_ar.Size = new System.Drawing.Size(97, 27);
            this.txt_unit_code_ar.TabIndex = 84;
            // 
            // txt_unit_name
            // 
            this.txt_unit_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit_name.Location = new System.Drawing.Point(167, 137);
            this.txt_unit_name.Name = "txt_unit_name";
            this.txt_unit_name.Size = new System.Drawing.Size(98, 27);
            this.txt_unit_name.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 104);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(98, 35);
            this.label1.TabIndex = 83;
            this.label1.Text = "اسم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 104);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.TabIndex = 92;
            this.label4.Text = "المعرف";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(267, 104);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(96, 35);
            this.label6.TabIndex = 94;
            this.label6.Text = "ر . عربي";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(365, 104);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(96, 35);
            this.label5.TabIndex = 93;
            this.label5.Text = "ر . لاتيني";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_new
            // 
            this.btn_new.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.BorderRadius = 0;
            this.btn_new.ButtonText = "bunifuFlatButton5";
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
            this.btn_new.Location = new System.Drawing.Point(26, 104);
            this.btn_new.Name = "btn_new";
            this.btn_new.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.btn_new.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_new.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_new.selected = false;
            this.btn_new.Size = new System.Drawing.Size(35, 35);
            this.btn_new.TabIndex = 96;
            this.btn_new.Text = "bunifuFlatButton5";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Textcolor = System.Drawing.Color.White;
            this.btn_new.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 479);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_deleate_unit);
            this.Controls.Add(this.btn_save_unit);
            this.Controls.Add(this.dgv_unit);
            this.Controls.Add(this.btn_colse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_unit_code_en);
            this.Controls.Add(this.txt_unit_id);
            this.Controls.Add(this.txt_unit_code_ar);
            this.Controls.Add(this.txt_unit_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_units";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة وحدة";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_edit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_deleate_unit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_save_unit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_colse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_unit_code_en;
        private System.Windows.Forms.TextBox txt_unit_id;
        private System.Windows.Forms.TextBox txt_unit_code_ar;
        private System.Windows.Forms.TextBox txt_unit_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btn_new;
    }
}