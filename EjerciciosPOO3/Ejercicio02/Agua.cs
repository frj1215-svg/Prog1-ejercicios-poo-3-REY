using System.Threading.Channels;

namespace EjerciciosPOO3.Ejercicio02;
public class Agua : Bebida
{
    public bool TieneGas {get;set;}

    public Agua(string nombre, double precio, bool tieneGas) : base(nombre, precio)
    {
        TieneGas = tieneGas;
    }

    public override string Preparar()
    {
        return "Preparando agua";
    }

    public override double MostrarPrecio()
    {
        return Precio;
    }
}