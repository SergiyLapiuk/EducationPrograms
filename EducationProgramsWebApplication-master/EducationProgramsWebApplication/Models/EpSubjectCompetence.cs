using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class EpSubjectCompetence
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int SpecialityCompetenceId { get; set; }

        public virtual SpecialityCompetence SpecialityCompetence { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
