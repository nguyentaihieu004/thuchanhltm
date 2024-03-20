namespace baitap
{
    partial class Lab1_bai02
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sothunhat = new System.Windows.Forms.Label();
            this.sothuba = new System.Windows.Forms.Label();
            this.sothuhai = new System.Windows.Forms.Label();
            this.Tim = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.solonnhat = new System.Windows.Forms.Label();
            this.sonhonhat = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(670, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // sothunhat
            // 
            this.sothunhat.AutoSize = true;
            this.sothunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothunhat.Location = new System.Drawing.Point(25, 58);
            this.sothunhat.Name = "sothunhat";
            this.sothunhat.Size = new System.Drawing.Size(112, 25);
            this.sothunhat.TabIndex = 3;
            this.sothunhat.Text = "Số thứ nhất";
            // 
            // sothuba
            // 
            this.sothuba.AutoSize = true;
            this.sothuba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothuba.Location = new System.Drawing.Point(555, 59);
            this.sothuba.Name = "sothuba";
            this.sothuba.Size = new System.Drawing.Size(96, 25);
            this.sothuba.TabIndex = 4;
            this.sothuba.Text = "Số thứ ba";
            // 
            // sothuhai
            // 
            this.sothuhai.AutoSize = true;
            this.sothuhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothuhai.Location = new System.Drawing.Point(291, 62);
            this.sothuhai.Name = "sothuhai";
            this.sothuhai.Size = new System.Drawing.Size(100, 25);
            this.sothuhai.TabIndex = 5;
            this.sothuhai.Text = "Số thứ hai";
            // 
            // Tim
            // 
            this.Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Location = new System.Drawing.Point(143, 209);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(83, 40);
            this.Tim.TabIndex = 6;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(360, 209);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(89, 40);
            this.Xoa.TabIndex = 7;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(617, 209);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(83, 40);
            this.Thoat.TabIndex = 8;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // solonnhat
            // 
            this.solonnhat.AutoSize = true;
            this.solonnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solonnhat.Location = new System.Drawing.Point(60, 356);
            this.solonnhat.Name = "solonnhat";
            this.solonnhat.Size = new System.Drawing.Size(111, 25);
            this.solonnhat.TabIndex = 9;
            this.solonnhat.Text = "Số lớn nhất";
            // 
            // sonhonhat
            // 
            this.sonhonhat.AutoSize = true;
            this.sonhonhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonhonhat.Location = new System.Drawing.Point(470, 356);
            this.sonhonhat.Name = "sonhonhat";
            this.sonhonhat.Size = new System.Drawing.Size(118, 25);
            this.sonhonhat.TabIndex = 10;
            this.sonhonhat.Text = "Số nhỏ nhất";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 360);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(600, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 12;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.sonhonhat);
            this.Controls.Add(this.solonnhat);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.sothuhai);
            this.Controls.Add(this.sothuba);
            this.Controls.Add(this.sothunhat);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "bai2";
            this.Text = "bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label sothunhat;
        private System.Windows.Forms.Label sothuba;
        private System.Windows.Forms.Label sothuhai;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label solonnhat;
        private System.Windows.Forms.Label sonhonhat;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}