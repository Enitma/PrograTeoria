using System;
using System.Collections.Generic;
using System.Linq;

namespace Semana5
{
    class Program
    {
        static void Main(string[] args)
        {
            
		//otro problema

            //mi forma
            var lista=new List<String> {

                "Manzana","Uva","Piña","Naranja","Pera"

            };

            for (int i = 0; i < lista.Count; i++)
            {
                int can=lista[i].Length;

                if(can>4){
                    Console.WriteLine(lista[i]);
                }
            }

            //forma del profe
            var fruta=lista.Where(x=>x.Length>4);

            foreach(var item in frutas){
                Console.WriteLine(item);
            }

            //lista
            var lista = new List<int> { 15, 16, 17, 2, 0, 32, 12 };

            Console.WriteLine(lista[1]);
            Console.WriteLine(lista.Count);
            double pro=0,sum=0;

            for (int i = 0; i < lista.Count-1; i++)
            {
                sum=sum+lista[i];
            }

            pro=(sum/(lista.Count));

            Console.WriteLine(pro);

            //OTRA FORMA

            Console.WriteLine(lista.Average());
            Console.WriteLine(lista.Sum());
            
            var aprobados=lista.Where(x => x > 10);
            Console.WriteLine(aprobados.Count());

             //Entrada
            Console.WriteLine("Como te llamas");
            var nombre= Console.ReadLine();
            Console.WriteLine("Hola "+nombre);
            Console.WriteLine($"Hola {nombre}");

            Console.WriteLine("¿Que edad tienes?");
            var edad=Convert.ToInt32(Console.ReadLine());
            var edadAmigo=edad+5;


            //Salida
            Console.WriteLine("Hello World!");
            Console.WriteLine(20);
            Console.WriteLine(10.5);
            Console.Write("Hola nena");

           
        }
    }
}
