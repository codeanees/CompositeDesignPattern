using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Cpu : Component
    {
        public Cpu(int price): 
            base("Cpu", price) {  }
    }
}
