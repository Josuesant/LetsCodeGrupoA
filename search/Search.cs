using System;

namespace LetsCodeGrupoA.search
{
    public static class Search
    {
        public static int[] elementos = new int[10];
        public static void LinearSearch(int numero) {
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == numero)
                {
                    Console.WriteLine("Busca feita com sucesso " + "O número " + elementos[i] + " foi encontrado no índice " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Busca falhou...");
                }
            }
        }

        public static void BinarySearch(int numero) {
            int baixo = 0;
            int alto = elementos.Length - 1;

            while (baixo <= alto)
            {
                int medio = (baixo + alto) / 2;

                if (numero < elementos[medio])
                {
                    alto = medio - 1;
                }
                else if (numero > elementos[medio])
                {
                    baixo = medio + 1;
                }
                else if (numero == elementos[medio])
                {
                    Console.WriteLine("Busca feita com sucesso " + "O número " + numero + " foi encontrado no índice " + medio);
                    break;
                }
            }
        }
    }
}