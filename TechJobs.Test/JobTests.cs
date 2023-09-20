
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        Job job_1;
        Job job_2;
        Job job_3;
        Job job_4;
        [TestInitialize]
        public void CreateJobObject()
        {
            job_1 = new Job();
            job_2 = new Job();
            job_3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job_4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }
            //Testing Objects
        //initialize your testing objects here

        [TestMethod]
        public void TestSettingJobID()
        {
            Assert.AreEqual(1, job_1.Id, 0.001);
            Assert.AreEqual(2, job_2.Id, 0.001);
            Assert.IsFalse(job_1 == job_2);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

        }
    }
}

