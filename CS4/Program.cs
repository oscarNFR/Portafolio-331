using System;
namespace CS4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesion 7: Estructuras selectivas
            // a. Simple: Instrucción if
            int a = 0;
            if (a == 1) // Si el valor de a es igual a 1, entonces se ejecuta el bloque de instrucciones
            {
                // Bloque de instrucciones
                Console.WriteLine($"El valor de a es: {a}");
                a += 1;
                Console.WriteLine($"El valor de a es: {a}");
            }
            // b. Doble: Instrucción if-else
            // c. Múltiple; Instrucción if-else if-else

             // Sesión 8: Estructuras selectivas: dobles y múltiples
            // 1. Estructura selectiva doble (instrucción if-else)
            // Declaración e inicialziación
            bool foco = false; // A la variable "foco", se le asigna, inicialmente, false.
            if (foco == true) // Si el valor de la variable "foco" es true, entonces...
            {
                Console.WriteLine("El foco está encendido."); // ...impresión del estado del foco: encendido.
            }
            else // En caso contrario, entoces...
            {
                Console.WriteLine("El foco está apagado."); // ...impresión del estado del foco: apagado.
            }
            // 2. Estructura selectiva múltiple (instrucción if-else if-else)
            // Declaración e inicialización
            int salón = 331; // A la variable "salón, se le asigna, inicialmente, 331.
            if (salón == 331) // Si el valor de la variable "salón" es 331, entonces...
            {
                Console.WriteLine("Exactas"); // ...impresión de especialidad: "Exactas".
            }
            else if (salón == 332 || salón == 333) // Si no es igual a 331, pero sí a 332 o 333, entonces...
            {
                Console.WriteLine("Administrastivas"); // ...impresión de especialidad: "Administrativas".
            }
            else if (salón == 334) // Si no es igual a 331, 332 o 333, pero sí a 334, entonces...
            {
                Console.WriteLine("Humanidades"); // ...impresión de especialidad: "Humanidades".
            }
            else if (salón == 335) // Si no es igual a 331, 332, 333, 333 o 334, pero sí a 335, entonces...
            {
                Console.WriteLine("Biológicas"); // ...impresión de especialidad: "Biológicas".
            }
            else // En cualquier otro caso, entocnes...
            {
                Console.WriteLine("¡Salón no registrado!"); // ...impresión: "¡Salón no registrado!".
            }
        }
    }

}