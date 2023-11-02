namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Maverick";
            int myPowerLevel = 9001;
            char myRank = 'S';
            bool isAwesome = true;
            double percentPowerDisplayed = 0.1;
            decimal futureBankAccount = 999999.99m;

            Console.WriteLine($"My name is {myName}.");
            Console.WriteLine("My power level is " + myPowerLevel + ".");
            Console.WriteLine("My current Hunter rank " + myRank + ".");
            Console.WriteLine("The poll's asking if I am awesome came back, and everyone answered " + isAwesome + ".");
            Console.WriteLine("I have only shown " + percentPowerDisplayed + "% of my power!");
            Console.WriteLine("Soon my bank account will show " + futureBankAccount + " dollars.");
        }
    }
}
