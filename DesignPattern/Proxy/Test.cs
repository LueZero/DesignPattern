﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("代理模式測試");

            var orderProxy = new OrderProxy();

            orderProxy.Read("123456");
        }
    }
}
