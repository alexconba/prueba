Cliente miCliente = new("juan", "lee", 55532322, "barcelona", "juan89@gmail.com", true);
Console.WriteLine(miCliente);


public struct Cliente
{
    string name { get; set; }
    string lastName { get; set; }
    int phone { get; set; }
    string city { get; set; }
    string email { get; set; }
    bool  client { get; set; }

    public Cliente( string nombre, string apellido, int telefono, string ciudad, string _email, bool nuevoCliente)
    {
        name = nombre;

        lastName = apellido;
        phone = telefono;
        city = ciudad;
        email= _email;

        client = nuevoCliente;
    }

    public override string ToString() => $"({name}, {lastName}, {phone}, {city}, {email}, {client})";
}