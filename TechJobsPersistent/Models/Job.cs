using System;
using System.Collections.Generic;

namespace TechJobsPersistent.Models
{
    public class Job
    {                                                           //same as EventTag class
        public int Id { get; set; }

        public string Name { get; set; }

        public Employer Employer { get; set; }

        public int EmployerId { get; set; }         //TODO is this right, revisit composite primary keys, then check Home Controller httppost again

        public List<JobSkill> JobSkills { get; set; }

        public Job()
        {
        }

        public Job(string name)
        {
            Name = name;



        }
    }
}
