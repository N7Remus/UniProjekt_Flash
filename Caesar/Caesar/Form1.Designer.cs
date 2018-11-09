namespace Caesar
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
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.inText = new System.Windows.Forms.RichTextBox();
            this.outText = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(23, 147);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(219, 23);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(259, 147);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(176, 23);
            this.Decrypt.TabIndex = 1;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // inText
            // 
            this.inText.BackColor = System.Drawing.Color.DarkRed;
            this.inText.ForeColor = System.Drawing.SystemColors.Info;
            this.inText.Location = new System.Drawing.Point(22, 12);
            this.inText.Name = "inText";
            this.inText.Size = new System.Drawing.Size(766, 129);
            this.inText.TabIndex = 2;
            this.inText.Text = "";
            // 
            // outText
            // 
            this.outText.BackColor = System.Drawing.Color.DarkRed;
            this.outText.ForeColor = System.Drawing.SystemColors.Info;
            this.outText.Location = new System.Drawing.Point(22, 189);
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(766, 129);
            this.outText.TabIndex = 3;
            this.outText.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "ver1",
            "ver2",
            "ver3"});
            this.comboBox1.Location = new System.Drawing.Point(665, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(798, 351);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.inText);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.RichTextBox inText;
        private System.Windows.Forms.RichTextBox outText;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

