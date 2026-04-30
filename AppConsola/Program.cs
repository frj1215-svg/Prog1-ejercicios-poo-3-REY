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

        default:
            Console.WriteLine("Ejercicio no econtrado");
        break;
    }
}

static void EjecutarEjercicio1()
{
    Console.WriteLine("cuantos autos desea cargar");
    var cantAutos=Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < cantAutos; i++)
    {
       Console.WriteLine("ingrese la marca");
       var marca=Console.ReadLine();
       Console.WriteLine("ingrese el modelo");
       var modelo=Console.ReadLine();
       Console.WriteLine("ingrese el anio");
       var anio=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("ingrese la cant de puertas");
       var cantPuertas=Convert.ToInt32(Console.ReadLine());

        Auto auto  =new Auto(marca, modelo, anio, cantPuertas);
    }
}