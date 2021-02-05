using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel                    // Remember: this is the form
    {
        public int Id { get; set; }             // ?  selected employer's id
        public string Name { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(List<> employers)
        {
            Employers = new List<SelectListItem>();
        }

        public AddJobViewModel()
        {

        }

    }
}
