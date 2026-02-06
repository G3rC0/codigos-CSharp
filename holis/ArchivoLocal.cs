using System;
namespace ejercio1
{
    class ArchivoLocal: IGuardable
    {
        public void guardar(String datos)
        {
            System.Console.WriteLine("Escribiendo en C:/archivos/data.txt...");
        }

        public string Leer()
        {
            return ("$Datos desde SQL Server");
        }
    }
}