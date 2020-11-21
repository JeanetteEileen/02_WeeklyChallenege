using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WeeklyChallenge
{
    class Greeter
    {
        [TestMethod]
        public void HelloUser(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        [TestMethod]
        public void GoodbyeUser(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }
        [TestMethod]
        public void GoodDayUser(string name)
        {
            DateTime now = DateTime.Now;
            if (now.Hour < 12)
            {
                Console.WriteLine("Good Morning " + name);
            }
            else if (now.Hour > 12 && now.Hour < 16)
            {
                Console.WriteLine("Good Afternoon " + name);
            }
            else if (now.Hour > 16 && now.Hour < 20)
            {
                Console.WriteLine("Good Evening " + name);
            }
            else
            { 
                Console.WriteLine("Good Night " + name);
            }



          
        }
    }

}
