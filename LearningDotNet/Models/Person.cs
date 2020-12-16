using System;
namespace LearningDotNet.Models
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        public string FullName()
        {
            return this.FirstName + ' ' + this.LastName;
        }

        public string PrettyPrint()
        {
            return $@"
                {this.FirstName} {this.LastName} is {this.Age} years old
            ";
        }
    }
}
