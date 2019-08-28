using Microsoft.VisualStudio.TestTools.UnitTesting;
using numberToRoman;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() 
        {
            programget pg = new programget();
       
            Assert.IsTrue(pg.getNumberToRoman(1) == "I");
            Assert.IsTrue(pg.getNumberToRoman(2) == "II");
            Assert.IsTrue(pg.getNumberToRoman(3) == "III");
            Assert.IsTrue(pg.getNumberToRoman(4) == "IV");
            Assert.IsTrue(pg.getNumberToRoman(5) == "V");
            Assert.IsTrue(pg.getNumberToRoman(6) == "VI");
            Assert.IsTrue(pg.getNumberToRoman(7) == "VII");
            Assert.IsTrue(pg.getNumberToRoman(8) == "VIII");
            Assert.IsTrue(pg.getNumberToRoman(9) == "IX");
            Assert.IsTrue(pg.getNumberToRoman(10) == "X");
            Assert.IsTrue(pg.getNumberToRoman(11) == "XI");
            Assert.IsTrue(pg.getNumberToRoman(12) == "XII");
            Assert.IsTrue(pg.getNumberToRoman(13) == "XIII");
            Assert.IsTrue(pg.getNumberToRoman(14) == "XIV");
            Assert.IsTrue(pg.getNumberToRoman(15) == "XV");
            Assert.IsTrue(pg.getNumberToRoman(16) == "XVI");
            Assert.IsTrue(pg.getNumberToRoman(17) == "XVII");
            Assert.IsTrue(pg.getNumberToRoman(18) == "XVIII");
            Assert.IsTrue(pg.getNumberToRoman(19) == "XIX");
            Assert.IsTrue(pg.getNumberToRoman(20) == "XX");

        }
    }

}
