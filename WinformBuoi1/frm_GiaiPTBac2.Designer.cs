
namespace WinformBuoi1
{
    partial class frm_GiaiPTBac2
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_HeSoA = new System.Windows.Forms.TextBox();
            this.txt_HeSoC = new System.Windows.Forms.TextBox();
            this.txt_HeSoB = new System.Windows.Forms.TextBox();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.btn_GIAI = new System.Windows.Forms.Button();
            this.btn_THOAT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(61, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hệ số A";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(62, 109);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Hệ số B";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(62, 181);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Hệ số C";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(61, 262);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 24);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Kết quả";
            // 
            // txt_HeSoA
            // 
            this.txt_HeSoA.Location = new System.Drawing.Point(189, 27);
            this.txt_HeSoA.Name = "txt_HeSoA";
            this.txt_HeSoA.Size = new System.Drawing.Size(159, 22);
            this.txt_HeSoA.TabIndex = 4;
            // 
            // txt_HeSoC
            // 
            this.txt_HeSoC.Location = new System.Drawing.Point(189, 140);
            this.txt_HeSoC.Name = "txt_HeSoC";
            this.txt_HeSoC.Size = new System.Drawing.Size(159, 22);
            this.txt_HeSoC.TabIndex = 5;
            // 
            // txt_HeSoB
            // 
            this.txt_HeSoB.Location = new System.Drawing.Point(189, 82);
            this.txt_HeSoB.Name = "txt_HeSoB";
            this.txt_HeSoB.Size = new System.Drawing.Size(159, 22);
            this.txt_HeSoB.TabIndex = 6;
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(189, 207);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(159, 22);
            this.txt_KetQua.TabIndex = 7;
            // 
            // btn_GIAI
            // 
            this.btn_GIAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GIAI.Location = new System.Drawing.Point(76, 297);
            this.btn_GIAI.Name = "btn_GIAI";
            this.btn_GIAI.Size = new System.Drawing.Size(133, 49);
            this.btn_GIAI.TabIndex = 8;
            this.btn_GIAI.Text = "Giải";
            this.btn_GIAI.UseVisualStyleBackColor = true;
            this.btn_GIAI.Click += new System.EventHandler(this.btn_GIAI_Click);
            // 
            // btn_THOAT
            // 
            this.btn_THOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THOAT.Location = new System.Drawing.Point(268, 297);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(133, 49);
            this.btn_THOAT.TabIndex = 9;
            this.btn_THOAT.Text = "Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // frm_GiaiPTBac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 394);
            this.Controls.Add(this.btn_THOAT);
            this.Controls.Add(this.btn_GIAI);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.txt_HeSoB);
            this.Controls.Add(this.txt_HeSoC);
            this.Controls.Add(this.txt_HeSoA);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_GiaiPTBac2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_GiaiPTBac2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txt_HeSoA;
        private System.Windows.Forms.TextBox txt_HeSoC;
        private System.Windows.Forms.TextBox txt_HeSoB;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.Button btn_GIAI;
        private System.Windows.Forms.Button btn_THOAT;
    }
}