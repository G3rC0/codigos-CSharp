using System;

namespace ejer2
{
    interface IVehiculo
    {
        int Gasolina {get; set;}
        void Acelerar(int velocidad);
        
    }
}