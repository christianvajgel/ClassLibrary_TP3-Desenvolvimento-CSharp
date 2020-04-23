using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_tp3_csharp
{
    class Repository
    {
        public Repository(List<Person> people)
        {
            People = people ?? throw new ArgumentNullException(nameof(people));
        }

        public List<Person> People { get; set; }
        //internal List<Person> People { get => people; set => people = value; }
    }
}
