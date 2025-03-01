using System;

class Program
{
    static string registeredUsername = "";
    static string registeredPassword = "";
    static int highScore = 0;
    static string highScorePlayer = "";

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registro e inicio de sesión");
            Console.WriteLine("2. Manejo de puntajes del juego");
            Console.WriteLine("3. Salir");
            Console.Write("Opción: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Register();
                    Login();
                    break;
                case "2":
                    Console.Write("Ingrese el puntaje obtenido: ");
                    int score = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el nombre del jugador: ");
                    string player = Console.ReadLine();
                    UpdateScore(score, player);
                    break;
                case "3":
                    exit = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void Register()
    {
        Console.WriteLine("Registro de Usuario");
        Console.Write("Ingrese un nombre de usuario: ");
        registeredUsername = Console.ReadLine();

        Console.Write("Ingrese una contraseña: ");
        registeredPassword = Console.ReadLine();

        Console.WriteLine("Registro exitoso!\n");
    }

    static void Login()
    {
        Console.WriteLine("Inicio de Sesión");
        Console.Write("Ingrese su nombre de usuario: ");
        string username = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string password = Console.ReadLine();

        if (username == registeredUsername && password == registeredPassword)
        {
            Console.WriteLine("Inicio de sesión exitoso. Bienvenido, " + username + "!");
        }
        else
        {
            Console.WriteLine("Error: Nombre de usuario o contraseña incorrectos.");
        }
    }

    static void UpdateScore(int score, string player)
    {
        if (score > highScore)
        {
            highScore = score;
            highScorePlayer = player;
            Console.WriteLine("La nueva puntuación más alta es " + highScore);
            Console.WriteLine("La puntuación más alta fue lograda por " + highScorePlayer);
        }
        else
        {
            Console.WriteLine("La puntuación más alta de " + highScore + " no se ha podido superar, y aún está en manos de " + highScorePlayer);
        }
    }
}
