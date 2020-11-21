using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_WeeklyChallenge
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void Main()     
        {
            Greeter g = new Greeter();
            g.HelloUser("Jill");
            g.GoodbyeUser("Jill");
            g.GoodDayUser("Jill");
        }
        
    }
}
