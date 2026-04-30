namespace EjerciciosPOO3.Ejercicio01;
using System.Collections.Generic;

public class Auto:Vehiculo
{
    public int CantPuertas {get;set;}
    public List<Auto> ListaAutos {get;set;}

    public Auto(string marca, string modelo, int anio, int cantPuertas):base(marca, modelo, anio)
    {
        Marca=marca;
        Modelo=modelo;
        Anio=anio;
        CantPuertas=cantPuertas;
        ListaAutos = new List<Auto>();
    }

    public override string Describir()
    {
        return base.Describir()+ $", cantidad de peurtas {CantPuertas}";
    }
}