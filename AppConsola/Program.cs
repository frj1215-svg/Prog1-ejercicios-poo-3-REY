using EjerciciosPOO3.Ejercicio01;
using EjerciciosPOO3.Ejercicio02;
using System.Collections.Generic;
Console.WriteLine("Hello, World!");

Console.WriteLine("pulse cualquier tecla para continuar");
var x =Console.ReadKey();

while (x.Key != ConsoleKey.Enter)
{
    Console.WriteLine("ingrese que ejercicio desea ejecutar\\n");
    var EjercicioPrueba =Console.ReadLine();
    switch (EjercicioPrueba)
    {
        case "1":
            EjecutarEjercicio1();
        break;

        case "2":
            EjercutarEjercicio2();
        break;

        default:
            Console.WriteLine("Ejercicio no econtrado");
        break;
    }
    Console.WriteLine("pulse cualquier tecla para continuar\\n");
    x =Console.ReadKey();
}

//Ejercicio 1, Vehiculos    
static void EjecutarEjercicio1()
{
    List<Auto> autos = new List<Auto>();
    List<Moto> motos = new List<Moto>();
    
    //punto a, cargar al menos 2 motos y 2 autos
    Console.WriteLine("cuantos autos desea cargar");
    var cantAutos=Convert.ToInt32(Console.ReadLine());
    for (int a = 0; a < cantAutos; a++)
    {
        Console.WriteLine("ingrese la marca");
        var marcaAuto=Console.ReadLine();
        Console.WriteLine("ingrese el modelo");
        var modeloAuto=Console.ReadLine();
        Console.WriteLine("ingrese el anio");
        var anioAuto=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la cant de puertas");
        var cantPuertas=Convert.ToInt32(Console.ReadLine());

        Auto auto  =new Auto(marcaAuto, modeloAuto, anioAuto, cantPuertas);
        autos.Add(auto);
    }

    Console.WriteLine("cuantas motos desea cargar");
    var cantMotos=Convert.ToInt32(Console.ReadLine());
    for (int m = 0; m < cantMotos; m++)
    {
        Console.WriteLine("ingrese la marca");
        var marcaMoto=Console.ReadLine();
        Console.WriteLine("ingrese el modelo");
        var modeloMoto=Console.ReadLine();
        Console.WriteLine("ingrese el anio");
        var anioMoto=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("si tiene sidecar");
        var tieneSidecar=Convert.ToBoolean(Console.ReadLine());

        Moto moto =new Moto(marcaMoto, modeloMoto, anioMoto, tieneSidecar);
        motos.Add(moto);
    }

    Console.WriteLine("la lista de autos es:");
    foreach (var a in autos)
    {
        Console.WriteLine(a.Describir());
    }

    Console.WriteLine("la lista de motos es:");
    foreach (var m in motos)
    {
        Console.WriteLine(m.Describir());
    }
}
//Ejercicio 2, Bebidas
static void EjercutarEjercicio2()
{
    bool x= true;
    List<Bebida> Bebidas = new List<Bebida>();
    while (x)
    {
        
    Console.WriteLine("ingrese el tipo de bebida que desea preparar");
    Console.WriteLine("1- Cafe");
    Console.WriteLine("2- Jugo");
    Console.WriteLine("3- Agua");
    Console.WriteLine("4- Salir");
    var tipoBebida=Console.ReadLine();
    switch (tipoBebida){
        case "1":
            Console.WriteLine("ingrese el nombre del cafe");
            var nombreCafe=Console.ReadLine();
            Console.WriteLine("ingrese el precio del cafe");
            var precioCafe=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("si desea con leche");
            var tieneLeche=Convert.ToBoolean(Console.ReadLine());

                try
                {
                Cafe cafe = new Cafe(nombreCafe, precioCafe, tieneLeche);
                Bebidas.Add(cafe);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
        
   
        break;

        case "2":
        Console.WriteLine("ingrese nombre del jugo");
        var nombreJugo = Console.ReadLine();
        Console.WriteLine("ingrese el precio del jugo");
        var precioJugo=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ingrese la fruta de la que va a ser el jugo");
        var frutaJugo =Console.ReadLine();
        Jugo jugo=new Jugo(nombreJugo, precioJugo, frutaJugo);
        Bebidas.Add(jugo);

        break;

        case "3":
            Console.WriteLine("ingrese el nombre del agua");
            var nombreAgua=Console.ReadLine();
            Console.WriteLine("ingrese el precio del agua");
            var precioAgua=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("con gas?");
            var tieneGas=Convert.ToBoolean(Console.ReadLine());

            Agua agua =new Agua(nombreAgua,precioAgua, tieneGas);
            Bebidas.Add(agua);

        break;

        case "4":
            Console.WriteLine("saliendo");
            x=false;
        break;


        default:
            Console.WriteLine("opcion no valida");
            break;
    }
    Console.WriteLine("toque cualquier tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    }

}
