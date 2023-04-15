using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese Cuantos alumnos hay en total: ");
        int cantidadAlumnos = int.Parse(Console.ReadLine());

        string[] nombres = new string[cantidadAlumnos];
        int[] notas = new int[cantidadAlumnos];

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            Console.WriteLine("\nEscriba el nombre del alumno {0}: ", i + 1);
            nombres[i] = Console.ReadLine();

            Console.WriteLine("\nEscriba la nota del alumno {0}: ", i + 1);
            notas[i] = int.Parse(Console.ReadLine());
        }

        int notaMaxima = EncontrarMaximo(notas);
        int notaMinima = EncontrarMinimo(notas);

        Console.WriteLine("\n El alumno con la nota más alta es de {0}:", notaMaxima);
        for (int i = 0; i < cantidadAlumnos; i++)
        {
            if (notas[i] == notaMaxima)
            {
                Console.WriteLine("- {0}", nombres[i]);
            }
        }

        Console.WriteLine("\nEl alumno con la nota más baja es de {0}:", notaMinima);
        for (int i = 0; i < cantidadAlumnos; i++)
        {
            if (notas[i] == notaMinima)
            {
                Console.WriteLine("- {0}", nombres[i]);
            }
        }
    }


    static int EncontrarMaximo(int[] arreglo)
    {
        int maximo = arreglo[0];
        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] > maximo)
            {
                maximo = arreglo[i];
            }
        }
        return maximo;
    }

    static int EncontrarMinimo(int[] arreglo)
    {
        int minimo = arreglo[0];
        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] < minimo)
            {
                minimo = arreglo[i];
            }
        }
        return minimo;
    }
}
