namespace Tp02_Moguelevsky_Sisro.Models;

public class SugeridorReceta
{
    public string nombre { get; set; }
    public DateTime fechaNacimiento { get; set; }
    public string tipoComida { get; set; }
    public string presupuesto { get; set; }
    public int cantidadComensales { get; set; }
}

public int CalcularEdad()
{
 int edad = fechaNacimiento - DateTime.Today;
 return edad;
}
