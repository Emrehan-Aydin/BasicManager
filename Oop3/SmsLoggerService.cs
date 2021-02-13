using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class SmsLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Sms gönderildi!");
        }
    }
}
