// Crear una función que reciba el precio de varios productos y devuelva el total de la compra.
Console.Write("Cuántos productos desea ingresar? ");
int cantidad = int.Parse(Console.ReadLine());

double total = TotalCompra(cantidad);

Console.WriteLine($"El total de la compra es: {total}");

double TotalCompra(int c)
{
    double t = 0;
    for (int i = 0; i < c; i++)
    {
        Console.Write("Ingrese el precio: ");
        double precio = double.Parse(Console.ReadLine());
        t += precio;
    }
    return t;
}