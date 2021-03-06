﻿using System;
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

        public override string ToString()
        {
            string result = "\n";
            result += $"ID: {Id}\n";
            if (Name.ToString() == "")
                result += $"Name: Data not available\n";
            else
                result += $"Name: {Name}\n";
            if
                (EmployerName.ToString() == "")
                result += $"Employer: Data not available\n";
            else
                result += $"Employer: {EmployerName}\n";
            if
                (EmployerLocation.ToString() == "")
                result += $"Location: Data not available\n";
            else
                result += $"Location: {EmployerLocation}\n";
            if
                (JobType.ToString() == "")
                result += $"JobType: Data not available\n";
            else
                result += $"Position Type: {JobType} \n";
            if
               (JobCoreCompetency.ToString() == null)
                result += $"Core Competency: Data not available\n";
            else
                result += $"Core Competency: {JobCoreCompetency}\n";
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
       
    }
}
