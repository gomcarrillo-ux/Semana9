// puntajes de partidas, puntaje mas alto, ordenamiento y mayores a 500
int[] puntajes = new int[6];
int contadorMayores500 = 0;

for (int i = 0; i < puntajes.Length; i++)
{
    Console.WriteLine($"Ingrese el puntaje de la partida {i + 1}:");
    puntajes[i] = int.Parse(Console.ReadLine()!);
}
int puntajeMaximo = puntajes[0];
for (int i = 0; i < puntajes.Length; i++)
{
    if (puntajes[i] > puntajeMaximo)
    {
        puntajeMaximo = puntajes[i];
    }
    if (puntajes[i] > 500)
    {
        contadorMayores500++;
    }
}
Array.Sort(puntajes);
Console.WriteLine("RESULTADOS");
Console.WriteLine($"Cantidad de puntajes mayores a 500: {contadorMayores500}");
Console.WriteLine($"El puntaje más alto es: {puntajeMaximo}");
Console.WriteLine("Puntajes ordenados de menor a mayor:");
for (int i = 0; i < puntajes.Length; i++)
{
    Console.WriteLine(puntajes[i]);
}
