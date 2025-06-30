namespace WEEK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to islam`s carpet cleaning shop");
            Console.WriteLine("small carpet = 25$ ");
            Console.WriteLine("large carpet = 35$ ");
            Console.WriteLine("+ 6% tax");
            

            Console.WriteLine("Enter the amount of the large carprts : ");
            int Large = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the amount of the small carprts : ");
            int Small = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("price per small room = 25$ ");
            Console.WriteLine("price per large room 35$");
            int cost = (Large * 35) + (Small * 25) ;
            Console.WriteLine($"Cost : {cost:C}");
            double tax = (cost * (6.0 / 100));
            Console.WriteLine($"Tax : {tax:F2:C}");
            double total = cost + tax;

            Console.WriteLine("==========================");

            Console.WriteLine($"Total estimates = {total:C}");
            Console.WriteLine("this estimates is valid for 30 days ");
   
        }
    }
}
