using System;

namespace LetsCodeGrupoA.search
{
    public static class Search
    {
        public static int LinearSearch(int[] elements, int number) {
            for (int i = 0; i < elements.Length; i++)            
                if (elements[i] == number)
                    return i;                        
            
            throw new Exception("Busca falhou...");
        }

        public static int BinarySearch(int[] elements, int numero) {
            int baixo = 0;
            int alto = elements.Length - 1;

            while (baixo <= alto)
            {
                int medio = (baixo + alto) / 2;

                if (numero < elements[medio])
                    alto = medio - 1;
                else if (numero > elements[medio])
                    baixo = medio + 1;
                else if (numero == elements[medio])                
                    return medio;                
            }

            throw new Exception("Busca falhou...");
        }
    }
}