
namespace Section1LabAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("First Name :");
            string firstName = System.Console.ReadLine();
            System.Console.Write("Middle Initial :");
            string middleInitial = System.Console.ReadLine();
            System.Console.Write("Last Name :");
            string lastName = System.Console.ReadLine();
            string fullName = firstName + " " + middleInitial + ". " + lastName;
            System.Console.WriteLine("Full Name :" + fullName);

            System.Threading.Thread.Sleep(3000);
            
            System.Console.Write("Height in Feet :");
            int heightInFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("Extra Inches :");
            double extraInches = double.Parse(System.Console.ReadLine());
            double heightInInches = heightInFeet * 12;
            double totalInches = heightInInches + extraInches;
            double heightInCM = totalInches * 2.54;
            System.Console.WriteLine("Height In Centimeters :" + heightInCM);
          
            System.Threading.Thread.Sleep(3000);

            System.Console.Write("What is your age? :");
            int userAge = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a citizen? :");
            bool isCitizen = System.Console.ReadLine().StartsWith("y");
            bool canVote = userAge >= 18 && isCitizen;

            System.Threading.Thread.Sleep(3000);

            System.Console.Write("Name :");
            System.Console.WriteLine(fullName);
            System.Console.Write("Height :");
            System.Console.WriteLine(heightInCM + "cm");
            System.Console.Write("Can Vote :");
            System.Console.Write(canVote);

            System.Threading.Thread.Sleep(5000);












        }
    }
}
