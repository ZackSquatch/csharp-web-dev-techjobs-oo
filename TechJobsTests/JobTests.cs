using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job = new Job("Product Tester", new Employer ("ACME"), new Location ("Desert"), new PositionType ("Quality Control"), new CoreCompetency ("Persistence"));

            Assert.AreEqual(job.Name, "Product Tester");
            Assert.AreEqual(job.EmployerName.Value, "ACME");
            Assert.AreEqual(job.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job.JobType.Value, "Quality Control");
            Assert.AreEqual(job.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void ToStringTest()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job.ToString().StartsWith("\n"));
            Assert.IsTrue(job.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void EmptyDataTest()
        {
            Job job = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string jobData = $"\n ID: {job.Id} \n Name: Data not available. \n Employer: Data not available. \n Location: Data not available. \n Position Type: Data not available. \n Core Competency: Data not available. \n";

            Assert.AreEqual(jobData, job.ToString());
        }
    }
}