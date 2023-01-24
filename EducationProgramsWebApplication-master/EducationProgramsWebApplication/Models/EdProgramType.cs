using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class EdProgramType
    {
        public EdProgramType()
        {
            EducationPrograms = new HashSet<EducationProgram>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<EducationProgram> EducationPrograms { get; set; }
    }
}
