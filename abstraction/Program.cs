using System;
namespace abstraction
{
    /* Abstraction is a principle of object-oriented programming language (OOP) and it is used 
    to hide the implementation details and display only essential features of the object. An interface was used for
    abstraction with the Hero class, and an abstract class was used for abstraction with the Villain class.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* Creating an instance of the Villain class, and calling the abstract method DisplayEnemy and the 
            non-abstract method DisplayVillainInfo. */
            var drDoom = new Villain("Dr. Doom");
            drDoom.Enemy = "Reed Richards";
            drDoom.FamousQuote = "I was a god Valeria. I found it...beneath me.";
            drDoom.Location = "Latveria";
            drDoom.Type = "Magic";
            drDoom.VillainKillCount = 1000000000;
            drDoom.DisplayEnemy();
            drDoom.DisplayVillainInfo();
            Villain.DoTheThing();
            /* this is a static method that was create in VillainAbstractInfo. It does not need an instance
                       of the Villain class to be called */

            /* Creating an instance of the Hero class, and calling the interface method DisplayTeam */
            var ironMan = new Hero()
            {
                Name = "Iron Man",
                Type = "Tech",
            };
            ironMan.DisplayTeam("Avengers");
        }
    }
}