using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._1
{
    internal class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Person(string firstName, string lastName, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public static Dictionary<string, Person> PhoneBook;
        public static void CreateData()
        {
            PhoneBook = new Dictionary<string, Person>
            {
                { "JohnDoe", new Person("John", "Doe", "123-456-7890", "123 Elm St") },
                { "JaneSmith", new Person("Jane", "Smith", "987-654-3210", "456 Oak St") },
                { "AliceJohnson", new Person("Alice", "Johnson", "555-555-5555", "789 Pine St") },
                { "BobBrown", new Person("Bob", "Brown", "444-444-4444", "321 Maple St") },
                { "CharlieDavis", new Person("Charlie", "Davis", "222-222-2222", "654 Cedar St") },
                { "DavidWilson", new Person("David", "Wilson", "111-111-1111", "987 Birch St")   },
            };
        }
        public static string GetFullName(Person person)
        {
            return $"{person.FirstName}{person.LastName}";
        }
        public static void AddPerson(string firstName, string lastName, string phoneNumber, string address)
        {
            Person person = new Person(firstName, lastName, phoneNumber, address);
            PhoneBook[GetFullName(person)] = person;
        }

        public static void RemovePerson(string fullName)
        {
            if (PhoneBook.ContainsKey(fullName))
            {
                PhoneBook.Remove(fullName);
            }
            else
            {
                Console.WriteLine("Person not found in the phone book.");
            }
        }

        //public static int CompareTo(Person Person1, Person other)
        //{
        //    string thisPerson = Person1.FirstName + Person1.LastName;
        //    string otherPerson = other.FirstName + other.LastName;
        //    return string.Compare(thisPerson, otherPerson);
        //}

    }
}
