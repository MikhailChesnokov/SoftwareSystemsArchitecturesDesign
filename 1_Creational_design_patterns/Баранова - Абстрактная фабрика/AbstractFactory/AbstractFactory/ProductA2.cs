﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ProductA2: IProductA
    {
        public void WriteNameAndType()
        {
            Console.WriteLine("Name: ProductA. Type: 2");
        }
    }
}
