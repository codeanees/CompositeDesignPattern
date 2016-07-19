using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Ram : Component
    {
        public Ram(int price) :
            base("Ram", price) { }
    }
}
