using EjerciciosPOO3.Ejercicio01;
Console.WriteLine("Hello, World!");

Console.WriteLine("pulse cualquier tecla para continuar");
var x =Console.ReadKey();

while (x.Key != ConsoleKey.Enter)
{
    Console.WriteLine("ingrese que ejercicio desea ejecutar");
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
    Console.WriteLine("pulse cualquier tecla para continuar");
    x =Console.ReadKey();
}

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

static void EjercutarEjercicio2()
{
    Console.WriteLine("Ejercicio 2");
}
