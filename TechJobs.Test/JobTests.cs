
using System.Data;
using System.Xml.Linq;

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
        public void TestSettingJobId()
        {
            Assert.IsTrue(job_1.Id < job_2.Id);
            Assert.IsTrue(job_2.Id - job_1.Id == 1);
            //Assert.AreEqual(1, job_1.Id);
            //Assert.AreEqual(2, job_2.Id);
            Assert.IsFalse(job_1 == job_2);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job_4.Name.ToString());
            Assert.AreEqual("ACME", job_4.EmployerName.ToString());
            Assert.AreEqual("Desert", job_4.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job_4.JobType.ToString());
            Assert.AreEqual("Persistence", job_4.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job_1.Equals(job_2));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job_3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job_3.ToString().EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job_3.ToString().Contains($"ID: {job_3.Id}"));
            Assert.IsTrue(job_3.ToString().Contains($"Name: {job_3.Name}"));
            Assert.IsTrue(job_3.ToString().Contains($"Employer: {job_3.EmployerName}"));
            Assert.IsTrue(job_3.ToString().Contains($"Location: {job_3.EmployerLocation}"));
            Assert.IsTrue(job_3.ToString().Contains($"Position Type: {job_3.JobType}"));
            Assert.IsTrue(job_3.ToString().Contains($"Core Competency: {job_3.JobCoreCompetency}"));
            Assert.AreEqual(job_3.ToString(), $"{Environment.NewLine}ID: {job_3.Id}\nName: {job_3.Name}\nEmployer: {job_3.EmployerName}\nLocation: {job_3.EmployerLocation}\nPosition Type: {job_3.JobType}\nCore Competency: {job_3.JobCoreCompetency}{Environment.NewLine}");


        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual(job_1.ToString(), $"{Environment.NewLine}ID: {job_1.Id}\nName: {job_1.Name}\nEmployer: {job_1.EmployerName}\nLocation: {job_1.EmployerLocation}\nPosition Type: {job_1.JobType}\nCore Competency: {job_1.JobCoreCompetency}{Environment.NewLine}");
            
        }
    }
}

