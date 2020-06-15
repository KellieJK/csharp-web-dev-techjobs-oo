using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class PositionType : JobField

     {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        

        public PositionType(string value) : this()
        {
            Value = value;
        }

        // --------------done----------------
        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        // --------------done----------------


        public override bool Equals(object obj)
        {
            return obj is PositionType positionType &&
                   Id == positionType.Id;
        }


        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}
