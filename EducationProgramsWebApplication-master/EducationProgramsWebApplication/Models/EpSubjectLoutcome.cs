using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class EpSubjectLoutcome
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int LearningOutcomeId { get; set; }

        public virtual LearningOutcome LearningOutcome { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
