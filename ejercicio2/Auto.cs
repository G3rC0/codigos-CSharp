using System;
namespace ejer2{

    class Auto : IVehiculo
    {
        public int Gasolina {get; set;}

        public Auto()
        {
            Gasolina = 100;
        }

        public void Acelerar(int velocidad)
        {
            Gasolina -= 2;
            
            System.Console.WriteLine($"el veiculo esta a {velocidad} km/h. Gasolina restante: {Gasolina}");
        }
    }
}