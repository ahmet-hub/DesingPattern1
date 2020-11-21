using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee ahmet = new Employee();
            ahmet.Name = "ahmet";
            Employee samet = new Employee();
            samet.Name = "samet";
            Employee ali = new Employee();
            ali.Name = "ali";
            Employee ayse = new Employee();
            ayse.Name = "ayse";

            ahmet.AddSubordinates(samet);
            ahmet.AddSubordinates(ali);
            ahmet.AddSubordinates(ayse);

         

            foreach (var item in ahmet._subordinates)
            {
                Console.WriteLine(item.Name);

            }

        }
    }


    public interface IPerson
    {
        public string Name { get; set; }
    }

    public class Employee : IPerson,IEnumerable<IPerson>
    {
        public string Name { get; set; }

        public List<IPerson> _subordinates = new List<IPerson>();
        
        public void AddSubordinates(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinates(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson Get(int index)
        {

            return _subordinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var item in _subordinates)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
