namespace CETJ_STOCK.PL
{
    partial class frm_spend_serch
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
            this.txt_spend_serch = new System.Windows.Forms.TextBox();
            this.dgv_spend_serch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spend_serch)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_spend_serch
            // 
            this.txt_spend_serch.Location = new System.Drawing.Point(14, 12);
            this.txt_spend_serch.Multiline = true;
            this.txt_spend_serch.Name = "txt_spend_serch";
            this.txt_spend_serch.Size = new System.Drawing.Size(250, 25);
            this.txt_spend_serch.TabIndex = 0;
            // 
            // dgv_spend_serch
            // 
            this.dgv_spend_serch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_spend_serch.Location = new System.Drawing.Point(14, 56);
            this.dgv_spend_serch.Name = "dgv_spend_serch";
            this.dgv_spend_serch.Size = new System.Drawing.Size(250, 194);
            this.dgv_spend_serch.TabIndex = 1;
            // 
            // frm_spend_serch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dgv_spend_serch);
            this.Controls.Add(this.txt_spend_serch);
            this.Name = "frm_spend_serch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spend_serch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_spend_serch;
        private System.Windows.Forms.DataGridView dgv_spend_serch;
    }
}