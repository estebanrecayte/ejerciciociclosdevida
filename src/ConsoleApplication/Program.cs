using System;
using ClassLibrary;

namespace ConsoleApplication
{
    
    public static class Program
    {
        /*
           public static void Main()
        {
            for (int i=1; i<=100; i++){
                Train tren = new Train (i.ToString());
                Console.WriteLine(tren.Count);
            }
        }
        
           public static void Main()
        {
            for (int i=1; i<=10000000; i++){
                Train tren = new Train (i.ToString());
                Console.WriteLine(tren.Count);
            }
        }
        Al correr este programa mi computadora se tranco y tuve que cerrar Visual Studio Code. En mi opinion la memoria
        colapso ya que al crearse tantas variales 
        y las mismas no fueron destruidas llega un punto que colpasa y se tranca el ordenador.
        */
        
        public static void Main()
        {
            Train t1 = new Train("Last Train to London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {t1==t2}");
            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {t2==t3}");
            }
        }
        /*
        En primer lugar apesar de que t1 y t2 poseen el mismo nombre; en las primeras 
        dos instrucciones se crean 2 objetos independientes "Last Train to London". 
        Cada objeto ocupa un espacio diferente en el heap de la memoria.

        Con respecto a t2 y t3 tambien son diferentes objetos 
        ya que cada uno se guarda en un lugar diferente del heap.
        */
    }