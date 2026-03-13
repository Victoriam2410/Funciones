//Crear una función que reciba dos números y devuelva la suma de ambos.
Console.WriteLine("ingrese dos numero \n");
Console.WriteLine("ingrese numero uno");
int numero1= int.Parse(Console.ReadLine());
Console.WriteLine("ingrese numero dos");
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine($"la usma es: {Sumar(numero1, numero2)}");
int Sumar (int a, int b)
{
    return a + b;
}