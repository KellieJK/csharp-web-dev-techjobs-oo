using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

       
        public Job(string name, string employerName, string employerLocation, string jobType, string jobCoreCompetency)
            {
                Name = Name;
                Employer = employerName;
                Location = employerLocation;
                PositionType = jobType;
                CoreCompetency = jobCoreCompetency;

            }

        public ID(string id)

        public Job()
            : this(Name, employerName, employerLocation, jobType, jobCoreCompetency) { }

    }


        //--------------------done----------------------------
        // TODO: Generate Equals() and GetHashCode() methods.
        //--------------------done----------------------------


        public override bool Equals(object obj)
        {
            return obj is Job jobs &&
                   Id == jobs.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }

    }
}
