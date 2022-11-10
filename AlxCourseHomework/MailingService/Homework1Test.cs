using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService
{
    public class Homework1Test
    {
        public static void Run()
        {
            var email1 = new Email("emailfrom1@o2.pl", "email1to@o2.pl", "topicEmail1", "contentEmail1");
            var email2 = new Email("emailfrom2@o2.pl", "email2to@o2.pl", "topicEmail2", "contentEmail2");
            var email3 = new Email(null, "email3to@o2.pl", "topicEmail3", "contentEmail3");
            var email4 = new Email("emailfrom4@o2.pl", "email4to@o2.pl", "topicEmail4", null);
            var email5 = new Email("emailfrom5@o2.pl", "email5to@o2.pl", null, "contentEmail5");

            var mailingService = new EmailService();

            mailingService.SendEmail(email1);
            mailingService.SendEmail(email2);
            mailingService.SendEmail(email3);
            mailingService.SendEmail(email4);
            mailingService.SendEmail(email5);
        }
    }
}
