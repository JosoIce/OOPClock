using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPClock;

namespace ClockUnitTests
{
    [TestClass]
    public class ClockTest
    {
        [TestMethod]
        public void DoesTickSec()
        {
            Clock clock = new Clock();

            clock.Tick();

            Assert.AreEqual("00:00:01", clock.OutputTime);
        }

        [TestMethod]
        public void DoesTickMin()
        {
            Clock clock = new Clock();

            for (int i = 0; i < 60; i++)
            {
                clock.Tick();
            }

            Assert.AreEqual("00:01:00", clock.OutputTime);
        }

        [TestMethod]
        public void DoesTickHour()
        {
            Clock clock = new Clock();

            for (int i = 0; i < 3600; i++)
            {
                clock.Tick();
            }

            Assert.AreEqual("01:00:00", clock.OutputTime);
        }

        [TestMethod]
        public void DoesReset()
        {
            Clock clock = new Clock();

            clock.Tick();
            clock.Tick();
            clock.Tick();

            clock.ResetClock();

            Assert.AreEqual("00:00:00", clock.OutputTime);
        }
    }
}
