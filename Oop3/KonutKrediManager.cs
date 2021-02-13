using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı!");
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }
    }
}
