using SOLIDPrinciples.InterfaceSegregationPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DependencyInversionPrinciple
{
    public class NotificationService
    {
        private readonly IEmailSender _emailSender;
        private readonly IPrinter _printer;
        public NotificationService(IEmailSender emailSender, IPrinter printer)
        {
            _emailSender = emailSender;
            _printer = printer;
        }
        public void Notify(string recipient, string subject, string body)
        {
            _emailSender.SendEmail(recipient, subject, body);
            _printer.Print($"Notification sent to {recipient}: subject '{subject}' - body: '{body}'");
        }

        public void Notify(string message)
        {
            _printer.Print(message);
            _emailSender.SendEmail("someone@test.com", "Notification", message);

        }
    }
}
