using System;

namespace Oop3
{
    class FileLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı!");
        }
    }
}
