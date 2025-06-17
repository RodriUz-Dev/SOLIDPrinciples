using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregationPrinciple
{
    public interface IEmailSender
    {
        void SendEmail(string recipient, string subject, string body);
        
    }
}
