using System;

namespace ClassLibrary_tp3_csharp
{
    class Person
    {
        public Person(string firstName, string surnameName, DateTime birthday)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            SurnameName = surnameName ?? throw new ArgumentNullException(nameof(surnameName));
            Birthday = birthday;
        }

        public string FirstName { get; set; }
        public string SurnameName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
