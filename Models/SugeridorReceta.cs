namespace Tp02_Moguelevsky_Sisro.Models;

public class SugeridorReceta
{
    public string nombre { get; set; }
    public DateTime fechaNacimiento { get; set; }
    public string tipoComida { get; set; }
    public string presupuesto { get; set; }
    public int cantidadComensales { get; set; }
}
public SugeridorReceta()
{

}
public SugeridorReceta(string Nombre,DateTime fechaNacimiento, string tipoComida, string presupuesto, int cantidadComensales)
{
    this.nombre = nombre;
    this.fechaNacimiento = fechaNacimiento;
    this.tipoComida = tipoComida;
    this.presupuesto = presupuesto;
    this.cantidadComensales = cantidadComensales;
}
public int CalcularEdad()
{
 int edad = fechaNacimiento - DateTime.Today;
 return edad;
}
