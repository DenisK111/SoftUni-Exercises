﻿namespace EqualityLogic
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /* Create a class Person holding a name and an age. A person with the same name and age should be considered the same. Override any methods needed to enforce this logic. Your class should work with both standards and hashed collections. Create a SortedSet and a HashSet of type Person. You will receive n – the number of input lines. On each of them, you will receive info about the people in the following format:
"<name> <age>"
You should add the people to both sets. In the end, you should print the size of the sorted set and then the size of the HashSet.
Input
•	On the first line of input, you will receive a number n. 
•	On each of the next n lines, you will receive information about people in the described format. 
Output
•	The output should consist of exactly two lines. 
•	On the first one, you should print the size of the sorted set
•	On the second - the size of the HashSet.
Constraints
•	A person’s name will be a string that contains only alphanumerical characters with a length between [1…50] symbols.
•	A person’s age will be a positive integer between [1…100].
•	The number of people N will be a positive integer between [0…100].
*/
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }


      
        public int CompareTo(Person other) 
        {
            var result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            return this.CompareTo(person) == 0;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Name, this.Age);
        }




    }
}