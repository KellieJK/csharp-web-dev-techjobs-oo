﻿using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

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
