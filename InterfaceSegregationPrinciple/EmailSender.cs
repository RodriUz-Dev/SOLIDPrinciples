using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregationPrinciple
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            // Logic to send email
            Console.WriteLine($"Email sent to {recipient}: subject '{subject}' - body: '{body}'");
        }
    }   
    
}
