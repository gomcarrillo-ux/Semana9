// ventas diarias, total vendido, ventas superiores a 150 y venta minima
double[] ventas = new double[7];
double totalVendido = 0;
int contadorVentasAltas = 0;

for (int i = 0; i < ventas.Length; i++)
{
    Console.WriteLine($"Ingrese la venta del día {i + 1}:");
    ventas[i] = double.Parse(Console.ReadLine()!);
}

for (int i = 0; i < ventas.Length; i++)
{
    totalVendido += ventas[i];
   if (ventas[i] > 150)
    {
        contadorVentasAltas++;
    }
}
double ventaMinima = ventas[0];
for (int i = 0; i < ventas.Length; i++)
{
    if (ventas[i] < ventaMinima)
    {
        ventaMinima = ventas[i];
    }
}

Console.WriteLine("RESULTADOS");
Console.WriteLine($"El total vendido es: {totalVendido}");
Console.WriteLine($"Días con ventas mayores a 150: {contadorVentasAltas}");
Console.WriteLine($"La venta más baja registrada es: {ventaMinima}");
