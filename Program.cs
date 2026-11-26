using System;
using ValidarEdad ;
using ReproductorMusica ;

void MenuPrincipal ()
{
    Console.WriteLine("============================================================") ;
    Console.WriteLine("== Ingreso a la EV09 - Interfaces y manejo de excepciones ==") ;
    Console.WriteLine("============================================================") ;
    
    try
    {
        Console.WriteLine(@"
    ====================================
    == ¿Que operacion desea realizar? ==
    ====================================
    1.Ingresar al Reto de Excepciones
    2.Ingresar al Reto de Interfaces
    ====================================
    Digite el numero  -> ") ;

     int opcion = int.Parse(Console.ReadLine()) ;

     if (opcion == 1)
        {
            ValidarEdad.ValidarEdad.Ejecutar() ;
        }
     else if (opcion == 2)
        {
            Console.WriteLine("Ingrese la siguiente cancion -> ") ;
            string cancion = Console.ReadLine() ;
            Console.WriteLine("====================================") ;
            MusicPlayer player = new MusicPlayer();
            Console.WriteLine("Estado inicial: " + player.GetCurrentTrack());
            player.LoadTrack(cancion);
            player.Play();
            player.Pause();
            player.Stop();
            Console.WriteLine("Estado final: " + player.GetCurrentTrack());
            Console.WriteLine("====================================") ;
        }
     else
        {
            Console.WriteLine("Deben ser el numero 1 o 2, no es compatible mas numeros.") ;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Debe digitar un numero del 1 al 2.") ;
    }
} 

MenuPrincipal() ;