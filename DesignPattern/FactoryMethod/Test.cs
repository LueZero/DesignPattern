using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class Test
    {
        public void Tests()
        {
            Console.WriteLine("工廠方法模式測試");

            var modelFactory = CreateProductFactory("Apple");

            var product = modelFactory.CreateProduct();

            product.Wholesale();
        }

        private ProductFactory CreateProductFactory(string brand)
        {
            ProductFactory model = null;

            switch(brand)
            {
                case "Apple":
                    model = new AppleFactory();
                    break;
                case "Samsung":
                    model =  new SamsungFactory();
                    break;
                case "Beats":
                    model = new BeatsFactory();
                    break;
            }

            return model;
        }
    }
}
