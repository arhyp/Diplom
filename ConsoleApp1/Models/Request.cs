using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class Request
    {
        public int Priority { get; set; }
        public int IdSpeciality { get; set; }
        public int IdEnrollee { get; set; }
        public int Id { get; set; }

        public virtual Enrollee IdEnrolleeNavigation { get; set; }
        public virtual Speciality IdSpecialityNavigation { get; set; }
    }
}
