using TrouveEmploi.Lib;
using TrouveEmploi.Lib.Validation;

namespace TrouveEmploi.Tests
{
    [TestClass]
    public class JobSeekerViewModelTest
    {
        [TestMethod]
        public void Test_Id()
        {
            JobSeeker j1 = new JobSeeker();
            JobSeeker j2 = new JobSeeker();
            Assert.AreEqual(1, j1.Id);
            Assert.AreEqual(2, j2.Id);
        }

        [TestMethod]
        public void Test_Copy()
        {
            Diploma diploma = new Diploma("Tata Yoyo", 2020);
            JobSeekerViewModel j1 = new JobSeekerViewModel()
            {
                Name = "Toto",
                FirstName = "Jean-Louis",
                RegistrationYear = 2021,
                Level = Levels.BacPlus2,
                Diploma = diploma
            };
            JobSeeker j2 = new JobSeeker(j1);

            Assert.AreEqual(j1.Name, j2.Name);
            Assert.AreEqual(j1.FirstName, j2.FirstName);
            Assert.AreEqual(j1.RegistrationYear, j2.RegistrationYear);
            Assert.AreEqual(j1.Level, j2.Level);
            Assert.AreEqual(j1.Diploma, j2.Diploma);
            Assert.AreEqual(j1.Id, j2.Id);
            Assert.AreEqual(j2.Id, j1.Id);
        }

        [TestMethod]
        public void Test_ValidationNames()
        {
            Diploma d = new Diploma("654 5464", 9999);
            JobSeekerViewModel j1 = new JobSeekerViewModel()
            {
                Name = "123654",
                FirstName = "1234654",
                RegistrationYear = 9999,
                Diploma = d
            };
            Assert.IsFalse(j1.Validation_Name());
            Assert.IsFalse(j1.ValidationFirstName());
            Assert.IsFalse(j1.ValidationDiplomaYear_Date()); 
            Assert.IsFalse(j1.ValidationRegistrationYear_Date()); 
            Assert.IsFalse(j1.Validation_LastDiplomaName());
            Assert.IsFalse(j1.Validation_LastDiplomaName());
        }
    }
}