using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using SwissTransport;

namespace ÖVinder {
    public partial class Popup : Form {
        private String body;


        public Popup() {
            InitializeComponent();
        }

        public void setBody(String body) {
            this.body = body;
            textBoxBody.Text = body;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e) {
            var fromAddress = new MailAddress("modul318vfi@gmail.com", "SwissTransport");
            var toAddress = new MailAddress(textBoxReciver.Text, textBoxReciver.Text);
            const string fromPassword = "vfibeschte";
            const string subject = "SwissTransport verbindung";
            string body = textBoxBody.Text;

            var smtp = new SmtpClient {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress) {
                Subject = subject,
                Body = body
            }) {
                smtp.Send(message);
            }
        }
    }
}
