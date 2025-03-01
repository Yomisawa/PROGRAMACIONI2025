using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Seleccione un desafío:");
            Console.WriteLine("1. Cálculo de ingresos");
            Console.WriteLine("2. Operaciones matemáticas");
            Console.WriteLine("3. Suma con manejo de errores");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Desafio1();
                    break;
                case "2":
                    Desafio2();
                    break;
                case "3":
                    Desafio3();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void Desafio1()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        double[] ingresos = new double[3];
        double suma = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingrese el ingreso del mes {i + 1}: ");
            ingresos[i] = Convert.ToDouble(Console.ReadLine());
            suma += ingresos[i];
        }

        double promedio = suma / 3;
        Console.WriteLine($"Hola {nombre}, en total ganaste {suma} y promediaste {promedio}");
    }

    static void Desafio2()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Suma: {Sumar(num1, num2)}");
        Console.WriteLine($"Resta: {Restar(num1, num2)}");
        Console.WriteLine($"Multiplicación: {Multiplicar(num1, num2)}");
        Console.WriteLine($"División: {(num2 != 0 ? Dividir(num1, num2).ToString() : "No se puede dividir por cero")}");
    }

    static int Sumar(int a, int b) => a + b;
    static int Restar(int a, int b) => a - b;
    static int Multiplicar(int a, int b) => a * b;
    static int Dividir(int a, int b) => a / b;

    static void Desafio3()
    {
        try
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La suma es: {num1 + num2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese solo números enteros.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Fin del proceso.");
        }
    }
}
