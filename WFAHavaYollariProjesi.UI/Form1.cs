using System.Net;
using System.Net.Mail;

namespace WFAHavaYollariProjesi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baslangicSehri, bitisSehri;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baslangicSehri = cbNereden.Text;
            bitisSehri = cbNereye.Text;
            string tarih = dtpTarih.Text;
            string saat = mtxtSaat.Text;
            string adSoyad = txtAdSoyad.Text;
            string tc = mtxtTc.Text;
            string telefon = mtxtTelefon.Text;

            lstUcusBilgileri.Items.Add($"{adSoyad} {tarih} günü saat {saat} için {baslangicSehri} - {bitisSehri} arasý uçuþunuz vardýr. ");
        }

        private void btnDegis_Click(object sender, EventArgs e)
        {
            string yedek;
            yedek = baslangicSehri;
            baslangicSehri = bitisSehri;
            bitisSehri = yedek;

            cbNereden.Text = baslangicSehri;
            cbNereye.Text = bitisSehri;
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {

            MailGonder();
        }

        void MailGonder()
        {
            try
            {
                if (lstUcusBilgileri.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen mail göndermek istediðiniz uçuþunuzu seçiniz.");
                    return;
                }
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("berkayarslanyzl@gmail.com");
                mailMessage.To.Add(txtMail.Text.Trim());
                mailMessage.Subject = "Uçuþ Bilgileri";
                mailMessage.Body = lstUcusBilgileri.SelectedItem.ToString();

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("berkayarslanyzl@gmail.com", "//(Uygulama þifresi girilecek)");
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
                MessageBox.Show("Mail baþarýyla gönderildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Mail gönderim iþleminde bir hata oluþtu. Lütfen mail adresinizin doðru olduðundan emin olun!");
            }
        }
    }
}
