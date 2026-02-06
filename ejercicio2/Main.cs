using System;

namespace ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehiculo> garaje = new List<IVehiculo>();
            var a1=new Auto();
            var m1=new Moto();

            garaje.Add(a1); 
            garaje.Add(m1);

            foreach(var Vehiculo in garaje)
            {
                Vehiculo.Acelerar(100);
                System.Console.WriteLine(Vehiculo);
            }
        }
    }
}