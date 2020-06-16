using System;

namespace TechJobsOO
{
    public class Location : JobField
    {
       
        private static int nextId = 1;
       

        public Location()
        {
            Id = nextId;
            nextId++;
        }

        public Location(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }
    }
}
