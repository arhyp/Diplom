using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class Enrollee
    {
        public Enrollee()
        {
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Zno { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
