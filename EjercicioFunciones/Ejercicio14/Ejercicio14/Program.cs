//Crear una función que reciba la distancia recorrida y el tiempo empleado y devuelva la velocidad promedio.
Console.Write("Ingrese la distancia recorrida ");
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese el tiempo empleado");
double tiempo = double.Parse(Console.ReadLine());
Console.WriteLine($"la velocidad promedio es: {VelocidadPromedio (distancia,tiempo)}");
double VelocidadPromedio(double d, double t)
{
    return d / t;
}