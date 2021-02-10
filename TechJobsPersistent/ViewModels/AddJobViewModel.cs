using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;


namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel                    // Remember: this is for the form, refer to the Job.cs Model
    {
        [Required(ErrorMessage = "Employer name is required.")]
        public int EmployerId { get; set; }             // ?  selected employer's id, will be hidden in the form?

        [Required(ErrorMessage = "Job name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }            // job name

     
        //public Employer Employer { get; set; }

        public List<SelectListItem> Employers { get; set; }

        //Skills, job skill or skill?
        public List<Skill> Skills { get; set; }
        
        
       
        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            //Skills = new List<Skill>();
            Skills = skills;

            foreach (var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),         
                    Text = employer.Name
                });
            }

            //foreach (var skill in skills)
            //{
            //    Skills.Add(new Skill
            //    {
            //        Name = skill.Name,
            //        Description = skill.Description
            //    });
            //}
        }

        public AddJobViewModel()
        {
        }

    }
}
