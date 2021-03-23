namespace WinformBuoi1
{
    partial class frm_DANGNHAP
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
            this.lb_TAIKHOAN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TAIKHOAN = new System.Windows.Forms.TextBox();
            this.txt_MATKHAU = new System.Windows.Forms.TextBox();
            this.btn_DANGNHAP = new System.Windows.Forms.Button();
            this.btn_NHAPLAI = new System.Windows.Forms.Button();
            this.btn_THOAT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_TAIKHOAN
            // 
            this.lb_TAIKHOAN.AutoSize = true;
            this.lb_TAIKHOAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TAIKHOAN.Location = new System.Drawing.Point(181, 85);
            this.lb_TAIKHOAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TAIKHOAN.Name = "lb_TAIKHOAN";
            this.lb_TAIKHOAN.Size = new System.Drawing.Size(131, 25);
            this.lb_TAIKHOAN.TabIndex = 0;
            this.lb_TAIKHOAN.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_TAIKHOAN
            // 
            this.txt_TAIKHOAN.Location = new System.Drawing.Point(329, 85);
            this.txt_TAIKHOAN.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TAIKHOAN.Name = "txt_TAIKHOAN";
            this.txt_TAIKHOAN.Size = new System.Drawing.Size(285, 22);
            this.txt_TAIKHOAN.TabIndex = 2;
            // 
            // txt_MATKHAU
            // 
            this.txt_MATKHAU.Location = new System.Drawing.Point(329, 155);
            this.txt_MATKHAU.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MATKHAU.Name = "txt_MATKHAU";
            this.txt_MATKHAU.PasswordChar = '&';
            this.txt_MATKHAU.Size = new System.Drawing.Size(285, 22);
            this.txt_MATKHAU.TabIndex = 3;
            // 
            // btn_DANGNHAP
            // 
            this.btn_DANGNHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DANGNHAP.Location = new System.Drawing.Point(169, 292);
            this.btn_DANGNHAP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DANGNHAP.Name = "btn_DANGNHAP";
            this.btn_DANGNHAP.Size = new System.Drawing.Size(133, 62);
            this.btn_DANGNHAP.TabIndex = 4;
            this.btn_DANGNHAP.Text = "Đăng nhập";
            this.btn_DANGNHAP.UseVisualStyleBackColor = true;
            this.btn_DANGNHAP.Click += new System.EventHandler(this.btn_DANGNHAP_Click);
            // 
            // btn_NHAPLAI
            // 
            this.btn_NHAPLAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NHAPLAI.Location = new System.Drawing.Point(352, 292);
            this.btn_NHAPLAI.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NHAPLAI.Name = "btn_NHAPLAI";
            this.btn_NHAPLAI.Size = new System.Drawing.Size(133, 62);
            this.btn_NHAPLAI.TabIndex = 5;
            this.btn_NHAPLAI.Text = "Nhập lại";
            this.btn_NHAPLAI.UseVisualStyleBackColor = true;
            this.btn_NHAPLAI.Click += new System.EventHandler(this.btn_NHAPLAI_Click);
            // 
            // btn_THOAT
            // 
            this.btn_THOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_THOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THOAT.Location = new System.Drawing.Point(556, 292);
            this.btn_THOAT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(133, 62);
            this.btn_THOAT.TabIndex = 6;
            this.btn_THOAT.Text = "Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // frm_DANGNHAP
            // 
            this.AcceptButton = this.btn_DANGNHAP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_THOAT;
            this.ClientSize = new System.Drawing.Size(859, 386);
            this.Controls.Add(this.btn_THOAT);
            this.Controls.Add(this.btn_NHAPLAI);
            this.Controls.Add(this.btn_DANGNHAP);
            this.Controls.Add(this.txt_MATKHAU);
            this.Controls.Add(this.txt_TAIKHOAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_TAIKHOAN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DANGNHAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_DANGNHAP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TAIKHOAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TAIKHOAN;
        private System.Windows.Forms.TextBox txt_MATKHAU;
        private System.Windows.Forms.Button btn_DANGNHAP;
        private System.Windows.Forms.Button btn_NHAPLAI;
        private System.Windows.Forms.Button btn_THOAT;
    }
}