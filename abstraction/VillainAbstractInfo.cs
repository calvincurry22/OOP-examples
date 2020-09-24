namespace abstraction
{
    /* This is one way to execute abstraction. I created an abstract class VillainAbstractInfo
    and set properties and methods. Notice that the properties do not have the "abstract"
    keyword, but the DisplayEnemy method does. With an abstract class, you can declare
    "abstract" AND "non-abstract" members. Non-abstract members DO NOT have to be
    implemented by the derived class. This is what makes abstract classes 
    different from interfaces, however they both can be used for abstraction.
    */
    public abstract class VillainAbstractInfo
    {
        public string Type { get; set; }
        public string Location { get; set; }
        public string Enemy { get; set; }
        public int VillainKillCount { get; set; }

        public string FamousQuote { get; set; }

        public void DisplayVillainInfo()
        {
            System.Console.WriteLine(@$"
                Kill Count: {VillainKillCount}
                Famous Quote: {FamousQuote}
            ");
        }

        public abstract void DisplayEnemy();

        public static void DoTheThing()
        {
            System.Console.WriteLine("Do The thing");
        }
    }
}