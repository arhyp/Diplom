using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Univ_and_depart
    {
        int id;
        string univName;
        string departName;
        int count;
        int rate;
        List<Student> listOfStud;

       public  Univ_and_depart(int _id, string _univName, string _departName, int _count, int _rate)
        {
            id = _id;
            univName = _univName;
            departName = _departName;
            count = _count;
            rate = _rate;
            listOfStud = new List<Student>();
            
        }

        public bool takeStudent(Student a)
        {
            

            if (a.rate >= this.rate && listOfStud.Count < this.count)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void addStudent(Student a)
        {
            a.free = false;
            this.listOfStud.Add(a);
        }
        public override string ToString()
        {
            return string.Format("Univ Name: {0}, kafedra: {1} places: {2} rate: {3}", univName, departName, count, rate);
        }
        
        public void  displayStudents()
        {
            int i = 0;
            foreach (Student stud in listOfStud.ToArray())
            {
                Console.Write((i++).ToString(), ") ");
                stud.Display();

            }
            Console.WriteLine("");
        }
    }
}
