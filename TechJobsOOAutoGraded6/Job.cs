namespace TechJobsOOAutoGraded6
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; } = "Data not available";
        public Employer EmployerName { get; set; } = new Employer("Data not available");
        public Location EmployerLocation { get; set; } = new Location("Data not available");
        public PositionType JobType { get; set; } = new PositionType("Data not available");
        public CoreCompetency JobCoreCompetency { get; set; } = new CoreCompetency("Data not available");

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            if (Name == null) { Name = "Data not available"; }

            //string NoData = "Data not available";
            return $"{Environment.NewLine}Id: {Id}\nName: {Name}\nEmployer: {EmployerName}\nLocation: {EmployerLocation}\nPosition Type: {JobType}\nCore Competency: {JobCoreCompetency}{Environment.NewLine}";
        }


    }
}

