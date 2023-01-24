using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class CompetencesType
    {
        public CompetencesType()
        {
            Competences = new HashSet<Competence>();
        }

        public int Id { get; set; }
        public string CompType { get; set; } = null!;

        public virtual ICollection<Competence> Competences { get; set; }
    }
}
