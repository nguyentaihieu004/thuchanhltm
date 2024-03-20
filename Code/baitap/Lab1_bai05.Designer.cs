namespace baitap
{
    partial class Lab1_bai05
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
            this.txbKqtQua = new System.Windows.Forms.TextBox();
            this.textboxA = new System.Windows.Forms.TextBox();
            this.textboxB = new System.Windows.Forms.TextBox();
            this.Tinh = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết Quả";
            // 
            // txbKqtQua
            // 
            this.txbKqtQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKqtQua.Location = new System.Drawing.Point(41, 261);
            this.txbKqtQua.Multiline = true;
            this.txbKqtQua.Name = "txbKqtQua";
            this.txbKqtQua.Size = new System.Drawing.Size(728, 177);
            this.txbKqtQua.TabIndex = 3;
            this.txbKqtQua.TextChanged += new System.EventHandler(this.txbKqtQua_TextChanged);
            // 
            // textboxA
            // 
            this.textboxA.Location = new System.Drawing.Point(118, 59);
            this.textboxA.Name = "textboxA";
            this.textboxA.Size = new System.Drawing.Size(190, 22);
            this.textboxA.TabIndex = 4;
            // 
            // textboxB
            // 
            this.textboxB.Location = new System.Drawing.Point(501, 61);
            this.textboxB.Name = "textboxB";
            this.textboxB.Size = new System.Drawing.Size(196, 22);
            this.textboxB.TabIndex = 5;
            // 
            // Tinh
            // 
            this.Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tinh.Location = new System.Drawing.Point(68, 185);
            this.Tinh.Name = "Tinh";
            this.Tinh.Size = new System.Drawing.Size(150, 31);
            this.Tinh.TabIndex = 6;
            this.Tinh.Text = "Tính các giá trị";
            this.Tinh.UseVisualStyleBackColor = true;
            this.Tinh.Click += new System.EventHandler(this.Tinh_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(288, 185);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(65, 31);
            this.Xoa.TabIndex = 7;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(435, 185);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(73, 31);
            this.Thoat.TabIndex = 8;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.comboBox1.Location = new System.Drawing.Point(307, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Tinh);
            this.Controls.Add(this.textboxB);
            this.Controls.Add(this.textboxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbKqtQua);
            this.Name = "bai5";
            this.Text = "bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbKqtQua;
        private System.Windows.Forms.TextBox textboxA;
        private System.Windows.Forms.TextBox textboxB;
        private System.Windows.Forms.Button Tinh;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}