using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestAdaptationFatClient
{
    public partial class SendEmailForm : Form
    {
        private List<string> MailTo { get; set; }
        public SendEmailForm(List<String> mailTo)
        {
            InitializeComponent();
            MailTo = mailTo;
            if (MailTo.Count > 1)
                lblTo.Text += " " + MailTo.Count;
            else
                lblTo.Text = "Получатель: " + MailTo[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            if (tbTitle.Text == "" || tbBody.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                EMailClient eml = new EMailClient();
                for (int i = 0; i < MailTo.Count; i++)
                {
                    Action ac = async () =>
                    {
                        await eml.SendEmailAsync(MailTo[i], tbTitle.Text, tbBody.Text);
                    };
                    ac.Invoke();
                }
                    MessageBox.Show("Письма успешно отправлены :)");
                    Close();
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка почновых серверов!");
            }
        }

        //private static async void SendEmail(string to)
        //{
        //    await Task.Run(() => EMailClient.SendMail(to, tbTitle.Text, tbBody.Text)); 
        //}
    }
}
