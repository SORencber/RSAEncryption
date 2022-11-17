namespace RSAEncryption
{
    partial class Form1
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
            this.txtencrypt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtdecrypt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtplain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtencodingto64 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtdecodingfrombase64 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtencrypt
            // 
            this.txtencrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtencrypt.ForeColor = System.Drawing.Color.Red;
            this.txtencrypt.Location = new System.Drawing.Point(18, 285);
            this.txtencrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtencrypt.Multiline = true;
            this.txtencrypt.Name = "txtencrypt";
            this.txtencrypt.Size = new System.Drawing.Size(844, 102);
            this.txtencrypt.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1046, 756);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 105);
            this.button2.TabIndex = 8;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdecrypt
            // 
            this.txtdecrypt.Location = new System.Drawing.Point(27, 759);
            this.txtdecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdecrypt.Multiline = true;
            this.txtdecrypt.Name = "txtdecrypt";
            this.txtdecrypt.Size = new System.Drawing.Size(966, 102);
            this.txtdecrypt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 105);
            this.button1.TabIndex = 6;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtplain
            // 
            this.txtplain.Location = new System.Drawing.Point(18, 142);
            this.txtplain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtplain.Multiline = true;
            this.txtplain.Name = "txtplain";
            this.txtplain.Size = new System.Drawing.Size(844, 102);
            this.txtplain.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Encrypted Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(49, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1047, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "Asymmetric Encryption-RSA and Base64 Coding ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Plain Text For Encryption";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 720);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Plain Text After Decryption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1103, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "by Serhat Ömer Rencber";
            // 
            // txtencodingto64
            // 
            this.txtencodingto64.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtencodingto64.ForeColor = System.Drawing.Color.Red;
            this.txtencodingto64.Location = new System.Drawing.Point(18, 434);
            this.txtencodingto64.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtencodingto64.Multiline = true;
            this.txtencodingto64.Name = "txtencodingto64";
            this.txtencodingto64.Size = new System.Drawing.Size(844, 102);
            this.txtencodingto64.TabIndex = 15;
            this.txtencodingto64.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(902, 434);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 105);
            this.button3.TabIndex = 16;
            this.button3.Text = "Encoding";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Encoding To Base64";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 557);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Decoding from Base64";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(902, 588);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 105);
            this.button4.TabIndex = 19;
            this.button4.Text = "Decoding";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtdecodingfrombase64
            // 
            this.txtdecodingfrombase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdecodingfrombase64.ForeColor = System.Drawing.Color.Red;
            this.txtdecodingfrombase64.Location = new System.Drawing.Point(18, 588);
            this.txtdecodingfrombase64.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdecodingfrombase64.Multiline = true;
            this.txtdecodingfrombase64.Name = "txtdecodingfrombase64";
            this.txtdecodingfrombase64.Size = new System.Drawing.Size(844, 102);
            this.txtdecodingfrombase64.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 938);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtdecodingfrombase64);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtencodingto64);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtencrypt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtdecrypt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtplain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RSA Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtencrypt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtdecrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtplain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtencodingto64;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtdecodingfrombase64;
    }
}

