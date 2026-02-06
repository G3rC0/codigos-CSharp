using System;
namespace ejer2{

    class Moto : IVehiculo
    {
        public int Gasolina {get; set;}

        public Moto()
        {
            Gasolina = 100;
        }

        public void Acelerar(int velocidad)
        {
            Gasolina -= 1;
            
            System.Console.WriteLine($"el veiculo esta a {velocidad} km/h. Gasolina restante: {Gasolina}");
        }
    }
}