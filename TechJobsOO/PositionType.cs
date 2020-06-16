using System;

namespace TechJobsOO
{
    public class PositionType : JobField
     {
        private static int nextId = 1;
    
        public PositionType()
        {
            Id = nextId;
            nextId++;
        }
                

        public PositionType(string value) : this()
        {
            Value = value;
        }

       

        public override bool Equals(object obj)
        {
            return obj is PositionType positionType &&
                   Id == positionType.Id;
        }
    }
}
