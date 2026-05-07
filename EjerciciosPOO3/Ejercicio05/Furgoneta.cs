namespace EjerciciosPOO3.Ejercicio05;

public class Furgoneta : Vehiculo
{
    public int CapacidadEnM3{get;set;}

    public Furgoneta (string patente, int anio,EstadoVehiculo estado, int capacidadEnM3):base(patente, anio,estado)
    {
        CapacidadEnM3 = capacidadEnM3;
    }
}