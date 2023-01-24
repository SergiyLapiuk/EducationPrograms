using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            EducationPrograms = new HashSet<EducationProgram>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int UniversityId { get; set; }

        public virtual University University { get; set; } = null!;
        public virtual ICollection<EducationProgram> EducationPrograms { get; set; }
    }
}
