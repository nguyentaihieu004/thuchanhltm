namespace Lab02_22520442
{
    partial class Lab02_bai1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.docfile = new System.Windows.Forms.Button();
            this.ghifile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(379, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(399, 296);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // docfile
            // 
            this.docfile.Location = new System.Drawing.Point(101, 40);
            this.docfile.Name = "docfile";
            this.docfile.Size = new System.Drawing.Size(190, 62);
            this.docfile.TabIndex = 1;
            this.docfile.Text = "Đọc File";
            this.docfile.UseVisualStyleBackColor = true;
            this.docfile.Click += new System.EventHandler(this.docfile_Click);
            // 
            // ghifile
            // 
            this.ghifile.Location = new System.Drawing.Point(101, 179);
            this.ghifile.Name = "ghifile";
            this.ghifile.Size = new System.Drawing.Size(190, 62);
            this.ghifile.TabIndex = 2;
            this.ghifile.Text = "Ghi File";
            this.ghifile.UseVisualStyleBackColor = true;
            this.ghifile.Click += new System.EventHandler(this.ghifile_Click);
            // 
            // Lab02_bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ghifile);
            this.Controls.Add(this.docfile);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Lab02_bai1";
            this.Text = "Lab02_bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button docfile;
        private System.Windows.Forms.Button ghifile;
    }
}