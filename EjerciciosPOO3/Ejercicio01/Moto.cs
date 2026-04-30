namespace EjerciciosPOO3.Ejercicio01;
using System.Collections.Generic;

public class Moto:Vehiculo
{
    public bool TieneSideCar{get;set;}
    public List<Moto> ListaMotos {get;set;}
    public Moto (string marca, string modelo, int anio, bool tieneSideCar)
    :base(marca, modelo, anio)
    {
        TieneSideCar=tieneSideCar;
        ListaMotos = new List<Moto>();
    }

    public override string Describir()
    {
        return base.Describir()+ $", tiene sidecar: {TieneSideCar}";
    }
}