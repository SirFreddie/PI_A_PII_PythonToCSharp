using System;

namespace PythonToCSharp
{
    class _For
    {
        /*
        1. Escribir un programa que solicite al usuario una cantidad y luego itere la cantidad de veces dada.
        En cada iteración, solicitar al usuario que ingrese un número. 
        Al finalizar, mostrar la suma de todos los números ingresados.
        */
        public void SumaNumeros()
        {
            int suma = 0;

            Console.WriteLine("Ingrese cantidad de iteraciones: ");
            string iteraciones = Console.ReadLine();

            for(int i = 0; i < Int32.Parse(iteraciones); i++)
            {
                Console.WriteLine("Ingrese un numero a sumar: ");
                string number = Console.ReadLine();

                suma += Int32.Parse(number);
            }

            Console.WriteLine($"La suma total es: {suma}");

        }
        /*
        2. Para utilizar un módulo es necesario importar el módulo mediante la declaración “import” 
        seguido del nombre del módulo. Utilizaremos el ya conocido módulo “random” y su función random.randint 
        donde random.randint(1,6) devuelve un número aleatorio entre 1 y 6 (incluidos).

        a. Realizar un programa para simular 20 tiradas de dos dados simultáneamente,
         dando el promedio de la suma de los resultados de los dos dados. 
         Esta vez resolver el ejercicio con la estructura de repetición for.

        b. Realizar un programa que cuente la cantidad de veces que salió la cara 1, 2, … 6 en 30 tiradas.
         Esta vez resolver el ejercicio con la estructura de repetición for.
        */

        // TODO

        /*
        3. Escribir un programa que permita al usuario ingresar 6 números enteros, 
        que pueden ser positivos o negativos.
        Al finalizar, mostrar la sumatoria de los números negativos y el promedio de los positivos. 
        No olvides que no es posible dividir por cero, por lo que es necesario evitar que el programa arroje un error
        si no se ingresaron números positivos.
        */
        public void Suma_Promedio()
        {
            int suma = 0;
            int promedio = 0;

            for(int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Ingrese un nuemro: ");
                int num = Int32.Parse(Console.ReadLine());
                
                if(num != 0)
                {
                    if(num < 0)
                    {
                        suma += num;
                    }
                    else
                    {
                        promedio += num;
                    }
                }
            }
            Console.WriteLine($"El promedio de los positivos es: {promedio/6}");
            Console.WriteLine($"La sumatoria de los negativos es: {suma}");

        }


    }
}