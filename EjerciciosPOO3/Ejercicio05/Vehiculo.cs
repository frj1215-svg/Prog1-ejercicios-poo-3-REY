namespace EjerciciosPOO3.Ejercicio05;

    public enum EstadoVehiculo
    {
        Activo,
        EnMantenimiento,
    }

public class VehiculoEj03
{
    public string Patente {get;set;}
    public int Anio {get;set;}
    public EstadoVehiculo Estado{get;set;}

    public Vehiculo(string patente, int anio, EstadoVehiculo estado)
    {
        Patente = patente;
        Anio = anio;
        Estado = estado;
    }

}