namespace EjerciciosPOO3.Ejercicio05;

public class Camion : Vehiculo
{
    public int CargaMaxima {get;set;}

    public Camion(string patente, int anio, EstadoVehiculo estado, int cargaMaxima) : base(patente, anio, estado)
    {
        CargaMaxima = cargaMaxima;
    }
}