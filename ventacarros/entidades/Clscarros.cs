using System;

namespace entidades
{
    public class Clscarros
    {
        private string marca;
        private string modelo;
        private int año;
        private int km;
        private int capacidad;
        private string color;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Año { get => año; set => año = value; }
        public int Km { get => km; set => km = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Color { get => color; set => color = value; }
        

        public Clscarros(string marca, string modelo, int año, int km, int capacidad, string color)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.km = km;
            this.capacidad = capacidad;
            this.color = color;
        }


       
    }
    public class veta
    {
        
        private int precio;
        
        

        public int Precio { get => precio; set => precio = value; }
        

        public veta(int precio)
        {
            this.precio = precio;
        }
    }
    public class pago
    {
        private int pagototal;

        public int Pagototal { get => pagototal; set => pagototal = value; }
    }
   
    
}
