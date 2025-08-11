namespace createhack
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblChar = new Label();
            lblMax = new Label();
            lblmin = new Label();
            btnGenerate = new Button();
            txtCharset = new TextBox();
            txtMaxLength = new TextBox();
            txtMinLength = new TextBox();
            SuspendLayout();
            // 
            // lblChar
            // 
            lblChar.AutoSize = true;
            lblChar.Location = new Point(23, 122);
            lblChar.Name = "lblChar";
            lblChar.Size = new Size(139, 20);
            lblChar.TabIndex = 13;
            lblChar.Text = "İstenen Karakterler :";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(26, 85);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(136, 20);
            lblMax.TabIndex = 12;
            lblMax.Text = "Maximum uzunluk :";
            // 
            // lblmin
            // 
            lblmin.AutoSize = true;
            lblmin.Location = new Point(29, 49);
            lblmin.Name = "lblmin";
            lblmin.Size = new Size(133, 20);
            lblmin.TabIndex = 11;
            lblmin.Text = "Minimum uzunluk :";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(237, 200);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 10;
            btnGenerate.Text = "Oluştur";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtCharset
            // 
            txtCharset.Location = new Point(168, 118);
            txtCharset.Name = "txtCharset";
            txtCharset.PlaceholderText = "Karakterler";
            txtCharset.Size = new Size(163, 27);
            txtCharset.TabIndex = 9;
            // 
            // txtMaxLength
            // 
            txtMaxLength.Location = new Point(168, 82);
            txtMaxLength.Name = "txtMaxLength";
            txtMaxLength.PlaceholderText = "Max Uzunluk";
            txtMaxLength.Size = new Size(163, 27);
            txtMaxLength.TabIndex = 8;
            // 
            // txtMinLength
            // 
            txtMinLength.Location = new Point(168, 46);
            txtMinLength.Name = "txtMinLength";
            txtMinLength.PlaceholderText = "Minimum uzunluk";
            txtMinLength.Size = new Size(163, 27);
            txtMinLength.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(354, 274);
            Controls.Add(lblChar);
            Controls.Add(lblMax);
            Controls.Add(lblmin);
            Controls.Add(btnGenerate);
            Controls.Add(txtCharset);
            Controls.Add(txtMaxLength);
            Controls.Add(txtMinLength);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Şifre Oluşturucu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChar;
        private Label lblMax;
        private Label lblmin;
        private Button btnGenerate;
        private TextBox txtCharset;
        private TextBox txtMaxLength;
        private TextBox txtMinLength;
    }
}