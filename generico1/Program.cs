namespace generecidad
{
    class Program
    {
        static void Main(string[] args)
        {
            var coso1 = new Box<int>(32);
            System.Console.WriteLine(coso1.getContent());
            coso1.UpdateContent(42);
            System.Console.WriteLine(coso1.getContent());
            System.Console.WriteLine(coso1.GetTypeName());
            System.Console.WriteLine("-----------------");

            var coso2 = new Box<string>("holas");
            System.Console.WriteLine(coso2.getContent());
            coso2.UpdateContent("adios");
            System.Console.WriteLine(coso2.getContent());
            System.Console.WriteLine(coso2.GetTypeName());
            System.Console.WriteLine("-----------------");


        }
    }
}