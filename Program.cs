using System;

class Program
{
    static string[] artistas = new string[100];
    static string[] titulos = new string[100];
    static int[] duraciones = new int[100];
    static int[] tamanos = new int[100];
    static int totalCanciones = 0;

    static string[] codigos = new string[100];
    static string[] nombres = new string[100];
    static DateTime[] fechasNacimiento = new DateTime[100];
    static string[] grados = new string[100];
    static int[] añosRegistro = new int[100];
    static int totalAlumnos = 0;

    static string[] codigosLibros = new string[100];
    static string[] titulosLibros = new string[100];
    static string[] autoresLibros = new string[100];
    static int[] añosPublicacionLibros = new int[100];
    static int totalLibros = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Gestionar Canciones");
            Console.WriteLine("2. Gestionar Alumnos");
            Console.WriteLine("3. Gestionar Libros");
            Console.WriteLine("4. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    GestionarCanciones();
                    break;
                case 2:
                    GestionarAlumnos();
                    break;
                case 3:
                    GestionarLibros();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    static void GestionarCanciones()
    {
        while (true)
        {
            Console.WriteLine("Menú de Gestión de Canciones:");
            Console.WriteLine("1. Agregar Canción");
            Console.WriteLine("2. Mostrar Canciones");
            Console.WriteLine("3. Volver al Menú Principal");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarCancion();
                    break;
                case 2:
                    MostrarCanciones();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    static void AgregarCancion()
    {
        Console.WriteLine("Ingresa los datos de la canción tigre:");

        Console.Write("Artista: ");
        artistas[totalCanciones] = Console.ReadLine();

        Console.Write("Título: ");
        titulos[totalCanciones] = Console.ReadLine();

        Console.Write("Duración (en segundos): ");
        duraciones[totalCanciones] = int.Parse(Console.ReadLine());

        Console.Write("Tamaño del fichero (en KB): ");
        tamanos[totalCanciones] = int.Parse(Console.ReadLine());

        totalCanciones++;
    }

    static void MostrarCanciones()
    {
        Console.WriteLine("Listado de Canciones:");
        Console.WriteLine("Artista\t\tTítulo\t\tDuración\tTamaño (KB)");

        for (int i = 0; i < totalCanciones; i++)
        {
            Console.WriteLine($"{artistas[i]}\t\t{titulos[i]}\t\t{duraciones[i]}\t\t{tamanos[i]}");
        }
    }

    static void GestionarAlumnos()
    {
        while (true)
        {
            Console.WriteLine("Menú de Gestión de Alumnos:");
            Console.WriteLine("1. Agregar Alumno");
            Console.WriteLine("2. Mostrar Alumnos");
            Console.WriteLine("3. Volver al Menú Principal");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAlumno();
                    break;
                case 2:
                    MostrarAlumnos();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    static void AgregarAlumno()
    {
        Console.WriteLine("Ingresa los datos del alumno papu:");

        Console.Write("Código: ");
        codigos[totalAlumnos] = Console.ReadLine();

        Console.Write("Nombre completo: ");
        nombres[totalAlumnos] = Console.ReadLine();

        Console.Write("Fecha de nacimiento (yyyy-mm-dd): ");
        fechasNacimiento[totalAlumnos] = DateTime.Parse(Console.ReadLine());

        Console.Write("Grado: ");
        grados[totalAlumnos] = Console.ReadLine();

        Console.Write("Año de registro: ");
        añosRegistro[totalAlumnos] = int.Parse(Console.ReadLine());

        totalAlumnos++;
    }

    static void MostrarAlumnos()
    {
        Console.WriteLine("Listado de Alumnos:");
        Console.WriteLine("Código\t\tNombre\t\tFecha Nacimiento\tGrado\tAño Registro");

        for (int i = 0; i < totalAlumnos; i++)
        {
            Console.WriteLine($"{codigos[i]}\t\t{nombres[i]}\t\t{fechasNacimiento[i]:yyyy-MM-dd}\t{grados[i]}\t{añosRegistro[i]}");
        }
    }

    static void GestionarLibros()
    {
        while (true)
        {
            Console.WriteLine("Menú de Gestión de Libros:");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Mostrar Libros");
            Console.WriteLine("3. Buscar Libro por Código");
            Console.WriteLine("4. Editar Información de un Libro por Código");
            Console.WriteLine("5. Volver al Menú Principal");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarLibro();
                    break;
                case 2:
                    MostrarLibros();
                    break;
                case 3:
                    BuscarLibroPorCodigo();
                    break;
                case 4:
                    EditarLibroPorCodigo();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    static void AgregarLibro()
    {
        Console.WriteLine("Ingresealos datos del libro fiera:");

        Console.Write("Código: ");
        codigosLibros[totalLibros] = Console.ReadLine();

        Console.Write("Título: ");
        titulosLibros[totalLibros] = Console.ReadLine();

        Console.Write("Autor: ");
        autoresLibros[totalLibros] = Console.ReadLine();

        Console.Write("Año de Publicación: ");
        añosPublicacionLibros[totalLibros] = int.Parse(Console.ReadLine());

        totalLibros++;
    }

    static void MostrarLibros()
    {
        Console.WriteLine("Listado de Libros:");
        Console.WriteLine("Código\t\tTítulo\t\tAutor\t\tAño de Publicación");

        for (int i = 0; i < totalLibros; i++)
        {
            Console.WriteLine($"{codigosLibros[i]}\t\t{titulosLibros[i]}\t\t{autoresLibros[i]}\t\t{añosPublicacionLibros[i]}");
        }
    }

    static void BuscarLibroPorCodigo()
    {
        Console.Write("Ingresa el código del libro a buscar: ");
        string codigoBuscado = Console.ReadLine();

        int indiceLibroEncontrado = -1;

        for (int i = 0; i < totalLibros; i++)
        {
            if (codigosLibros[i] == codigoBuscado)
            {
                indiceLibroEncontrado = i;
                break;
            }
        }

        if (indiceLibroEncontrado != -1)
        {
            Console.WriteLine("Libro encontrado bro:");
            Console.WriteLine($"Código: {codigosLibros[indiceLibroEncontrado]}");
            Console.WriteLine($"Título: {titulosLibros[indiceLibroEncontrado]}");
            Console.WriteLine($"Autor: {autoresLibros[indiceLibroEncontrado]}");
            Console.WriteLine($"Año de Publicación: {añosPublicacionLibros[indiceLibroEncontrado]}");
        }
        else
        {
            Console.WriteLine("Libro no encontrado intenta de nuevo crack.");
        }
    }

    static void EditarLibroPorCodigo()
    {
        Console.Write("Ingresa el código del libro a editar bro: ");
        string codigoBuscado = Console.ReadLine();

        int indiceLibroEncontrado = -1;

        for (int i = 0; i < totalLibros; i++)
        {
            if (codigosLibros[i] == codigoBuscado)
            {
                indiceLibroEncontrado = i;
                break;
            }
        }

        if (indiceLibroEncontrado != -1)
        {
            Console.WriteLine("Libro encontrado. Ingresa los nuevos datos crack:");

            Console.Write("Título: ");
            titulosLibros[indiceLibroEncontrado] = Console.ReadLine();

            Console.Write("Autor: ");
            autoresLibros[indiceLibroEncontrado] = Console.ReadLine();

            Console.Write("Año de Publicación: ");
            añosPublicacionLibros[indiceLibroEncontrado] = int.Parse(Console.ReadLine());

            Console.WriteLine("Libro editado exitosamente.");
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }
}
