﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class Test
    {
        public void test()
        {
            Console.WriteLine("簡單工廠測試");

            PhoneInterface apple = PhoneFactory.GetPhone("apple");
            apple.Photo();
            apple.Music();

            PhoneInterface samsung = PhoneFactory.GetPhone("samsung");
            samsung.Photo();
            samsung.Music();
        }
    }
}
