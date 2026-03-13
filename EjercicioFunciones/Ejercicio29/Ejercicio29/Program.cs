// Crear un procedimiento que solicite el número de estudiantes de un curso y muestre un mensaje indicando cuántos estudiantes hay en la clase.
ConteoEstudiantes();

void ConteoEstudiantes()
{
    Console.WriteLine("Cuántos estudiantes hay en el curso? ");
    int cantidad = int.Parse(Console.ReadLine());

    Console.WriteLine($"Hay un total de {cantidad} estudiantes en la clase.");
}