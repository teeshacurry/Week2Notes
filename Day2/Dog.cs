using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    // nothing has been created. whats been done below are the instructions for creation
    //class definition
    class Dog  //name for instructions. all objects have a constructor   //Class is the instructions or blueprint for object
    {
        private int Age; //adding public tells that age is open or anyone to change or set; private means it cannot be changed or exposed
        public string name;
        public List<Dog> friends = new List<Dog>(); //list is used to create a group
        // by adding string _name you are adding a string to allow a name. constructor has same name as return type
        public Dog(string _name)   //constructor- going to return the new instance of the dog; no return type //public is an access modifier(used to determine protection level)
        {
            Age = 0;
            name = _name;
        }

        public void HappyBirthday()
        {
            Age++;
        }

        public int GetAge()           // get/return by exposing through public accessor
        {
            return Age;
        }

        public int GetAgeDogYears()
        {
            return Age * 7;
        }

        public void AddFriend(Dog friend)
        {
            if (friends.Contains(friend))
            {
                Console.WriteLine($"Dog {friend} is already our friend");
            }
            else
            {
                friends.Add(friend);

            }

        }

        public void RemoveFriend(Dog friend)
        {
            friends.Remove(friend); //only removes one instance of friend
        }

        public void GetDogFriend()
        {
            Console.WriteLine(string.Join(", ", friends));
        }

        public override string ToString()  // ***ToString has to return a string
        {
            return $"{name}: {Age}";
        }
    }
}

