using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontactKeepers
{
    // Should be public?
    class EmailConf
    {
        private string emailAddressUName = "KontactKeeper@campus-kiosk.co.za";
        private string mailPass = "g4Ha2QtlMi7D";
        private string incomingSSLServer = "host21.axxesslocal.co.za";
        private string imapPort = "993";
        private string pop3Port = "995";
        private string outgoingServer = "host21.axxesslocal.co.za";
        private string smtpPort = "465";

        public string EmailAddressUName { get => emailAddressUName; set => emailAddressUName = value; }
        public string MailPass { get => mailPass; set => mailPass = value; }
        public string IncomingSSLServer { get => incomingSSLServer; set => incomingSSLServer = value; }
        public string ImapPort { get => imapPort; set => imapPort = value; }
        public string Pop3Port { get => pop3Port; set => pop3Port = value; }
        public string OutgoingServer { get => outgoingServer; set => outgoingServer = value; }
        public string SmtpPort { get => smtpPort; set => smtpPort = value; }

        public void SendActivityEmail(string destAddress)
        {
            var messageToSend = new MimeMessage();
            
            messageToSend.Subject = "Account activity";
            BodyBuilder bb = new BodyBuilder();
            bb.HtmlBody = File.ReadAllText("index.html");
            messageToSend.Body = bb.ToMessageBody();
            messageToSend.From.Add(new MailboxAddress("KontactKeeper", emailAddressUName));
            messageToSend.To.Add(new MailboxAddress("Client", destAddress));

            using (var client = new SmtpClient())
            {
                client.Connect(outgoingServer, int.Parse(smtpPort), true);
                client.Authenticate(emailAddressUName, mailPass);
                client.Send(messageToSend);
                client.Disconnect(true);
            }
        }
    }
}
