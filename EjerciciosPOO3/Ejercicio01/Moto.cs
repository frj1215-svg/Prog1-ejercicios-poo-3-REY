namespace EjerciciosPOO3.Ejercicio01;

public class Moto:Vehiculo
{
    public bool TieneSideCar{get;set;}

    public Moto (string marca, string modelo, int anio, bool tieneSideCar)
    :base(marca, modelo, anio)
    {
        TieneSideCar=tieneSideCar;
    }
}