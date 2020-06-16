using System;

namespace TechJobsOO
{
    public class CoreCompetency : JobField
    { 
        private static int nextId = 1;

        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency coreCompetency &&
                   Id == coreCompetency.Id;
        }

    }
    
}
