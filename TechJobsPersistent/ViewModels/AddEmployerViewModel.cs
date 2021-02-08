using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        // TODO add constructors? check part 2 adding employers, controllers #4

        //public AddEmployerViewModel(name, employer) {
        //    Name = name;
        //    Location = Location;
        //}

        public AddEmployerViewModel() { }
    }
}
