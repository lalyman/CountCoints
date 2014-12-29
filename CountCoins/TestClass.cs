using NUnit.Framework;

namespace CountCoins
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void ChangeForLessThanANickle()
        {
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(1, ChangeMaker.ImportantCoins), Is.EqualTo(1));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(2, ChangeMaker.ImportantCoins), Is.EqualTo(1));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(3, ChangeMaker.ImportantCoins), Is.EqualTo(1));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(4, ChangeMaker.ImportantCoins), Is.EqualTo(1));
        }

        [Test]
        public void ChangeForLessThanADimeMoreThanANickle()
        {
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(5, ChangeMaker.ImportantCoins), Is.EqualTo(2)); 
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(6, ChangeMaker.ImportantCoins), Is.EqualTo(2));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(7, ChangeMaker.ImportantCoins), Is.EqualTo(2));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(8, ChangeMaker.ImportantCoins), Is.EqualTo(2));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(9, ChangeMaker.ImportantCoins), Is.EqualTo(2));
        }

        [Test]
        public void ChangeForGreaterThanOrEqualTo10LessThan15()
        {
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(10, ChangeMaker.ImportantCoins), Is.EqualTo(4));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(11, ChangeMaker.ImportantCoins), Is.EqualTo(4));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(12, ChangeMaker.ImportantCoins), Is.EqualTo(4));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(13, ChangeMaker.ImportantCoins), Is.EqualTo(4));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(14, ChangeMaker.ImportantCoins), Is.EqualTo(4));
        }

        [Test]
        public void ChangeFor15Through19Cents()
        {
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(15, ChangeMaker.ImportantCoins), Is.EqualTo(6));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(16, ChangeMaker.ImportantCoins), Is.EqualTo(6));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(17, ChangeMaker.ImportantCoins), Is.EqualTo(6));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(18, ChangeMaker.ImportantCoins), Is.EqualTo(6));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(19, ChangeMaker.ImportantCoins), Is.EqualTo(6));
        }

        [Test]
        public void ChangeFor20And25Thru29()
        {
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(20, ChangeMaker.ImportantCoins), Is.EqualTo(9));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(25, ChangeMaker.ImportantCoins), Is.EqualTo(13));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(26, ChangeMaker.ImportantCoins), Is.EqualTo(13));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(27, ChangeMaker.ImportantCoins), Is.EqualTo(13));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(28, ChangeMaker.ImportantCoins), Is.EqualTo(13));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(29, ChangeMaker.ImportantCoins), Is.EqualTo(13));
        }

        [Test]
        public void LargeNumbers()
        {
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(30, ChangeMaker.ImportantCoins), Is.EqualTo(18));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(43, ChangeMaker.ImportantCoins), Is.EqualTo(31));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(50, ChangeMaker.ImportantCoins), Is.EqualTo(49));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(56, ChangeMaker.ImportantCoins), Is.EqualTo(60));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(97, ChangeMaker.ImportantCoins), Is.EqualTo(213));
            Assert.That(ChangeMaker.NumberOfWaysToMakeChange(100, ChangeMaker.ImportantCoins), Is.EqualTo(242));
        }
    }
}
