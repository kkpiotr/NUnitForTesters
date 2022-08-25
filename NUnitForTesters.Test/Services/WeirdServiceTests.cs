using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitForTesters.Services;
using System.Threading;

namespace NUnitForTesters.Test.Services
{
    public class WeirdServiceTests
    {
        WeirdService weirdService = new WeirdService();

        [Test, Timeout(2000)]
        public void ThisMethodWillTimeoutTest()
        {
            StringAssert.AreEqualIgnoringCase(WeirdService.ThisMethodWillTimeout(), "This method should timeout");
        }

        [Test]
        public void ThisMethodWillThrowExceptionIfParameterIsZeroTest()
        {
            Assert.Throws<ArgumentException>(() => WeirdService.ThisMethodWillThrowExceptionIfParameterIsZero(0));
        }

        [Test, Retry(5)]
        public void ThisMethodWillPassSometimesTest()
        {
            Assert.That(WeirdService.ThisMethodWillPassSometimes(), Is.LessThan(1000));
        }
    }
 }
