using System;
using System.Diagnostics.CodeAnalysis;

namespace TechJobsOO
{
    public class Job : JobField
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

        /////////need help with this-----help help--------
      
        /// 
        /// 
      
        
        public override string ToString()
        {
            string result = "\n";
            result += $"ID: {Id}\n";
            if (string.IsNullOrEmpty(Name))
                result += $"Name: Data not available\n";
            else    
            result += $"Name: {Name}\n";
            result += $"Employer: {Employer.value}\n";
            result += $"Location: {Location.value}";
            result += $"Position Type: {PositionType.value} \n";
            result += $"Core Competency: {CoreCompetency.value}\n";
            result += "\n";
            return result;
        }


        //public override string ToString()
        //{
        //    string result = "\n";
        //    result += "\n";
        //    return result;
        //}



        /////////need help with this-----help help--------

        public override bool Equals(object obj)
        {
            return obj is Job jobs &&
                   Id == jobs.Id;
        }

     
    }
}
