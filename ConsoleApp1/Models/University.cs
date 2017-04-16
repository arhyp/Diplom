using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class University
    {
        public University()
        {
            Department = new HashSet<Department>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Department> Department { get; set; }
    }
}
