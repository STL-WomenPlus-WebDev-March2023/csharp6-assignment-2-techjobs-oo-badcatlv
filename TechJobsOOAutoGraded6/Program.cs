
using TechJobsOOAutoGraded6;

RunTechJobs runNewTechJob = new RunTechJobs();
runNewTechJob.RunProgram();

Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
Console.WriteLine(job.ToString());
