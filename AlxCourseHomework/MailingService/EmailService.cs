using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlxCourseHomework.MailingService
{
    public class EmailService
    {
        public void SendEmail(Email email)
        {
            if((email.From != null) && (email.To != null))
            {
                Console.WriteLine($"The email: {((email.Subject != null) ? email.Subject : "empty Subject")}, has been sent From:{email.From} To:{email.To}");
                Console.Write("The content of message is: " + ((email.Message != null) ? email.Message : "nothing...") + "\n");
            }
            else
            {
                Console.WriteLine("The email has not been sent. The destination OR sender address is null");
            }
        }
    }
}
