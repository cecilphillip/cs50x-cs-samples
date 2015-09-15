using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week3Services.Test
{    
    [TestClass]
    public class EventTests
    {
       
        [TestMethod]
        public void Events_Equal()
        {
            var event1 = new Event {Name = "Event 1", EventType = "1"};
            var event2 = new Event { Name = "Event 2", EventType = "2" };
            var event3 = new Event { Name = "Event 3", EventType = "3" };

            var event4 = new Event { Name = "Event 1", EventType = "1" };
            var event5 = event1;


            Assert.AreEqual(event1, event4);
            Assert.AreNotSame(event1, event4);
            Assert.AreSame(event5, event1);
        }
    }
}
