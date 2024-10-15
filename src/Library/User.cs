namespace Library;

public class User
{
    // Propiedades de la clase
    public string Nombre { get; set; }
    public string CorreoElectronico { get; set; }
    public List<string> Roles { get; private set; }

    // Constructor
    public User(string nombre, string correoElectronico)
    {
        Nombre = nombre;
        CorreoElectronico = correoElectronico;
        Roles = new List<string>();
    }
}