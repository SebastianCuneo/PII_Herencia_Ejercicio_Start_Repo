namespace Library;

public class User
{
    // Propiedades de la clase
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cedula { get; set; }
 
 
    
    // Constructor
    public User(string nombre, string cedula, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
        Cedula = cedula; 
    }
}