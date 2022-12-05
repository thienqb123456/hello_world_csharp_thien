namespace GiaiPTBac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number c");
            double c = Convert.ToInt32(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            double x;
           
                if (delta < 0) {
                    Console.WriteLine("Phuong Trinh Vo Nghiem");
                }
                else if (delta == 0)
                {
                    x = -b / 2*a;
                    Console.WriteLine("Phuong trinh co nghiem kep : x1 = x2 = {x)", x);
                }
                else
                {
                Console.WriteLine("Phuong trinh co 2 nghiem : ");
                    x = (-b + Math.Sqrt(delta)) / 2*a;
                    Console.WriteLine("x = {0}", x);
                    x = (-b - Math.Sqrt(delta)) / 2*a;
                    Console.WriteLine("x = {0}", x) ;
                }
        }
    }
}