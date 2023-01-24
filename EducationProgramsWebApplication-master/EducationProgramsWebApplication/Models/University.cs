using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class University
    {
        public University()
        {
            Faculties = new HashSet<Faculty>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Edbo { get; set; } = null!;

        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
