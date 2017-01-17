using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2


{ class Program 
    {
        static void Main(string[] args)
        {   //Class is the instructions or blueprint for object
            //DogStuff();
            Warrior gromm = new Warrior("Grommish");
            Warrior soap = new Warrior("Soap McTavish");

            soap.Attack(gromm);
            Console.WriteLine(soap);
            Console.WriteLine(gromm);
            soap.Attack(gromm);

            gromm.Attack(soap);

            soap.Attack(gromm);
            soap.Attack(gromm);
            Console.WriteLine(soap);
            Console.WriteLine(gromm);

            {

            }


        }

        private static void DogStuff()
        {
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
            // Console.WriteLine(fido.name);

            var casey = new Dog("Casey");
            var spaghetti = new Dog("Spaghetti");
            spaghetti.HappyBirthday();
            var rex = new Dog("Rex");

            // Console.WriteLine(fido);
            fido.AddFriend(casey);
            fido.AddFriend(spaghetti);
            fido.AddFriend(rex);
            fido.GetDogFriend();

            fido.AddFriend(casey);
            fido.AddFriend(spaghetti);
            fido.AddFriend(rex);
            fido.GetDogFriend();
            fido.RemoveFriend(spaghetti);

            Console.ReadLine();
        }
    }
}
