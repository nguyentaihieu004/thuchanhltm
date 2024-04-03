namespace Lab02_22520442
{
    partial class Lab02_bai2
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
            this.btread = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1filename = new System.Windows.Forms.TextBox();
            this.textBox2size = new System.Windows.Forms.TextBox();
            this.textBox3url = new System.Windows.Forms.TextBox();
            this.textBox4linecount = new System.Windows.Forms.TextBox();
            this.textBox5wordscount = new System.Windows.Forms.TextBox();
            this.textBox6characcount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btread
            // 
            this.btread.Location = new System.Drawing.Point(12, 12);
            this.btread.Name = "btread";
            this.btread.Size = new System.Drawing.Size(392, 48);
            this.btread.TabIndex = 0;
            this.btread.Text = "Read From File";
            this.btread.UseVisualStyleBackColor = true;
            this.btread.Click += new System.EventHandler(this.btread_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Words count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Line count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Characters count";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(424, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(364, 634);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // textBox1filename
            // 
            this.textBox1filename.Location = new System.Drawing.Point(146, 102);
            this.textBox1filename.Multiline = true;
            this.textBox1filename.Name = "textBox1filename";
            this.textBox1filename.Size = new System.Drawing.Size(258, 36);
            this.textBox1filename.TabIndex = 8;
            // 
            // textBox2size
            // 
            this.textBox2size.Location = new System.Drawing.Point(146, 170);
            this.textBox2size.Multiline = true;
            this.textBox2size.Name = "textBox2size";
            this.textBox2size.Size = new System.Drawing.Size(258, 36);
            this.textBox2size.TabIndex = 9;
            // 
            // textBox3url
            // 
            this.textBox3url.Location = new System.Drawing.Point(146, 251);
            this.textBox3url.Multiline = true;
            this.textBox3url.Name = "textBox3url";
            this.textBox3url.Size = new System.Drawing.Size(258, 36);
            this.textBox3url.TabIndex = 10;
            // 
            // textBox4linecount
            // 
            this.textBox4linecount.Location = new System.Drawing.Point(146, 322);
            this.textBox4linecount.Multiline = true;
            this.textBox4linecount.Name = "textBox4linecount";
            this.textBox4linecount.Size = new System.Drawing.Size(258, 36);
            this.textBox4linecount.TabIndex = 11;
            // 
            // textBox5wordscount
            // 
            this.textBox5wordscount.Location = new System.Drawing.Point(146, 395);
            this.textBox5wordscount.Multiline = true;
            this.textBox5wordscount.Name = "textBox5wordscount";
            this.textBox5wordscount.Size = new System.Drawing.Size(258, 36);
            this.textBox5wordscount.TabIndex = 12;
            // 
            // textBox6characcount
            // 
            this.textBox6characcount.Location = new System.Drawing.Point(183, 482);
            this.textBox6characcount.Multiline = true;
            this.textBox6characcount.Name = "textBox6characcount";
            this.textBox6characcount.Size = new System.Drawing.Size(221, 36);
            this.textBox6characcount.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lab02_bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6characcount);
            this.Controls.Add(this.textBox5wordscount);
            this.Controls.Add(this.textBox4linecount);
            this.Controls.Add(this.textBox3url);
            this.Controls.Add(this.textBox2size);
            this.Controls.Add(this.textBox1filename);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btread);
            this.Name = "Lab02_bai2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lab02_bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1filename;
        private System.Windows.Forms.TextBox textBox2size;
        private System.Windows.Forms.TextBox textBox3url;
        private System.Windows.Forms.TextBox textBox4linecount;
        private System.Windows.Forms.TextBox textBox5wordscount;
        private System.Windows.Forms.TextBox textBox6characcount;
        private System.Windows.Forms.Button button1;
    }
}