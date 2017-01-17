using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{ // nothing has been created. whats been done below are the instructions for creation
    //class definition
    class Dog  //name for instructions. all objects have a constructor   //Class is the instructions or blueprint for object

    {
         private int Age; //adding public tells that age is open or anyone to change or set; private means it cannot be changed or exposed
        public string name;
                                    // by adding string _name you are adding a string to allow a name. constructor has same name as return type
        public Dog (string _name)   //constructor- going to return the new instance of the dog; no return type //public is an access modifier(used to determine protection level)
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
    }

    class Program 
    {
        static void Main(string[] args)
        {   //Class is the instructions or blueprint for object
            var fido = new Dog("Fido");              // have to have new there first method jumps to constructor setting age to 0
            fido.HappyBirthday();              // telling fido to have a birthday ( jumps to the 2nd and have age change)
            fido.HappyBirthday();              // telling fido to have a birthday ( jumps to the 2nd and have age change)
            fido.HappyBirthday();              // telling fido to have a birthday ( jumps to the 2nd and have age change)
            fido.HappyBirthday();              // telling fido to have a birthday ( jumps to the 2nd and have age change)
            fido.HappyBirthday();              // telling fido to have a birthday ( jumps to the 2nd and have age change)

            var age = fido.GetAge();
            var ageDogYears = fido.GetAgeDogYears();
            Console.WriteLine(age);
            Console.WriteLine(ageDogYears);
            Console.WriteLine(fido.name);



        }
    }
}
