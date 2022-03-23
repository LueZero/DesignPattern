﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class ApplePhone : ProductInterface
    {
        public string GetBrand()
        {
            return "Apple";
        }
    }
}