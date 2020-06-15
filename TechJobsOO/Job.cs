using System;
using System.Diagnostics.CodeAnalysis;

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


        //--------------------done----------------------------
        // TODO: Generate Equals() and GetHashCode() methods.
        //--------------------done----------------------------


        //public override string ToString()
        //{ 
        //string result = "\n";
        //result += $"ID: {Id}\n";
        //if (string.IsNullOrEmpty(Name))            
        //    result += $"Name: Data not available\n";            
        //else            
        //result += $"Name: {Name}\n";            
        //result += $"Employer: {Employer.Value.ToString() "Data not available"}";
        //result += $"Location: {Location.Value.ToString("Data not available")}\n";
        //result += $"Position Type: {PositionType?.ToString() ?? "Data not available"}\n";
        //result += $"Core Competency: {CoreCompetency?.ToString() ?? "Data not available"}\n";
        //result += "\n";
        //return result; 
        //}


        public override string ToString()
        {
            string result = "\n";
            result += "\n";
            return result;
        }


        public override bool Equals(object obj)
        {
            return obj is Job jobs &&
                   Id == jobs.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public string ToString(string value)
        {
            return value;
        }

    }
}
