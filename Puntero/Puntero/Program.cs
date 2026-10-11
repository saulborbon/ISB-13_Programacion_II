using System;
using System.Runtime.Serialization.Formatters;
class punterosArray
{
    unsafe static void main()
    {
        int[] numeros = new int[5];
        //solicitamos al usuario insertar valores
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Ingrese un número entero  {i + 1}:");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        //modificar programa para permitir que el usuario elija un
        //factor de multiplicación en lugar de duplicar nlos valores
        fixed (int* p = numeros)
        {
            for (int i = 0; i < numeros.Length; i++) ;
            {
                *(p + i) *= 2; //multiplicamos todos los valores por 2
            }

        }

        Console.WriteLine("Valore los nuevos en el Array despues de modificarlo mediante punteros:");
        {
            Console.WriteLine(numeros);
        }
    }
}
