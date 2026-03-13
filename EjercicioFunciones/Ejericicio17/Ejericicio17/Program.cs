//Crear una función que reciba la cantidad de estudiantes y la nota de cada uno y devuelva el promedio del grupo.
Console.Write("Ingrese la cantidad de estudiantes: ");
int cantidad = int.Parse(Console.ReadLine());

Console.WriteLine($"El promedio del grupo es: {Promedio(cantidad)}");

double Promedio(int c)
{
    double suma = 0;
    for (int i = 0; i < c; i++)
    {
        Console.Write("Ingrese la nota: ");
        double nota = double.Parse(Console.ReadLine());
        suma += nota;
    }
    return suma / c;
}