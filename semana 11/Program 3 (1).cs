class Program
{
    static void Main(string[] args)
    {

        int[] ventas = new int[5];
        int n, max = ventas[0], min = ventas[0];
        string e;
        for (int i = 0; i < 1; i++)
        {
            Console.Write("Ingresar la cantidad de adultos en el nivel 1: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar la cantidad de niños en el nivel 1: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar el nombre del responsable en el nivel 1: ");
            e = Console.ReadLine();
            ventas[i] = n;
        }
        for (int i = 1; i < 2; i++)
        {
            Console.Write("Ingresar la cantidad de personas en el nivel 2: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar la cantidad de niños en el nivel 2: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar nombre del responsable en el nivel 2: ");
            e = Console.ReadLine();
            ventas[i] = n;
        }
        for (int i = 2; i < 3; i++)
        {
            Console.Write("Ingresar la cantidad de personas en el nivel 3: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar la cantidad de niños en el nivel 3: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar nombre del responsable en el nivel 3: ");
            e = Console.ReadLine();
            ventas[i] = n;
        }
        for (int i = 3; i < 4; i++)
        {
            Console.Write("Ingresar la cantidad de personas en el nivel 4: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar la cantidad de niños en el nivel 4: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar el nombre del responsable en el nivel 4: ");
            e = Console.ReadLine();
            ventas[i] = n;
        }
        for (int i = 4; i < 5; i++)
        {
            Console.Write("Ingresar la cantidad de personas en el nivel 5: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar la cantidad de niños en el nivel 5: ");
            n = int.Parse(Console.ReadLine());
            ventas[i] = n;

            Console.Write("Ingresar el nombre del responsable en el nivel 5: ");
            e = Console.ReadLine();
            ventas[i] = n;
        }

        Console.Write("\n\nEl Nivel con mayor cantidad de niños contiene X cantidad de niños: " + ventas.Max());
        Console.Write("\n\nEl Responsable del nivel con mas cantidad de personas es: " + ventas.Max());

        Console.ReadKey();
    }
}

