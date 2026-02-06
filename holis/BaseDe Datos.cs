using System;

namespace ejercio1
{
    class BaseDeDatos : IGuardable
    {
    public void guardar(string datos)
    {
        Console.WriteLine ("INSERT INTO usuarios VALUES...{datos}");
    }

    public string Leer()
    {
        return "Datos desde SQL Server"; // Rellena esto
    }
    }
}