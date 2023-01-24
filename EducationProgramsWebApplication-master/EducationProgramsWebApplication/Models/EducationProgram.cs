using System;
using System.Collections.Generic;

namespace EducationProgramsWebApplication.Models
{
    public partial class EducationProgram
    {
        public EducationProgram()
        {
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SpecialityId { get; set; }
        public string Edbo { get; set; } = null!;
        public int EdPrTypeId { get; set; }
        public int FacultyId { get; set; }
        public DateTime ImplementationDate { get; set; }

        public virtual EdProgramType EdPrType { get; set; } = null!;
        public virtual Faculty Faculty { get; set; } = null!;
        public virtual Speciality Speciality { get; set; } = null!;
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
