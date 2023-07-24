//Inicializa el menu



class Program{
    static bool a=true;
    static List<string[]> arr = new List<string[]>();
    static void Main(){
        Console.WriteLine(menu());
        agregar();
        mostrarDatos();
    }
    static string  menu(){
    string menu = "**** Menu ****\n1.Agregar.\n2.Eliminar.\n3.Ver lista.\n4.Editar.\n5.Salir.";
    return menu;
}
static void agregar(){

    Console.Write("Ingrese su nombre completo: ");
    string nombre= Console.ReadLine();
    Console.Write("Ingrese su telefono: ");
    string telefono= Console.ReadLine();
    Console.WriteLine($"Su nombre es: {nombre} y su telefono es: {telefono}");
    //arr.Add(new string[] {nombre,telefono});
}
static string mostrarDatos(){
    arr.ForEach(e => {
        foreach(string i in e ){
            Console.WriteLine(i);
        }
    });
    return "holis";
}   

}

//Funciones

