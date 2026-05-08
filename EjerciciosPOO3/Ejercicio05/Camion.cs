namespace EjerciciosPOO3.Ejercicio05;

public class Camion : VehiculoEj03
{
    public int CargaMaxima {get;set;}

    public Camion(string patente, int anio, EstadoVehiculo estado, int cargaMaxima) : base(patente, anio, estado)
    {
        CargaMaxima = cargaMaxima;
    }
}