namespace WinformBuoi1
{
    partial class frm_NhapMang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MangA = new System.Windows.Forms.TextBox();
            this.txt_TongSoChan = new System.Windows.Forms.TextBox();
            this.txt_TongCacSoMangA = new System.Windows.Forms.TextBox();
            this.txt_TongSoLe = new System.Windows.Forms.TextBox();
            this.btn_TinhToan = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số lẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng số chẵn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng các số mảng A";
            // 
            // txt_MangA
            // 
            this.txt_MangA.Location = new System.Drawing.Point(203, 49);
            this.txt_MangA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MangA.Name = "txt_MangA";
            this.txt_MangA.Size = new System.Drawing.Size(216, 22);
            this.txt_MangA.TabIndex = 4;
            // 
            // txt_TongSoChan
            // 
            this.txt_TongSoChan.Location = new System.Drawing.Point(203, 220);
            this.txt_TongSoChan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongSoChan.Name = "txt_TongSoChan";
            this.txt_TongSoChan.Size = new System.Drawing.Size(216, 22);
            this.txt_TongSoChan.TabIndex = 5;
            // 
            // txt_TongCacSoMangA
            // 
            this.txt_TongCacSoMangA.Location = new System.Drawing.Point(203, 311);
            this.txt_TongCacSoMangA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongCacSoMangA.Name = "txt_TongCacSoMangA";
            this.txt_TongCacSoMangA.Size = new System.Drawing.Size(216, 22);
            this.txt_TongCacSoMangA.TabIndex = 6;
            // 
            // txt_TongSoLe
            // 
            this.txt_TongSoLe.Location = new System.Drawing.Point(203, 140);
            this.txt_TongSoLe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongSoLe.Name = "txt_TongSoLe";
            this.txt_TongSoLe.Size = new System.Drawing.Size(216, 22);
            this.txt_TongSoLe.TabIndex = 7;
            // 
            // btn_TinhToan
            // 
            this.btn_TinhToan.Location = new System.Drawing.Point(84, 398);
            this.btn_TinhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TinhToan.Name = "btn_TinhToan";
            this.btn_TinhToan.Size = new System.Drawing.Size(112, 63);
            this.btn_TinhToan.TabIndex = 8;
            this.btn_TinhToan.Text = "Tính toán";
            this.btn_TinhToan.UseVisualStyleBackColor = true;
            this.btn_TinhToan.Click += new System.EventHandler(this.btn_TinhToan_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(227, 398);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(108, 63);
            this.btn_LamMoi.TabIndex = 9;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(372, 398);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 63);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_NhapMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 490);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_TinhToan);
            this.Controls.Add(this.txt_TongSoLe);
            this.Controls.Add(this.txt_TongCacSoMangA);
            this.Controls.Add(this.txt_TongSoChan);
            this.Controls.Add(this.txt_MangA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_NhapMang";
            this.Text = "frm_NhapMang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MangA;
        private System.Windows.Forms.TextBox txt_TongSoChan;
        private System.Windows.Forms.TextBox txt_TongCacSoMangA;
        private System.Windows.Forms.TextBox txt_TongSoLe;
        private System.Windows.Forms.Button btn_TinhToan;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Thoat;
    }
}