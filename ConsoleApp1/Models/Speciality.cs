using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class Speciality
    {
        public Speciality()
        {
            Request = new HashSet<Request>();
            Rules = new HashSet<Rules>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdDepartment { get; set; }

        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Rules> Rules { get; set; }
        public virtual Department IdDepartmentNavigation { get; set; }
    }
}
