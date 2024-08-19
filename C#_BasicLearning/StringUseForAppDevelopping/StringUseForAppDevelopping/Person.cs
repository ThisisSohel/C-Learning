using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUseForAppDevelopping
{
    
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Person[] people;
        public static int arrayPosition = 0;

        //FileStream fs = File.Create(@"");
       

        public void PersonCreate(Person per)
        {
            if(arrayPosition == 0)
            {
                people = new Person[1];
                people[arrayPosition] = per;
                arrayPosition++;
            }
            else if(Array.Exists(people, p => p.Id == per.Id))
            {
                Console.WriteLine($"The person you are trying to add with Id- {Id} to the database is already exist!");
            }
            else
            {
                var tempArr = people;
                people = new Person[tempArr.Length + 1];
                for(int i = 0; i < tempArr.Length; i++)
                {
                    people[i] = tempArr[i];
                }
                people[arrayPosition] = per;
                arrayPosition++;
            }
        }

        public void PersonList(int id)
        {
            if(Array.Exists(people, c => c.Id == id)) 
            {
                Console.WriteLine();
            }
            else
            {
                
            }
        }
    }
}
