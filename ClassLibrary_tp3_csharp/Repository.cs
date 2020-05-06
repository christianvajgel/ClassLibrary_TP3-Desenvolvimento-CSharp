using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClassLibrary_tp3_csharp
{
    public class Repository
    {

        //public Repository(List<Person> people)
        //{
        //    People = people ?? throw new ArgumentNullException(nameof(people));
        //}

        //public List<Person> People { get; set; }
        ////internal List<Person> People { get => people; set => people = value; }

        private static List<Person> people = new List<Person>();

        public static string addPerson(Person person) 
        {
            var ok = false;
            var message = "";
            foreach (var match in people)
            {
                if (match == person)
                {
                    message = "Person already exists.";
                    ok = true;
                    break;
                }
            }

            if (ok == false) 
            {
                people.Add(person);  
                message = "Person added.";
            }

            return message;
            
        }
        public static string searchPeople() 
        {
            return "";
        }
        public static string updatePerson() 
        {
            return "";
        }
        public static string deletePerson() 
        {
            return "";
        }
    }
}
