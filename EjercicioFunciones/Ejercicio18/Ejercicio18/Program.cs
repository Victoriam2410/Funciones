// Crear una función que reciba la cantidad de productos comprados y el precio de cada uno y devuelva el total de la factura.
Console.Write("Cuántos productos compró? ");
int cantidad = int.Parse(Console.ReadLine());
Console.WriteLine($"el total de la factura es: {TotalFactura(cantidad)}");
double TotalFactura(int c)
{
    double total = 0;
    for (int i = 0; i < c; i++)
    {
        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());
        total += precio;
    }
    return total;
}