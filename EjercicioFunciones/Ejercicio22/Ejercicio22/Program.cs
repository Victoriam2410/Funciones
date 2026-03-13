// Crear un procedimiento que solicite el nombre de una persona y muestre un saludo personalizado.
SaludoPersonalizado();
void SaludoPersonalizado()
{
    Console.Write("Ingrese su nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}, un gusto saludarte.");
}