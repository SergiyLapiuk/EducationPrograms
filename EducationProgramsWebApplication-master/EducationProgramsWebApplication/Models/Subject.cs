using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class Subject
    {
        public Subject()
        {
            EpSubjectCompetences = new HashSet<EpSubjectCompetence>();
            EpSubjectLoutcomes = new HashSet<EpSubjectLoutcome>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int EprogramId { get; set; }
        public int Credit { get; set; }
        public int ControlId { get; set; }

        public virtual ControlType Control { get; set; } = null!;
        public virtual EducationProgram Eprogram { get; set; } = null!;
        public virtual ICollection<EpSubjectCompetence> EpSubjectCompetences { get; set; }
        public virtual ICollection<EpSubjectLoutcome> EpSubjectLoutcomes { get; set; }
    }
}
