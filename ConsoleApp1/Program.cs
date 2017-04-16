using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {

            var time = DateTime.Now;

            //using (DiplomContext db = new DiplomContext())
            //{


            //    var enrolles = db.Enrollee.ToList();
            //    var specialities = db.Speciality.ToArray();

            //    foreach (Enrollee e in enrolles)
            //    {
            //        // Console.WriteLine($"id: {e.Id}, name: {e.Name}, zno: {e.Zno}");


            //        var random = new Random(DateTime.Now.Millisecond);
            //        specialities = specialities.OrderBy(x => random.Next()).ToArray();

            //        for (int i = 0; i < 5; i++)
            //        {
            //            Request r = new Request();
            //            r.IdEnrollee = e.Id;
            //            r.IdSpeciality = specialities[i].Id;
            //            r.Priority = i;

            //            db.Request.Add(r);
            //            db.SaveChanges();
            //        }

            //    }
            //}

            using (DiplomContext db = new DiplomContext())
            {
                Enrollee[] enr = db.Enrollee.ToArray();
                Speciality[] sp = db.Speciality.ToArray();
                Request[] req = db.Request.ToArray();
                Rules[] rul = db.Rules.ToArray();
                Department[] dep = db.Department.ToArray();
                University[] uni = db.University.ToArray();
                Enrollee en = enr[0];

                Distributor distributor = new Distributor(enr, sp);
                distributor.distributeEnrollees();

            }



            Console.WriteLine($"time spend: {(DateTime.Now - time).TotalMinutes.ToString()}");
            Console.ReadKey();
        }
    }
}

