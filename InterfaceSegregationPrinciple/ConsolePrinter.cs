using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregationPrinciple
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string content) => Console.WriteLine(content);

    }
        
}
