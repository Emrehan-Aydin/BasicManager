﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı!");
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }
    }
}