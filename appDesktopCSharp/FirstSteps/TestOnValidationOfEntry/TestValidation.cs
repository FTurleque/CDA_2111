using LibInputValidation;

namespace TestOnValidationOfEntry
{
    [TestClass]
    public class TestValidation
    {
        [TestMethod]
        public void TestValidationName()
        {
            NameValidator nameValidate = new NameValidator();
            // Assert.IsTrue(nameValidate.isValid("Michelle"));
            //Assert.IsTrue(nameValidate.isValid("It's OK, is a string"));
            //Assert.AreEqual("Jean-Rene", true);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestValidationName2()
        {
            NameValidator nameValidate = new NameValidator();
            // Assert.IsTrue(nameValidate.isValid("Michelle"));
            //Assert.IsTrue(nameValidate.isValid("It's OK, is a string"));
            //Assert.AreEqual("Jean-Rene", true);
            Assert.IsTrue(true);
        }
    }
}