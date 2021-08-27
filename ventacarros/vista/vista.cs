using negocios;
using System;

namespace vista
{
    class vista
    {
        static void Main(string[] args)
        {
            Clsmenu clsmenu = new Clsmenu();
            ClsIf proceso = new ClsIf();
            Console.WriteLine(clsmenu.Menu());

            Clscatalogos clslogica = new Clscatalogos();
            Console.WriteLine(clslogica.Carro1());
            Console.WriteLine(clslogica.Carro2());
            Console.WriteLine(clslogica.Carro3());
            Console.WriteLine(clslogica.Carro4());
            Console.WriteLine(proceso.logica());
         
           

            Console.ReadLine();
        }
    }
}
