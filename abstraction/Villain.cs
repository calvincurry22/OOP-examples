namespace abstraction
{
    /* This is an example of abstraction.
    The Villain class inherits the abstract class VillainAbstractInfo and all of its members.
    The DisplayEnemy method was an inherited abstract method that I used the override keyword on to add a definition to its body. 
    */
    public class Villain : VillainAbstractInfo
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Villain(string name)
        {
            _name = name;
        }

        public override void DisplayEnemy()
        {
            System.Console.WriteLine($"{Name}'s main enemy is {Enemy}");
        }

    }
}