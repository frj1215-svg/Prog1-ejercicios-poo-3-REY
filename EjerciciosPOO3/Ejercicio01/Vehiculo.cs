namespace EjerciciosPOO3.Ejercicio01;

public class Vehiculo
{
        public string Marca {get;set;}
        public string Modelo {get;set;}
        public int Anio {get;set;}

        public Vehiculo (string marca, string modelo, int anio)
    {
        Marca=marca;
        Modelo=modelo;
        Anio=anio;
    }

}