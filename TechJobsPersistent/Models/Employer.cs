using System;
using System.Collections.Generic;

namespace TechJobsPersistent.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        // public List<Employer> employers { get; set; }           //TODO is this right, list of what

        public Employer(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public Employer()
        {
        }
    }
}
