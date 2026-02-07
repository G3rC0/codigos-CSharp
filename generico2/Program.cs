namespace Generico
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Duo<int>(10,20);
            Console.WriteLine(d1.GetPrimero());
            Console.WriteLine(d1.GetSegundo());
            d1.Intercambiar();
            Console.WriteLine(d1.GetPrimero());
            Console.WriteLine(d1.GetSegundo());
        }
    }
}