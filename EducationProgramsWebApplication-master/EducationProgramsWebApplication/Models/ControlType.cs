using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class ControlType
    {
        public ControlType()
        {
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string ControlTypeName { get; set; } = null!;

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
