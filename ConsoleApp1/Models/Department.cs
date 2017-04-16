using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class Department
    {
        public Department()
        {
            Speciality = new HashSet<Speciality>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdUniversity { get; set; }

        public virtual ICollection<Speciality> Speciality { get; set; }
        public virtual University IdUniversityNavigation { get; set; }
    }
}
