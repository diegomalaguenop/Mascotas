#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace Mascotas.Models;

public class Mascota {
    public int Id {get; set;}
    public string Nombre {get; set;}
    public string Tipo {get; set;}
    public int Edad {get; set;}
    public Boolean Tiene_pelo {get; set;}
}