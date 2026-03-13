// Crear un procedimiento que solicite el nombre de un estudiante, su curso y tres calificaciones, y muestre un reporte simple con toda la información ingresada.
ReporteEstudiante();

void ReporteEstudiante()
{
    Console.WriteLine("Ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el curso: ");
    string curso = Console.ReadLine();

    Console.WriteLine("Ingrese la primera calificación: ");
    double n1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la segunda calificación: ");
    double n2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la tercera calificación: ");
    double n3 = double.Parse(Console.ReadLine());

    double promedio = (n1 + n2 + n3) / 3;
    Console.WriteLine("El reporte de estudiante es: ");
    Console.WriteLine($"Nombre: {nombre}");
    Console.WriteLine($"Curso: {curso}");
    Console.WriteLine($"Calificaciones: {n1}, {n2}, {n3}");
    Console.WriteLine($"Promedio Final: {promedio}");
}
