using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class Speciality
    {
        public Speciality()
        {
            EducationPrograms = new HashSet<EducationProgram>();
            LearningOutcomes = new HashSet<LearningOutcome>();
            SpecialityCompetences = new HashSet<SpecialityCompetence>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<EducationProgram> EducationPrograms { get; set; }
        public virtual ICollection<LearningOutcome> LearningOutcomes { get; set; }
        public virtual ICollection<SpecialityCompetence> SpecialityCompetences { get; set; }
    }
}
