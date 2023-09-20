namespace TechJobsOOAutoGraded6
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1; //static therefore the changing value is NOT store in any Employer object
        public string Value { get; set; }

        public Employer()
        {
            Id = nextId;
            nextId++;
        }

        public Employer(string value) : this()  //CONSTRUCTOR CHAINING 
                                                //assigns the value field. It ALSO initializes id for the object
                                                //by calling the first constructor statement with the :this()
                                                //Including :this() in any Employer constructor makes initializing id a default behavior.
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

