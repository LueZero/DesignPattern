using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("中介者模式測試");

            Apple apple = new Apple();
            Samsung samsung = new Samsung();
            new MessageMediator(apple, samsung);

            Console.WriteLine("Client triggers operation Samsung.");
            apple.Push();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation Apple.");
            samsung.Push();
        }
    }
}
