using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models //перевірочка ще раз і ще раз
{
    public partial class Competence
    {
        public Competence()
        {
            SpecialityCompetences = new HashSet<SpecialityCompetence>();
        }

        public int Id { get; set; }
        public string Competence1 { get; set; } = null!;
        public int CompetenceTypeId { get; set; }

        public virtual CompetencesType CompetenceType { get; set; } = null!;
        public virtual ICollection<SpecialityCompetence> SpecialityCompetences { get; set; }
    }
}
