using NUnit.Framework;
using NUnitForTesters.Parallel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitForTesters.Test.Parallel
{
    [Parallelizable(ParallelScope.Children)]
    public class HtmlTextFormatterTests
    {
        HtmlTextFormatter htmlTextFormatter = new HtmlTextFormatter();

        [TestCase ("Ala")]
        public void FormatAsBoldTest(string a)
        {
            StringAssert.AreEqualIgnoringCase(htmlTextFormatter.FormatAsBold(a), $"<b>{a}</b>");
        }

        [TestCase ("Kot")]
        public void FormatAsItalicTest(string a)
        {
            StringAssert.AreEqualIgnoringCase(htmlTextFormatter.FormatAsItalic(a), $"<i>{a}</i>");
        }

        [TestCase("Kot")]
        public void FormatAsSmallTest(string a)
        {
            StringAssert.AreEqualIgnoringCase(htmlTextFormatter.FormatAsSmall(a), $"<small>{a}</small>");
        }

        [TestCase("Kot")]
        public void FormatAsDeletedTest(string a)
        {
            StringAssert.AreEqualIgnoringCase(htmlTextFormatter.FormatAsDeleted(a), $"<del>{a}</del>");
        }
        [TestCase("Kot")]
        public void FormatAsSubScriptTest(string a)
        {
            StringAssert.AreEqualIgnoringCase(htmlTextFormatter.FormatAsSubscript(a), $"<sub>{a}</sub>");
        }

        [TestCase("Ala", "Kot")]
        public void FormatAsCustomTag(string a, string b)
        {
            StringAssert.AreEqualIgnoringCase(htmlTextFormatter.FormatAsCustomTag(a, b), $"<{b}>{a}</{b}>");
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(100);
        }
    }
}
