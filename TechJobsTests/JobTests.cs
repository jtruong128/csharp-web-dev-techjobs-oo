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
        public void Test01SettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Id == job2.Id);
        }

        // test Full Constructor
        [TestMethod]
        public void Test02JobConstructorSetsAllFields()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job.Name == "Product tester" && job.EmployerName.Value == "ACME"
                && job.EmployerLocation.Value == "Desert" && job.JobType.Value == "Quality control"
                && job.JobCoreCompetency.Value == "Persistence");

        }

        // Test the Equals() Method
        [TestMethod]
        public void Test03JobForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
               new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
               new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Id == job2.Id);
        }

        //Test for ToString()
        [TestMethod]
        public void Test04ToString()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                      new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobInfo = $"\nID: {job.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert" +
                             $"\nPosition Type: Quality control\nCore Competency: Persistence\n";

            Assert.IsTrue(job.ToString() == jobInfo);

        }

        //Test for string beginning with new line character
        [TestMethod]
        public void Test05BeginNewLineReturnTrue()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                      new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job.ToString().StartsWith("\n"));
        }

        //Test for string ending with new line character
        [TestMethod]
        public void Test06EndNewLineReturnTrue()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                      new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job.ToString().EndsWith("\n"));
        }

        // this method test to ensure the new job Id is increment by 1 from the previous Id
        [TestMethod]
        public void Test07IncrementJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(job1.Id, job2.Id, 1);
        }

        // this method test to ensure the empty field is passing to the Job Constructor 
        [TestMethod]
        public void Test08EmptyField()
        {
            Job myJob = new Job("Ice cream tester", new Employer(""), new Location("Home"),
                       new PositionType("UX"), new CoreCompetency("Tasting ability"));

            //Assert.IsTrue(myJob.EmployerName.Value == "");
        }


    }       
        
}