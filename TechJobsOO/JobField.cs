using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public abstract class JobField
    {

        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

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