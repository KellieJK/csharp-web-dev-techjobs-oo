using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http.Headers;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job1.Id != job2.Id);
        }


        
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testTwo = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(testTwo.Id == 1);
            Assert.IsTrue(testTwo.Name == "Product Tester");
            Assert.AreEqual(testTwo.EmployerName.Value, "ACME");
            Assert.AreEqual(testTwo.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testTwo.JobType.Value, "Quality control");
        }

        
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

        
        [TestMethod]
        public void TestingToString()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.ToString() == "\n\n");
        }

    }        
 }        

    


