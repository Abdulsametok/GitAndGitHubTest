using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace createhack
{
    public partial class Form2 : Form
    {

        public delegate void PasswordGeneratedHandler(List<string> passwords);
        public event PasswordGeneratedHandler PasswordGenerated;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int minLength = int.Parse(txtMinLength.Text);
            int maxLength = int.Parse(txtMaxLength.Text);
            string charset = txtCharset.Text;

            if (minLength > maxLength || string.IsNullOrEmpty(charset))
            {
                MessageBox.Show("Geçersiz giriş değerleri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> passwords = GeneratePasswords(minLength, maxLength, charset);
            PasswordGenerated?.Invoke(passwords);

            MessageBox.Show($"{passwords.Count} adet şifre oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private List<string> GeneratePasswords(int minLength, int maxLength, string charset)
        {
            var passwords = new List<string>();
            for (int length = minLength; length <= maxLength; length++)
            {
                var combinations = GetCombinations(charset.ToCharArray(), length);
                passwords.AddRange(combinations);
            }
            return passwords;
        }

        private IEnumerable<string> GetCombinations(char[] charset, int length)
        {
            if (length == 1)
                return charset.Select(c => c.ToString());

            var smallerCombos = GetCombinations(charset, length - 1);
            return smallerCombos.SelectMany(combo => charset, (combo, c) => combo + c);
        }
    }
}
