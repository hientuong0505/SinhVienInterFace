namespace WinformBuoi1
{
    partial class frm_TIMTHU
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
            this.txt_THU = new System.Windows.Forms.TextBox();
            this.btn_TIM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thứ";
            // 
            // txt_THU
            // 
            this.txt_THU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_THU.Location = new System.Drawing.Point(189, 76);
            this.txt_THU.Margin = new System.Windows.Forms.Padding(4);
            this.txt_THU.Name = "txt_THU";
            this.txt_THU.Size = new System.Drawing.Size(108, 30);
            this.txt_THU.TabIndex = 1;
            this.txt_THU.TextChanged += new System.EventHandler(this.txt_THU_TextChanged);
            // 
            // btn_TIM
            // 
            this.btn_TIM.Location = new System.Drawing.Point(189, 142);
            this.btn_TIM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TIM.Name = "btn_TIM";
            this.btn_TIM.Size = new System.Drawing.Size(108, 28);
            this.btn_TIM.TabIndex = 2;
            this.btn_TIM.Text = "Tìm";
            this.btn_TIM.UseVisualStyleBackColor = true;
            this.btn_TIM.Click += new System.EventHandler(this.btn_TIM_Click);
            // 
            // frm_TIMTHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 258);
            this.Controls.Add(this.btn_TIM);
            this.Controls.Add(this.txt_THU);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TIMTHU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm thứ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_THU;
        private System.Windows.Forms.Button btn_TIM;
    }
}