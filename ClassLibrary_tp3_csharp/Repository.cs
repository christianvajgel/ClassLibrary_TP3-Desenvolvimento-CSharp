using System;
using System.Collections.Generic;
using System.Linq;
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

        public static List<Person> people = new List<Person>();

        public static string AddPerson(Person person) 
        {
            return new Func<String>(() => {
                if (CheckContactExistence(person)) { return "Person already exists."; }
                else { return "Person added."; }
            })();
        }

        public static IEnumerable<Person> SearchPeople(string term) 
        {
            return people.Where(person => person.FirstName.Contains(term, StringComparison.InvariantCultureIgnoreCase));
        }

        public static string UpdatePerson(Person person, Person updated) 
        {
            return new Func<String>(() => {
                if (CheckContactExistence(person))
                {
                    people.Remove(person);
                    people.Add(updated);
                    return $"Contact updated successfully.\nOld data:\n {person.FirstName} {person.SurnameName} | Birthday: {person.Birthday}" +
                           $"\nNew data:\n {updated.FirstName} {updated.SurnameName} | Birthday: {updated.Birthday}";
                }
                else
                {
                    return "Person doesn't exists.";
                }
            })();
        }
        public static string DeletePerson(Person person) 
        {
            return new Func<String>(() => {
                if (CheckContactExistence(person)) {
                    people.Remove(person);
                    return $"{person.FirstName} {person.SurnameName} successfully deleted.";
                }
                else 
                { 
                    return "Person added."; 
                }
            })();
        }

        private static Boolean CheckContactExistence(Person person) 
        {
            return new Func<Boolean>(() => {
                var ok = false;
                foreach (var match in people)
                {
                    if (match.FirstName.Equals(person.FirstName)
                        && match.SurnameName.Equals(person.SurnameName)
                        && match.Birthday.Equals(person.Birthday))
                    {
                        ok = true;
                        break;
                    }
                }
                return ok;
            })();
        }
    }
}
