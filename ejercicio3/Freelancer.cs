namespace ejer3
{
    class Freelancer : IPagable
    {
        public string nombre{get; set;}
        public decimal costoHora{get; set;}
        public int  horasTrabajadas{get; set;}

        public Freelancer()
        {
            nombre = "mada";
            costoHora = 300.40m;
            horasTrabajadas = 8;
        }
        public decimal CalcularLiquido()
        {
            decimal total = 0;
            total = costoHora * horasTrabajadas;
            return(total);
        }   

        public void GenerarBoleta()
        {
            System.Console.WriteLine($"El Freelancer {nombre} tiene el sueldo de {CalcularLiquido()}");
        }
    }
}