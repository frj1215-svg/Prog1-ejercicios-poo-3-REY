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
        if (TieneGas)
        {
            return "Preparando agua con gas";
        }
        else
        {
            return "Preparando agua sin gas";
        }
    }
}