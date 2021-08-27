using entidades;
using System;
using System.Collections.Generic;
using System.Text;



namespace negocios
{
    public class Clscatalogos

    {
        public string Carro1()
        {
            Console.WriteLine("Carro 1");
            Clscarros clscarros = new Clscarros("Nissan", "sentra", 2012, 0, 5, "azul");
            Console.WriteLine("marca "+ clscarros.Marca + ", modelo "+clscarros.Modelo +", año " +clscarros.Año +", "+clscarros.Km+" kilometros, " + " capacidad " +clscarros.Capacidad + " personas, color " +clscarros.Color);
            veta veta1 = new veta(12000);
            Console.WriteLine("Precio " + veta1.Precio + " dolares.");

           
            return "";

        }
        public string Carro2()
        {
            Console.WriteLine("Carro 2");
            Clscarros clscarros2 = new Clscarros("Nissan", "frontier", 2016, 0, 6, "negro");
            Console.WriteLine("marca " + clscarros2.Marca + ", modelo " + clscarros2.Modelo + ", año " + clscarros2.Año + ", " + clscarros2.Km + " kilometros, " + " capacidad " + clscarros2.Capacidad + " personas, color " + clscarros2.Color);
            veta veta2 = new veta(18000);
            Console.WriteLine("Precio " + veta2.Precio + " dolares.");
            return "";

        }
        public string Carro3()
        {
            Console.WriteLine("Carro 3");
            Clscarros clscarros3 = new Clscarros("Nissan", "GTR", 2020, 0, 2, "rojo");
            Console.WriteLine("marca " + clscarros3.Marca + ", modelo " + clscarros3.Modelo + ", año " + clscarros3.Año + ", " + clscarros3.Km + " kilometros, " + " capacidad " + clscarros3.Capacidad + " personas, color " + clscarros3.Color);
            veta veta3 = new veta(80000);
            Console.WriteLine("Precio " + veta3.Precio + " dolares.");
            return "";
        }
        public string Carro4()
        {
            Console.WriteLine("Carro 4");
            Clscarros clscarros4 = new Clscarros("Nissan", "harboody", 1987, 0, 5, "Gris");
            Console.WriteLine("marca " + clscarros4.Marca + ", modelo " + clscarros4.Modelo + ", año " + clscarros4.Año + ", " + clscarros4.Km + " kilometros, " + " capacidad " + clscarros4.Capacidad + " personas, color " + clscarros4.Color);
            veta veta4 = new veta(5000);
            Console.WriteLine("Precio " + veta4.Precio + " dolares.");
            return "";

        }
        






    }
}
