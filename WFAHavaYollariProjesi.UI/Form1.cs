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

            lstUcusBilgileri.Items.Add($"{adSoyad} {tarih} g�n� saat {saat} i�in {baslangicSehri} - {bitisSehri} aras� u�u�unuz vard�r. ");
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
                    MessageBox.Show("L�tfen mail g�ndermek istedi�iniz u�u�unuzu se�iniz.");
                    return;
                }
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("berkayarslanyzl@gmail.com");
                mailMessage.To.Add(txtMail.Text.Trim());
                mailMessage.Subject = "U�u� Bilgileri";
                mailMessage.Body = lstUcusBilgileri.SelectedItem.ToString();

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("berkayarslanyzl@gmail.com", "//(Uygulama �ifresi girilecek)");
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
                MessageBox.Show("Mail ba�ar�yla g�nderildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Mail g�nderim i�leminde bir hata olu�tu. L�tfen mail adresinizin do�ru oldu�undan emin olun!");
            }
        }
    }
}
