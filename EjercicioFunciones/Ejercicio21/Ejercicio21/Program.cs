// Crear un procedimiento que muestre en pantalla un mensaje de bienvenida al usuario.
Console.WriteLine("Ingrese su nombre: ");
string usuario = Console.ReadLine();
Console.WriteLine(Bienvenida(usuario));
string Bienvenida(string nombre)
{
    return $"Bienvenido al sistema: {nombre}";
}