namespace DeTai_QuanLyNhanVien_NamLong
{
    partial class frmMain
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
            this.btnThue = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThue
            // 
            this.btnThue.Location = new System.Drawing.Point(6, 150);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(269, 118);
            this.btnThue.TabIndex = 0;
            this.btnThue.Text = "THUE SACH";
            this.btnThue.UseVisualStyleBackColor = true;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(6, 13);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(603, 131);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "DANH MUC";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(281, 150);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(328, 118);
            this.btnTra.TabIndex = 0;
            this.btnTra.Text = "TRA SACH";
            this.btnTra.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(6, 274);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(388, 118);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "THONG KE";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Tomato;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(400, 274);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(209, 118);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "DANG XUAT";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 404);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThue);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLogout;
    }
}