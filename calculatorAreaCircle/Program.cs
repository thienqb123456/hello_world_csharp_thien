namespace calculatorAreaCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Enter the a circle's radius: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double areaCircle = r * r * pi;
            Console.WriteLine("Area of the Circle have circle's radius = {0}  = : {1}", r, areaCircle);

        }
    }
}