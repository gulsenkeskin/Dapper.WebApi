using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Services
{
    public class ConsoleLogger:ILoggerService
    {
        public void Write(string message)
        {
            Console.WriteLine("[Console Logger] - " + message);
        }
    }
}
