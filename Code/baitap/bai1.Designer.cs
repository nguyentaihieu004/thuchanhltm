namespace baitap
{
    partial class bai1
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
            this.sothunhat = new System.Windows.Forms.Label();
            this.sothuhai = new System.Windows.Forms.Label();
            this.txbsthunhat = new System.Windows.Forms.TextBox();
            this.txbsothuhai = new System.Windows.Forms.TextBox();
            this.Tinh = new System.Windows.Forms.Button();
            this.Tong = new System.Windows.Forms.Label();
            this.txbtong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính tổng 2 số nguyên";
            // 
            // sothunhat
            // 
            this.sothunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothunhat.Location = new System.Drawing.Point(212, 149);
            this.sothunhat.Name = "sothunhat";
            this.sothunhat.Size = new System.Drawing.Size(143, 27);
            this.sothunhat.TabIndex = 1;
            this.sothunhat.Text = "Số thứ nhất: ";
            // 
            // sothuhai
            // 
            this.sothuhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothuhai.Location = new System.Drawing.Point(217, 198);
            this.sothuhai.Name = "sothuhai";
            this.sothuhai.Size = new System.Drawing.Size(149, 27);
            this.sothuhai.TabIndex = 2;
            this.sothuhai.Text = "Số thứ hai: ";
            // 
            // txbsthunhat
            // 
            this.txbsthunhat.Location = new System.Drawing.Point(361, 149);
            this.txbsthunhat.Name = "txbsthunhat";
            this.txbsthunhat.Size = new System.Drawing.Size(181, 22);
            this.txbsthunhat.TabIndex = 3;
            this.txbsthunhat.TextChanged += new System.EventHandler(this.txbsthunhat_TextChanged);
            // 
            // txbsothuhai
            // 
            this.txbsothuhai.Location = new System.Drawing.Point(361, 202);
            this.txbsothuhai.Name = "txbsothuhai";
            this.txbsothuhai.Size = new System.Drawing.Size(181, 22);
            this.txbsothuhai.TabIndex = 4;
            this.txbsothuhai.TextChanged += new System.EventHandler(this.txbsothuhai_TextChanged);
            // 
            // Tinh
            // 
            this.Tinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tinh.Location = new System.Drawing.Point(248, 277);
            this.Tinh.Name = "Tinh";
            this.Tinh.Size = new System.Drawing.Size(294, 35);
            this.Tinh.TabIndex = 5;
            this.Tinh.Text = "Tính";
            this.Tinh.UseVisualStyleBackColor = false;
            this.Tinh.Click += new System.EventHandler(this.Tinh_Click);
            // 
            // Tong
            // 
            this.Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tong.Location = new System.Drawing.Point(243, 346);
            this.Tong.Name = "Tong";
            this.Tong.Size = new System.Drawing.Size(123, 27);
            this.Tong.TabIndex = 6;
            this.Tong.Text = "Tổng:";
            // 
            // txbtong
            // 
            this.txbtong.Location = new System.Drawing.Point(361, 346);
            this.txbtong.Name = "txbtong";
            this.txbtong.ReadOnly = true;
            this.txbtong.Size = new System.Drawing.Size(181, 22);
            this.txbtong.TabIndex = 7;
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbtong);
            this.Controls.Add(this.Tong);
            this.Controls.Add(this.Tinh);
            this.Controls.Add(this.txbsothuhai);
            this.Controls.Add(this.txbsthunhat);
            this.Controls.Add(this.sothuhai);
            this.Controls.Add(this.sothunhat);
            this.Controls.Add(this.label1);
            this.Name = "bai1";
            this.Text = "bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sothunhat;
        private System.Windows.Forms.Label sothuhai;
        private System.Windows.Forms.TextBox txbsthunhat;
        private System.Windows.Forms.TextBox txbsothuhai;
        private System.Windows.Forms.Button Tinh;
        private System.Windows.Forms.Label Tong;
        private System.Windows.Forms.TextBox txbtong;
    }
}