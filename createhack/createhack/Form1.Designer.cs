namespace createhack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            tssCalısıyor = new ToolStripStatusLabel();
            tspProges = new ToolStripProgressBar();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblSonuc = new Label();
            lblPassword = new Label();
            lblUserName = new Label();
            btnCruch = new Button();
            URLtextbox = new TextBox();
            LoadPasswordFileButton = new Button();
            LoadUserFileButton = new Button();
            StopButton = new Button();
            StartButton = new Button();
            Denenenrichtextbox = new RichTextBox();
            Basarianahtaritextbox = new TextBox();
            user_txt_richTextBox1 = new RichTextBox();
            sifre_form_degiskeni_textbox = new TextBox();
            Kullanıcı_adı_form_degiskeni_textbox = new TextBox();
            sifre_txt_richTextBox1 = new RichTextBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssCalısıyor, tspProges, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 512);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(1003, 27);
            statusStrip1.TabIndex = 31;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssCalısıyor
            // 
            tssCalısıyor.Name = "tssCalısıyor";
            tssCalısıyor.Size = new Size(65, 21);
            tssCalısıyor.Text = "Çalışıyor";
            tssCalısıyor.Visible = false;
            // 
            // tspProges
            // 
            tspProges.Name = "tspProges";
            tspProges.Size = new Size(100, 19);
            tspProges.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BorderStyle = Border3DStyle.RaisedOuter;
            toolStripStatusLabel2.Enabled = false;
            toolStripStatusLabel2.Margin = new Padding(0, 5, 0, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.RightToLeft = RightToLeft.No;
            toolStripStatusLabel2.Size = new Size(988, 20);
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.Text = "Tüm Hakları SamyeliSoft'a Aittir.";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(443, 396);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(56, 20);
            lblSonuc.TabIndex = 30;
            lblSonuc.Text = "Sonuç :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(53, 218);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 20);
            lblPassword.TabIndex = 29;
            lblPassword.Text = "Denenecek Şifre :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(12, 106);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(164, 20);
            lblUserName.TabIndex = 28;
            lblUserName.Text = "Denenecek Kullacı Adı :";
            // 
            // btnCruch
            // 
            btnCruch.Location = new Point(408, 261);
            btnCruch.Name = "btnCruch";
            btnCruch.Size = new Size(137, 29);
            btnCruch.TabIndex = 27;
            btnCruch.Text = "Şifre Oluştur";
            btnCruch.UseVisualStyleBackColor = true;
            btnCruch.Click += btnCruch_Click;
            // 
            // URLtextbox
            // 
            URLtextbox.Location = new Point(336, 12);
            URLtextbox.Name = "URLtextbox";
            URLtextbox.PlaceholderText = "Sayfanın Adresini Giriniz";
            URLtextbox.Size = new Size(339, 27);
            URLtextbox.TabIndex = 26;
            // 
            // LoadPasswordFileButton
            // 
            LoadPasswordFileButton.Location = new Point(193, 261);
            LoadPasswordFileButton.Name = "LoadPasswordFileButton";
            LoadPasswordFileButton.Size = new Size(178, 29);
            LoadPasswordFileButton.TabIndex = 25;
            LoadPasswordFileButton.Text = "Şifre Dosyası Yükle";
            LoadPasswordFileButton.UseVisualStyleBackColor = true;
            LoadPasswordFileButton.Click += LoadPasswordFileButton_Click;
            // 
            // LoadUserFileButton
            // 
            LoadUserFileButton.Location = new Point(234, 155);
            LoadUserFileButton.Name = "LoadUserFileButton";
            LoadUserFileButton.Size = new Size(265, 29);
            LoadUserFileButton.TabIndex = 24;
            LoadUserFileButton.Text = "Kullanıcı Adı Dosyası Yükle";
            LoadUserFileButton.UseVisualStyleBackColor = true;
            LoadUserFileButton.Click += LoadUserFileButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(853, 278);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(94, 29);
            StopButton.TabIndex = 23;
            StopButton.Text = "StopButton";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(738, 278);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 22;
            StartButton.Text = "StartButton";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // Denenenrichtextbox
            // 
            Denenenrichtextbox.Location = new Point(505, 313);
            Denenenrichtextbox.Name = "Denenenrichtextbox";
            Denenenrichtextbox.Size = new Size(479, 160);
            Denenenrichtextbox.TabIndex = 21;
            Denenenrichtextbox.Text = "";
            // 
            // Basarianahtaritextbox
            // 
            Basarianahtaritextbox.Location = new Point(686, 157);
            Basarianahtaritextbox.Name = "Basarianahtaritextbox";
            Basarianahtaritextbox.PlaceholderText = "Başarılı Giriş Sonucu Aranan Kelime";
            Basarianahtaritextbox.Size = new Size(247, 27);
            Basarianahtaritextbox.TabIndex = 20;
            // 
            // user_txt_richTextBox1
            // 
            user_txt_richTextBox1.Location = new Point(182, 93);
            user_txt_richTextBox1.Name = "user_txt_richTextBox1";
            user_txt_richTextBox1.Size = new Size(373, 56);
            user_txt_richTextBox1.TabIndex = 19;
            user_txt_richTextBox1.Text = "";
            // 
            // sifre_form_degiskeni_textbox
            // 
            sifre_form_degiskeni_textbox.Location = new Point(53, 365);
            sifre_form_degiskeni_textbox.Name = "sifre_form_degiskeni_textbox";
            sifre_form_degiskeni_textbox.PlaceholderText = "Form Üzerindeki şifre kutucuğu adı ";
            sifre_form_degiskeni_textbox.Size = new Size(328, 27);
            sifre_form_degiskeni_textbox.TabIndex = 18;
            // 
            // Kullanıcı_adı_form_degiskeni_textbox
            // 
            Kullanıcı_adı_form_degiskeni_textbox.Location = new Point(53, 322);
            Kullanıcı_adı_form_degiskeni_textbox.Name = "Kullanıcı_adı_form_degiskeni_textbox";
            Kullanıcı_adı_form_degiskeni_textbox.PlaceholderText = "Form Üzerindeki kullanıcı adı kutucuğu adı ";
            Kullanıcı_adı_form_degiskeni_textbox.Size = new Size(328, 27);
            Kullanıcı_adı_form_degiskeni_textbox.TabIndex = 17;
            // 
            // sifre_txt_richTextBox1
            // 
            sifre_txt_richTextBox1.Location = new Point(182, 199);
            sifre_txt_richTextBox1.Name = "sifre_txt_richTextBox1";
            sifre_txt_richTextBox1.Size = new Size(373, 56);
            sifre_txt_richTextBox1.TabIndex = 16;
            sifre_txt_richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1003, 539);
            Controls.Add(statusStrip1);
            Controls.Add(lblSonuc);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(btnCruch);
            Controls.Add(URLtextbox);
            Controls.Add(LoadPasswordFileButton);
            Controls.Add(LoadUserFileButton);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(Denenenrichtextbox);
            Controls.Add(Basarianahtaritextbox);
            Controls.Add(user_txt_richTextBox1);
            Controls.Add(sifre_form_degiskeni_textbox);
            Controls.Add(Kullanıcı_adı_form_degiskeni_textbox);
            Controls.Add(sifre_txt_richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Create Hack";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssCalısıyor;
        private ToolStripProgressBar tspProges;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label lblSonuc;
        private Label lblPassword;
        private Label lblUserName;
        private Button btnCruch;
        private TextBox URLtextbox;
        private Button LoadPasswordFileButton;
        private Button LoadUserFileButton;
        private Button StopButton;
        private Button StartButton;
        private RichTextBox Denenenrichtextbox;
        private TextBox Basarianahtaritextbox;
        private RichTextBox user_txt_richTextBox1;
        private TextBox sifre_form_degiskeni_textbox;
        private TextBox Kullanıcı_adı_form_degiskeni_textbox;
        private RichTextBox sifre_txt_richTextBox1;
    }
}
