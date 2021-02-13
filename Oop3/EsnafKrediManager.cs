using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı!");
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }
    }
}
