﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Ssd : Component
    {
        public Ssd(int price) :
            base("Ssd", price) { }
    }
}
