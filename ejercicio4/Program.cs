// ventas por categoría, total de libros, categoría con más ventas y promedio
int[] ventas = new int[5];
int total = 0;
double promedio = 0;
for (int i = 0; i < ventas.Length; i++)
{
    Console.WriteLine($"Ingrese la cantidad de libros vendidos en la categoría {i + 1}:");
    ventas[i] = int.Parse(Console.ReadLine()!);
}
for (int i = 0; i < ventas.Length; i++)
{
    total += ventas[i];
}

promedio = (double)total / ventas.Length;
int categoriaMasVendida = ventas[0];
int indiceCategoria = 1;
for (int i = 0; i < ventas.Length; i++)
{
    if (ventas[i] > categoriaMasVendida)
    {
        categoriaMasVendida = ventas[i];
        indiceCategoria = i + 1; 
    }
}

Console.WriteLine("RESULTADOS");
Console.WriteLine($"Total de libros vendidos: {total}");
Console.WriteLine($"Promedio de ventas por categoría: {promedio:F2}");
Console.WriteLine($"La categoría con más ventas es la número {indiceCategoria} (con {categoriaMasVendida} libros vendidos gracias uwu)");