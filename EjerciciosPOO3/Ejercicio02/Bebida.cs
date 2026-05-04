namespace EjerciciosPOO3.Ejercicio02;

public abstract class Bebida
{
        public string Nombre {get;set;}
        public double Precio {get;set;}

        public Bebida(string nombre, double precio)
    {
        if (Precio <= 0)
        {
            throw new ArgumentException("El precio no puede ser menor o igual a cero");
        }

        Nombre=nombre;
        Precio=precio;
    }

    public abstract string Preparar();
    public string MostrarPrecio()
    {
        return $"El precio de {Nombre} es: {Precio}";
    }
}