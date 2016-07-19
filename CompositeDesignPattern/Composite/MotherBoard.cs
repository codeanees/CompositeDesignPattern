using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class MotherBoard : CompositeComponent
    {
        public MotherBoard(int price):base("MotherBoard", price)
        {

        }
    }
}
