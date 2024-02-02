namespace mod2_les7_task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Math exam result: ");
            int mathResult = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Physics exam result: ");
            int physicResult = int.Parse(Console.ReadLine());

            Console.WriteLine("Eneter your Chemistry exam result: ");
            int chemistryResult = int.Parse(Console.ReadLine());

            int sumOfResults = mathResult + physicResult + chemistryResult;

            if (mathResult > 70 && physicResult > 55 && chemistryResult > 45 && sumOfResults > 180)
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else if ((mathResult + physicResult) > 150)
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else if ((mathResult + chemistryResult) > 150)
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else
            {
                Console.WriteLine("The candidate is not admitted to recruitment");
            }
        }
    }
}