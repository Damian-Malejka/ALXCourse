using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService
{
    public class Email
    {
        public string From;
        public string To;
        public string Subject;
        public string Message;

        public Email(string from, string to, string subject, string message)
        {
            From= from;
            To = to;
            Subject = subject;
            Message = message;
        }
    }
}
