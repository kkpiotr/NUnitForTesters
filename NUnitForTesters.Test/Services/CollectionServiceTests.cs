using NUnit.Framework;
using NUnitForTesters.Services;
using System.Collections.Generic;

namespace NUnitForTesters.Test.Services
{
    public class CollectionServiceTests
    {
        [Test]
        public void CollectionServiceTest()
        {
            CollectionService collectionService = new CollectionService();

            CollectionAssert.AllItemsAreUnique(collectionService.Names);
        }

        [Test]
        public void CollectionServiceTest2()
        {
            CollectionService collectionService = new CollectionService();

            Assert.Multiple (() => {
                CollectionAssert.IsNotEmpty(collectionService.Names);
                CollectionAssert.AllItemsAreNotNull(collectionService.Names);
            });
        }


        [Test]
        public void GetInitialsFromNames()
        {
            List<string> list = new List<string>() { "Piotr Kornobis", "Konrad Siwczynski", "Piotr Wywioł" };

            CollectionService collectionService = new CollectionService(list);

            List<string> wynik = collectionService.GetInitialsFromNames();

            Assert.Multiple(() =>
            {
                CollectionAssert.AreEquivalent(wynik, new List<string>() { "KS", "PW", "PK" });
                Assert.AreEqual(wynik.Count, list.Count);
            });
        


        }


        }
}
