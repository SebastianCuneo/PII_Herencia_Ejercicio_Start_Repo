namespace Library;

public class Driver : User
{
    public string Vehicle { get; set; }
    public int Qualification { get; set; }
    
    
    
    // Constructor
    public Driver(string nombre, string cedula, string apellido, string vehicle, int qualification): base(nombre, cedula, apellido)
    {
        Vehicle = vehicle;
        Qualification = qualification;
    }
}

