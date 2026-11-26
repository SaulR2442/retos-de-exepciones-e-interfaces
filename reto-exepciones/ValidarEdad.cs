using System ;

public class ValidarEdad 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======================") ;
        Console.WriteLine("== Reto excepciones ==") ;
        Console.WriteLine("======================") ;

    try {

        Console.WriteLine("Ingrese su edad -> ") ;
        int num = int.Parse(Console.ReadLine()) ;
        if (num < 0 || num > 120)
        {
            throw new EdadInvalidaException("La edad está fuera del rango permitido.", num);
        }
        Console.WriteLine($"Edad válida: {num} años.");
    }
    catch (FormatException e) {
    Console.WriteLine("Error: Debes introducir un número válido. ") ;
    }
    catch (EdadInvalidaException ex)
    {   
    Console.WriteLine($"{ex.Message} (Valor recibido: {ex.EdadIngresada})");
    }
    finally
        {
            Console.WriteLine("======================================") ;
            Console.WriteLine("== Proceso de validación finalizado ==") ;
            Console.WriteLine("======================================") ;
        }
    }
}

