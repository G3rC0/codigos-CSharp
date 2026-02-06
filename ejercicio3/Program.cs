namespace ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPagable> lista = new List<IPagable>();

            var i1 = new IngenieroPLanta();
            var f1 = new Freelancer();

            lista.Add(i1);
            lista.Add(f1);
            decimal totalEmpresa = 0; // Acumulador
            foreach (var l in lista)
            {
                l.GenerarBoleta();
                totalEmpresa += l.CalcularLiquido();
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine($"TOTAL A DESEMBOLSAR POR LA EMPRESA: {totalEmpresa:F2} Bs");
        }
    }
}