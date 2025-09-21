using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
        int[,] g =
        {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
        bool ok = Level3.CountAdjacent(g, 1, 1) == 4
               && Level3.CountAdjacent(g, 0, 0) == 2;
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level3
{
    public static int CountAdjacent(int[,] matriz, int fila, int columna)
    {
        int cantidad = 0;
        int totalFilas = matriz.GetLength(0);
        int totalColumnas = matriz.GetLength(1);

        if (fila - 1 >= 0 && matriz[fila - 1, columna] == 1)
            cantidad++;

        if (fila + 1 < totalFilas && matriz[fila + 1, columna] == 1)
            cantidad++;

        if (columna - 1 >= 0 && matriz[fila, columna - 1] == 1)
            cantidad++;

        if (columna + 1 < totalColumnas && matriz[fila, columna + 1] == 1)
            cantidad++;

        return cantidad;
    }
}