using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class SpecialityCompetence
    {
        public SpecialityCompetence()
        {
            EpSubjectCompetences = new HashSet<EpSubjectCompetence>();
        }

        public int Id { get; set; }
        public int SpecialityId { get; set; }
        public int CompetenceId { get; set; }

        public virtual Competence Competence { get; set; } = null!;
        public virtual Speciality Speciality { get; set; } = null!;
        public virtual ICollection<EpSubjectCompetence> EpSubjectCompetences { get; set; }
    }
}
