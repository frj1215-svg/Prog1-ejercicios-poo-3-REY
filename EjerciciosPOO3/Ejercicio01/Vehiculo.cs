namespace EjerciciosPOO3.Ejercicio01;
using System;
public class Vehiculo
{
        public string Marca {get;set;}
        public string Modelo {get;set;}
        public int Anio {get;set;}

        public Vehiculo (string marca, string modelo, int anio)
    {
        if (anio < 1900)
        {
            throw new ArgumentException("El año no puede ser menor a 1900");    
        }
        Marca=marca;
        Modelo=modelo;
        Anio=anio;
    }

    public virtual string Describir()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}";
    }

}