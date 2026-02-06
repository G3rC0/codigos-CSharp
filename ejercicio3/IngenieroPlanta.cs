namespace ejer3
{
    class IngenieroPLanta : IPagable
    {
        public string nombre{get; set;}
        public decimal sueldoBasico{get; set;}
        public decimal bonoAntiguedad{get; set;}

        public IngenieroPLanta()
        {
            nombre = "gerson";
            sueldoBasico = 3000m;
            bonoAntiguedad = 500.50m;
        }
        public decimal CalcularLiquido()
        {
            decimal total = 0;
            total = (sueldoBasico + bonoAntiguedad)*0.87m;
            return(total);
        }   

        public void GenerarBoleta()
        {
            System.Console.WriteLine($"El ingeniero {nombre} tiene el sueldo de {CalcularLiquido()}");
        }
    }
}