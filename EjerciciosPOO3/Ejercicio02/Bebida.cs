namespace EjerciciosPOO3.Ejercicio02;

public abstract class Bebida
{
        public string Nombre {get;set;}
        public double Precio {get;set;}

        public Bebida(string nombre, double precio)
    {
        Nombre=nombre;
        Precio=precio;
    }

    public abstract string Preparar();
    public abstract double MostrarPrecio();
        
}