﻿//Inicializa el menu



class Program
{
    static bool a = true;
    static List<string[]> arr = new List<string[]>();
    static void Main()
    {

        while (a)
        {
            Console.WriteLine(menu());
            Console.Write("/nSeleccione la opción que necesita: ");
            string dato = Console.ReadLine();
            if (dato == "1")
            {
                agregar();
            }
            else if (dato == "2")
            {

            }
            else if (dato == "3")
            {
                bool b=true;
                
                while (b){
                    Console.WriteLine(menuSec());
                    Console.Write("/nSeleccione la opción que necesita: ");
                    string dato2 = Console.ReadLine();
                    if (dato2 == "1"){
                        mostrarDatos();
                    }else if(dato2 == "2") {
                        b=false;
                    }
                }
            }
            else if (dato == "4")
            {

            }
            else if (dato == "5")
            {
                a = false;
            }
        }
    }
    //Funciones 
    //Menu principal
    static string menu()
    {
        string menu = "**** Menu ****\n1.Agregar.\n2.Eliminar.\n3.Ver lista.\n4.Editar.\n5.Salir.";
        return menu;
    }
    // Menu de listado
    static string menuSec()
    {
        string titulo = "**** Lista  ****\n1.Mostrar agenda.\n2.Regresar.";
        return titulo;
    }
    //Metodos del CRUD
    static void agregar()
    {

        Console.Write("Ingrese su nombre completo: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese su telefono: ");
        string telefono = Console.ReadLine();
        arr.Add(new string[] { nombre, telefono });
    }
    static void mostrarDatos()
    {
        Console.WriteLine("  Nombre        Telefono");
        for (int i = 0; i < arr.Count; i++)
        {
            string[] datos = arr[i];
            string nombre = datos[0];
            string telefono = datos[1];
            Console.WriteLine($"{i + 1}.{nombre}, Teléfono: {telefono}");
        }
    }
}