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
            bool result = nameValidate.isValid("It");
            Assert.IsTrue(nameValidate.isValid("Michelle"));
            Assert.IsTrue(nameValidate.isValid("Jean-Rene"));
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInvalidName()
        {
            NameValidator nameValidate = new NameValidator();
            bool result = nameValidate.isValid("123");
            Assert.IsFalse(nameValidate.isValid("It's OK, is a string"));
            Assert.IsFalse(nameValidate.isValid("Michelle-"));
            Assert.AreEqual(false, result);
            Assert.IsFalse(nameValidate.isValid(" "));
            Assert.IsFalse(nameValidate.isValid("-"));
            Assert.IsFalse(nameValidate.isValid("Denis#45"));
        }

        [TestMethod]
        public void TestValidationFormatDate()
        {
            DateValidator dateValidate = new DateValidator();
            Assert.IsTrue(dateValidate.isValid("31.10.2222"));
            Assert.IsTrue(dateValidate.isValid("31/10/2222"));
            Assert.IsTrue(dateValidate.isValid("31-10-2222"));
            Assert.IsTrue(dateValidate.isValid("2222-10-31"));
            Assert.IsTrue(dateValidate.isValid("2222/10/31"));
            Assert.IsTrue(dateValidate.isValid("2222.10.31"));
        }

        [TestMethod]
        public void testInvalidFormatDate()
        {
            DateValidator dateValidate = new DateValidator();
            Assert.IsFalse(dateValidate.isValid("Tatata"));
            Assert.IsFalse(dateValidate.isValid("2020202020"));
            Assert.IsFalse(dateValidate.isValid("ata#Tab"));
            Assert.IsFalse(dateValidate.isValid("20*20*2222"));
            Assert.IsFalse(dateValidate.isValid("20/20/2222"));
            Assert.IsFalse(dateValidate.isValid("2020/2/20"));
        }

        [TestMethod]
        public void TestValidationDateFuture()
        {
            DateValidator dateValidate = new DateValidator();
            bool result = dateValidate.isValid(DateTime.Now.AddDays(1).ToString());
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestInvalidDateFuture()
        {
            DateValidator dateValidate = new DateValidator();
            Assert.IsFalse(dateValidate.isValid("20/09/1981"));
        }
    }
}