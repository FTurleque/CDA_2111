using TrouveEmploi.Lib.Class;
using TrouveEmploi.Lib.Extensions;
using TrouveEmploi.Lib.Validation;

namespace TrouveEmploi.Tests
{
    [TestClass]
    public class JobSeekerViewModelTest
    {
        private NameValidator nameValidator = new NameValidator();
        private SentenceValidator sentenceValidator = new SentenceValidator();
        private YearValidator yearValidator = new YearValidator();
        private JobSeekerViewModel jValid = new JobSeekerViewModel()
        {
            Name = "Toto",
            FirstName = "Jean-Louis",
            RegistrationYear = 2021,
            Level = Levels.BacPlus2,
            Diploma = new Diploma("Concepteur Développeur d'Application", "2020")
        };
        private JobSeekerViewModel jInvalid = new JobSeekerViewModel()
        {
            Name = "123654",
            FirstName = "1234654",
            RegistrationYear = 9999,
            Diploma = new Diploma("654 5464", "9999")
        };

        [TestMethod]
        public void Test_Id()
        {
            JobSeeker j1 = new JobSeeker();
            JobSeeker j2 = new JobSeeker();
            Assert.AreEqual(5, j1.Id);
            Assert.AreEqual(6, j2.Id);
        }

        [TestMethod]
        public void Test_Copy()
        {
            JobSeeker j2 = new JobSeeker(jValid);

            Assert.AreEqual(jValid.Name, j2.Name);
            Assert.AreEqual(jValid.FirstName, j2.FirstName);
            Assert.AreEqual(jValid.RegistrationYear, j2.RegistrationYear);
            Assert.AreEqual(jValid.Level, j2.Level);
            Assert.AreEqual(jValid.Diploma, j2.Diploma);
            Assert.AreEqual(jValid.Id, j2.Id);
            Assert.AreEqual(j2.Id, jValid.Id);
        }

        [TestMethod]
        public void Test_InvalidNames()
        {
            Assert.IsFalse(nameValidator.IsValid("Meme-"));
            Assert.IsFalse(nameValidator.IsValid("Meme-ldjflkj:!"));
            Assert.IsFalse(nameValidator.IsValid(jInvalid.Name));
            Assert.IsFalse(nameValidator.IsValid(jInvalid.FirstName));
            Assert.IsFalse(sentenceValidator.IsValid(jInvalid.Diploma.LastDiplomaName));
        }

        [TestMethod]
        public void Test_ValidNames()
        {
            Assert.IsTrue(nameValidator.IsValid("Jean-Michel"));
            Assert.IsTrue(nameValidator.IsValid("Anaïs"));
            Assert.IsTrue(nameValidator.IsValid("Théo"));
            Assert.IsTrue(nameValidator.IsValid(jValid.Name));
            Assert.IsTrue(nameValidator.IsValid(jValid.FirstName));
            Assert.IsTrue(sentenceValidator.IsValid(jValid.Diploma.LastDiplomaName));
        }

        [TestMethod]
        public void Test_InvalidDates()
        {
            Assert.IsFalse(yearValidator.IsValid("azerty"));
            Assert.IsFalse(yearValidator.IsValid(",;:"));
            Assert.IsFalse(yearValidator.IsNotInFuture(1999855));
            Assert.IsFalse(yearValidator.IsNotInFuture((DateTime.Now.Year + 1)));
            Assert.IsFalse(yearValidator.IsNotInFuture(9999));
            Assert.IsFalse(yearValidator.IsNotInFuture(jInvalid.RegistrationYear));
            Assert.IsFalse(yearValidator.IsNotInFuture(int.Parse(jInvalid.Diploma.LastDiplomaYear)));
        }

        [TestMethod]
        public void Test_ValidDates()
        {
            Assert.IsTrue(yearValidator.IsValid("1999"));
            Assert.IsTrue(yearValidator.IsValid(DateTime.Now.Year.ToString()));
            Assert.IsTrue(yearValidator.IsValid(jValid.RegistrationYear.ToString()));
            Assert.IsTrue(yearValidator.IsValid(jValid.Diploma.LastDiplomaYear.ToString()));
        }
    }
}