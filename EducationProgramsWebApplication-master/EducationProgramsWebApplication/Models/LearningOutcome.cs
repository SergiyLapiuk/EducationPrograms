using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class LearningOutcome
    {
        public LearningOutcome()
        {
            EpSubjectLoutcomes = new HashSet<EpSubjectLoutcome>();
        }

        public int Id { get; set; }
        public string LearningOutcome1 { get; set; } = null!;
        public string Loname { get; set; } = null!;
        public int SpecialityId { get; set; }

        public virtual Speciality Speciality { get; set; } = null!;
        public virtual ICollection<EpSubjectLoutcome> EpSubjectLoutcomes { get; set; }
    }
}
