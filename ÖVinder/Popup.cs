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
        private String from;
        private String to;


        public Popup() {
            InitializeComponent();
        }

        public void setBody(String body) {
            this.body = body;
        }

        public void setFrom(String from) {
            this.from = from;
        }

        public void setTo(String to) {
            this.to = to;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e) {
            sendMail();
            this.Close();
        }

        private void sendMail() {
            var fromAddress = new MailAddress("modul318vfi@gmail.com", "SwissTransport");
            var toAddress = new MailAddress(textBoxReciver.Text, textBoxReciver.Text);
            const string fromPassword = "vfibeschte";
            const string subject = "SwissTransport verbindung";
            body += "<br>" + textBoxBody.Text;

            var smtp = new SmtpClient {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress) {
                IsBodyHtml = true,
                Subject = subject,
                Body = body
            }) {
                smtp.Send(message);
            }
        }

        private void textBoxReciver_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter) {
                sendMail();
                this.Close();
            }
        }
    }
}
