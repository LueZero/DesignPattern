using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("裝飾模式測試");

            // 我買了個蘋果手機
            Apple phone = new Apple();

            // 現在想貼膜了
            Decorator applePhoneWithSticker = new Sticker(phone);
            // 擴充套件貼膜行為
            applePhoneWithSticker.Print();
            Console.WriteLine("----------------------\n");

            // 現在我想有掛件了
            Decorator applePhoneWithAccessories = new Accessories(phone);
            // 擴充套件手機掛件行為
            applePhoneWithAccessories.Print();
            Console.WriteLine("----------------------\n");

            // 現在我同時有貼膜和手機掛件了
            Sticker sticker = new Sticker(phone);
            Accessories applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
            applePhoneWithAccessoriesAndSticker.Print();

            //抽象構件（Phone）角色：給出一個抽象介面，以規範準備接受附加責任的物件。
            //具體構件（AppPhone）角色：定義一個將要接收附加責任的類。
            //裝飾（Dicorator）角色：持有一個構件（Component）物件的例項，並定義一個與抽象構件介面一致的介面。
            //具體裝飾（Sticker和Accessories）角色：負責給構件物件 ”貼上“附加的責任。
            //參考:https://dotblogs.com.tw/daniel/2018/04/09/102242
        }
    }
}
