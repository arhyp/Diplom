using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
     class Student: IComparable<Student>
    {
        int id;
        string name;
        public int rate;
        Univ_and_depart[] arrayOfWishes;
        public bool free = true;


        public  Student(int _id, string _name, int _rate, Univ_and_depart[] _array)
        {
            id = _id;
            name = _name;
            rate = _rate;
            arrayOfWishes = _array;
        }

        public Univ_and_depart GetWish(int i)
        {
            return arrayOfWishes[i];
            if (i+1 > arrayOfWishes.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return arrayOfWishes[i];
        }

        public int CompareTo(Student other)
        {
            
            return other.rate.CompareTo(this.rate);
        }
        public void Display()
        {
            Console.WriteLine($"id: {id}, name: {name}, rate: {rate}");
        }
    }
}
