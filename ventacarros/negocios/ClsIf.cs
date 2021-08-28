using System;
using negocios;
using System.Collections.Generic;
using System.Text;
using entidades;




namespace negocios
{
    public class ClsIf
    {
       
        private int num=0;
        private string num2 ;


        public string logica()
        {
            
            while (num != 5)
            {
                Console.WriteLine("¡Te ha gustado algun carro de los que te mostraron!\nDigita si para comprar\nDigita no para salir\n------------------------------------------------");
                num2 = Console.ReadLine();

                if (num2 == "si")
                {
                   
                    Console.WriteLine("\nDigita 5 para salir \nDIGITA EL NUMERO DEL CARRO QUE QUIERE COMPRAR \n------------------------------------------------------------");
                    num = int.Parse(Console.ReadLine());
                    if (num == 1)
                    {
                        Clscatalogos car1 = new Clscatalogos();

                        Console.WriteLine("usted decidio comprar el carro 1 , con las siguientes especificaciones ");
                        Console.WriteLine(car1.Carro1());
                        Console.WriteLine("------------------------------------------------------------------\nEl total a pagar es de 12000 dolares\n \n ");


                    }
                    if (num == 2)
                    {
                        Clscatalogos car2 = new Clscatalogos();

                        Console.WriteLine("usted decidio comprar el carro 2 , con las siguientes especificaciones " );
                        Console.WriteLine(car2.Carro2());
                        Console.WriteLine("------------------------------------------------------------------\nEl total a pagar es de 18000 dolaress\n\n ");
                    }
                    if (num == 3)
                    {
                        Clscatalogos car3 = new Clscatalogos();

                        Console.WriteLine("usted decidio comprar el carro 3 , con las siguientes especificaciones " );
                        Console.WriteLine(car3.Carro3());
                        Console.WriteLine("------------------------------------------------------------------\nEl total a pagar es de 80000 dolaress \n\n");
                    }
                    if (num == 4)
                    {
                        Clscatalogos car4 = new Clscatalogos();

                        Console.WriteLine("usted decidio comprar el carro 4 , con las siguientes especificaciones ");
                        Console.WriteLine(car4.Carro4());
                        Console.WriteLine("------------------------------------------------------------------\nEl total a pagar es de 5000 dolaress\n\n ");

                    }

                    if (num <= 0 || num >= 6)
                    {
                        Console.WriteLine("la opcion que usted quiere no se encuentra disponble,");
                    }

                
                }
                if (num2 =="no")
                    
                {
                    break;

                    Console.WriteLine("pronto tendremos nuevos vehiculos a la venta, vuelve pronto\n---------------------------------------------------------------------------");
                }
                if (num2 != "si" && num2 != "no")
                {
                    Console.WriteLine("esta opcion no se encuentra disponible");
                }

                 
            }
            
        return "";
        }
    }
}
