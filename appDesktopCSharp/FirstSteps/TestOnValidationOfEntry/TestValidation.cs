using LibInputValidation;

namespace TestOnValidationOfEntry
{
    [TestClass]
    public class TestValidation
    {
        /**
         * Unit test for validate a name.
         */
        [TestMethod]
        public void TestValidationName()
        {
            NameValidator nameValidate = new NameValidator();
            bool result = nameValidate.isValidName("It");
            Assert.IsTrue(nameValidate.isValidName("Michelle"));
            Assert.IsTrue(nameValidate.isValidName("Jean-Renes"));
            Assert.AreEqual(result, true);
        }

        /**
         * Unit test for invalid a name.
         */
        [TestMethod]
        public void TestInvalidName()
        {
            NameValidator nameValidate = new NameValidator();
            bool result = nameValidate.isValidName("123");
            Assert.IsFalse(nameValidate.isValidName("It's OK, is a string"));
            Assert.IsFalse(nameValidate.isValidName("Michelle-"));
            Assert.AreEqual(false, result);
            Assert.IsFalse(nameValidate.isValidName(" "));
            Assert.IsFalse(nameValidate.isValidName("-"));
            Assert.IsFalse(nameValidate.isValidName("Denis#45"));
        }

        /**
         * Unit test to validate the date format.
         */
        [TestMethod]
        public void TestValidationFormatDate()
        {
            DateValidator dateValidate = new DateValidator();
            Assert.IsTrue(dateValidate.IsValidDate("31.10.2222"));
            Assert.IsTrue(dateValidate.IsValidDate("31/10/2222"));
            Assert.IsTrue(dateValidate.IsValidDate("31-10-2222"));
            Assert.IsTrue(dateValidate.IsValidDate("2222-10-31"));
            Assert.IsTrue(dateValidate.IsValidDate("2222/10/31"));
            Assert.IsTrue(dateValidate.IsValidDate("2222.10.31"));
        }

        /**
         * Unit test to invalid the date format.
         */
        [TestMethod]
        public void TestInvalidFormatDate()
        {
            DateValidator dateValidate = new DateValidator();
            string[] stringsTest = new string[] 
                                        {   "Tatata", 
                                            "2020202020", 
                                            "ata#Tab",
                                            "20*20*2222",
                                            "20/20/2222",
                                            "2222/20/20",
                                            "2222*20*20"
                                        };
            foreach (string test in stringsTest)
            {
                try
                {
                    dateValidate.IsValidDate(test);
                    Assert.Fail("La date n'est pas formaté correctement ou ce n'est pas une date.");

                }
                catch (FormatException)
                {
                    Assert.IsTrue(true);
                }
            }
        }

        /**
         * Unit test for validate date, in the future.
         */
        [TestMethod]
        public void TestValidationDateFuture()
        {
            DateValidator dateValidate = new DateValidator();
            bool result = dateValidate.DateInTheFUture(DateTime.Now.AddDays(1).ToString());
            Assert.AreEqual(result, true);
        }

        /**
         * Unit test for invalid date, not in the future.
         */
        [TestMethod]
        public void TestInvalidDateFuture()
        {
            DateValidator dateValidate = new DateValidator();
            try
            {
                dateValidate.DateInTheFUture(DateTime.Now.ToString());
                Assert.Fail("Date dans le passé.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }

        /**
         * Unit test for validate a double.
         */
        [TestMethod]
        public void TestValidationDouble()
        {
            DoubleValidator doubleValidate = new DoubleValidator();
            Assert.IsTrue(doubleValidate.IsValidDouble("10.20"));
            Assert.IsTrue(doubleValidate.IsValidDouble("10,22"));
            Assert.IsTrue(doubleValidate.IsValidDouble("20"));
        }

        [TestMethod]
        public void TestInvalidDouble()
        {
            DoubleValidator doubleValidate = new DoubleValidator();
            string[] stringsTest = new string[] { "Blabla", "10.654", "10,654", " " };
            foreach (string test in stringsTest)
            {
                try
                {
                    doubleValidate.IsValidDouble(test);
                    Assert.Fail("Ne doit comporter que des chiffres 2 chiffres après la virgule max.");
                }
                catch (Exception)
                {
                    Assert.IsTrue(true);
                }
            }
        }

        public void TestValidationZipCode()
        {

        }

        public void TestInvalidZipCode()
        {

        }
    }
}