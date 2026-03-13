// Crear un procedimiento que solicite la edad de una persona y muestre el año aproximado de nacimiento.
CalcularNacimiento();
void CalcularNacimiento()
{
    Console.Write("Ingrese el año actual: ");
    int Actual = int.Parse(Console.ReadLine());

    Console.Write("Ingrese su edad: ");
    int edad = int.Parse(Console.ReadLine());

    int nacimiento = Actual - edad;

    Console.WriteLine($"Su año aproximado de nacimiento es: {nacimiento}");
}
