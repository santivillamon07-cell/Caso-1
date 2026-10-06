using System;

class Program
{
    static void Main()
    {
        double nota;

        Console.Write("Ingrese la nota final: ");
        string entrada = Console.ReadLine();

        // se revisa que lo que se escribio sea un numero
        if (double.TryParse(entrada, out nota))
        {
            // se revisa que la nota este dentro de la escala
            if (nota >= 0 && nota <= 100)
            {
                if (nota >= 70)
                {
                    Console.WriteLine("El estudiante aprueba el curso.");
                }
                else
                {
                    Console.WriteLine("El estudiante reprueba el curso.");
                }
            }
            else
            {
                Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: tiene que ingresar un numero.");
        }
    }
}