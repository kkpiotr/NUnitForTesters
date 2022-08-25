using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class NumberServiceTests
    {
        NumberService numberService = new NumberService();

        [Test]
        public void IsItTheAnswerToUltimateQuestionOfLifeTest([Range(1, 100)] int i)
        {
            StringAssert.AreNotEqualIgnoringCase(numberService.IsItTheAnswerToUltimateQuestionOfLife(i), "That should not happen at all");
        }

    }
}
