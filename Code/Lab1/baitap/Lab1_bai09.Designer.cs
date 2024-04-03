namespace baitap
{
    partial class Lab1_bai09
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxnhap = new System.Windows.Forms.TextBox();
            this.txbxuat = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.Timmonan = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 29;
            this.listBox.Location = new System.Drawing.Point(470, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(318, 207);
            this.listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Món ăn hôm nay là:";
            // 
            // tbxnhap
            // 
            this.tbxnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnhap.Location = new System.Drawing.Point(173, 34);
            this.tbxnhap.Multiline = true;
            this.tbxnhap.Name = "tbxnhap";
            this.tbxnhap.Size = new System.Drawing.Size(273, 25);
            this.tbxnhap.TabIndex = 3;
            // 
            // txbxuat
            // 
            this.txbxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxuat.Location = new System.Drawing.Point(208, 361);
            this.txbxuat.Multiline = true;
            this.txbxuat.Name = "txbxuat";
            this.txbxuat.Size = new System.Drawing.Size(336, 37);
            this.txbxuat.TabIndex = 4;
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(306, 93);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(100, 35);
            this.them.TabIndex = 5;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // Timmonan
            // 
            this.Timmonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timmonan.Location = new System.Drawing.Point(32, 274);
            this.Timmonan.Name = "Timmonan";
            this.Timmonan.Size = new System.Drawing.Size(187, 35);
            this.Timmonan.TabIndex = 6;
            this.Timmonan.Text = "Tìm món ăn";
            this.Timmonan.UseVisualStyleBackColor = true;
            this.Timmonan.Click += new System.EventHandler(this.Timmonan_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(362, 274);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(84, 35);
            this.xoa.TabIndex = 7;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(656, 274);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(92, 35);
            this.thoat.TabIndex = 8;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.Timmonan);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txbxuat);
            this.Controls.Add(this.tbxnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Name = "bai9";
            this.Text = "bai9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxnhap;
        private System.Windows.Forms.TextBox txbxuat;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button Timmonan;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
    }
}