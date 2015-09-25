using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week3Services.Test
{
    [TestClass]
    public class EventServiceTest
    {
        [TestMethod]
        public void GetEvents_Returns_A_List_Of_Events()
        {
            var service = new EventService();
            var events = service.GetEvents();

            Assert.IsNotNull(events);
            
        }

        [TestMethod]
        public void GetEvents_Returns_A_Non_Empty_List()
        {
            var service = new EventService();
            var events = service.GetEvents();

            var numberOfEvents = events.Count();
            Assert.AreNotEqual(0, numberOfEvents);

        }

        [TestMethod]
        public void GetEvents_Contains_Event1()
        {
            var service = new EventService();
            var events = service.GetEvents();
            var someEvent = new Event()
            {
                Name = "Event 1",
                EventType = "1"
            };

            var result = events.Contains(someEvent);

           Assert.IsTrue(result);
        }
    }
}
