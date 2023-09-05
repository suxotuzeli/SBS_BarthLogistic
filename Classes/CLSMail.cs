using System.Net;
using System.Net.Mail;

namespace SBS_BarthLogistic.Classes
{
    class CLSMail
    {
        SmtpClient client;
        MailMessage msg;

        public CLSMail(string server, int port, string userName, string password)
        {
            FromAddress = InterfaceParameters.MailUserName;
            Password = InterfaceParameters.MailPassWord;
            Server = InterfaceParameters.MailOutcomeServer;
            Port = InterfaceParameters.MailSMTP;
            FromName = "";
            
            //სერვერი, პორტი
            //("smtp.gmail.com", 587);
            //("smtp-mail.outlook.com", 587);
            //("smtp.live.com", 587);
            //("smtp.mail.yahoo.com", 465);
            //("smtp.yandex.ru", 25);
            //("smtp.mail.ru", 25);
        }

        public string Password { get; set; }
        public string Server { get; set; }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
        public string[] Attachments { get; set; }
        public int Port { get; set; }

        public void AddAttachment(params string[] attachments)
        {
            Attachments = attachments;
        }

        public bool Send(string subject, string body, params string[] sendTo)
        {
            if(sendTo.Length == 0) return false;
            bool success = true;
            msg = new MailMessage();
            msg.From = new MailAddress(FromAddress, FromName);
            msg.Subject = subject;
            msg.Body = body;
            foreach (string s in Attachments)
            {
                msg.Attachments.Add(new Attachment(s));
            }

            foreach (string s in sendTo)
                msg.To.Add(s);
            client = new SmtpClient(Server, Port);
            client.Credentials = new NetworkCredential(FromAddress, Password);
            client.EnableSsl = true;
            AddAttachment();
            try
            {
                client.Send(msg);
            }
            catch
            {
                success = false;
            }
            finally
            {
                msg.Dispose();
            }
            return success;
        }
    }
}