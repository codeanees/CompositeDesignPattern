using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompositeDesignPattern.Test
{
    [TestClass]
    public class CompositeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var computer = new Computer(); //Composite
                 var motherboard = new MotherBoard(125); //Composite
                   var cpu = new Cpu(250); //Leaf: Doesn't have container
                   var ram = new Ram(160); //Leaf: Doesn't have container
                 var drive = new Ssd(250); //Leaf: Doesn't have container

            motherboard.Add(cpu);
            motherboard.Add(ram);

            computer.Add(motherboard);
            computer.Add(drive);

            Assert.AreEqual(computer.Price, 785);
        }
    }
}   
