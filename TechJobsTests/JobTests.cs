using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;
namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        // test the Empty Constructor
        [TestMethod]
        public void TestSettingJobId()
        {
             Job job1 = new Job();
             Job job2 = new Job();
            // Assert.AreEqual(job1.Id, job2.Id, 1 );
            // Assert.IsTrue(job1.Id < job2.Id);
            Assert.IsFalse(job1.Id == job2.Id);
        }

        // test Full Constructor
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job.Name == "Product tester" && job.EmployerName.Value == "ACME"
                && job.EmployerLocation.Value == "Desert" && job.JobType.Value == "Quality control" 
                && job.JobCoreCompetency.Value == "Persistence");
            
        }

        // Test the Equals() Method
        [TestMethod]
        public void TestJobForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
               new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
               new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Id == job2.Id);
        }

        //Test for ToString()
        [TestMethod]
        public void TestToString()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                      new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobInfo = $"\nID: {job.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert" +
                             $"\nPosition Type: Quality control\nCore Competency: Persistence";

            Assert.IsTrue(job.ToString() == jobInfo);

        }


    }
}
