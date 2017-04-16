using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public partial class Rules
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int BudgetCount { get; set; }
        public int? IdSpeciality { get; set; }
        public double? Score { get; set; }

        public virtual Speciality IdSpecialityNavigation { get; set; }
    }
}
