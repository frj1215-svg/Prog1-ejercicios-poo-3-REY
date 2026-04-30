namespace EjerciciosPOO3.Ejercicio01;

public class Auto:Vehiculo
{
    public int CantPuertas {get;set;}

    public Auto(string marca, string modelo, int anio, int cantPuertas):base(marca, modelo, anio)
    {
        Marca=marca;
        Modelo=modelo;
        Anio=anio;
        CantPuertas=cantPuertas;
    }
}