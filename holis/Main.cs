using System;

namespace ejercio1
{
    class Program{
        static void Main(string[] args)
        {
            IGuardable miSistema = new BaseDeDatos();
            miSistema.guardar("3242149");
            System.Console.WriteLine(miSistema.Leer());

            IGuardable S2 = new ArchivoLocal();
            S2.guardar("12356657");
            System.Console.WriteLine(S2.Leer());
        }
    }
}