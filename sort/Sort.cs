using System;
using System.Collections.Generic;

namespace LetsCodeGrupoA.sort
{
    public static class Sort
    {
        public static int[] elementos = new int[5];
        public static void InsertionSort()
        {

            int temp, j;
            for (int i = 1; i < elementos.Length; i++)
            {
                temp = elementos[i];
                j = i - 1;

                while (j >= 0 && elementos[j] > temp)
                {
                    elementos[j + 1] = elementos[j];
                    j--;
                }

                elementos[j + 1] = temp;
            }
        }

        public static void Quicksort(int[] elementos, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elementos[(left + right) / 2];

            while (i <= j)
            {
                while (elementos[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elementos[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = elementos[i];
                    elementos[i] = elementos[j];
                    elementos[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(elementos, left, j);
            }

            if (i < right)
            {
                Quicksort(elementos, i, right);
            }
        }

        public static void DoMerge(int[] numeros, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elementos, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elementos = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (elementos[left] <= elementos[mid])
                    temp[tmp_pos++] = elementos[left++];
                else
                    temp[tmp_pos++] = elementos[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = elementos[left++];

            while (mid <= right)
                temp[tmp_pos++] = elementos[mid++];

            for (i = 0; i < num_elementos; i++)
            {
                elementos[right] = temp[right];
                right--;
            }
        }

        public static void MergeSort_Recursive(int[] numeros, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(elementos, left, mid);
                MergeSort_Recursive(elementos, (mid + 1), right);

                DoMerge(numeros, left, (mid + 1), right);
            }
        }

        public static void BubbleSort()
        {
            int temp;
            for (int pass = 1; pass <= elementos.Length - 1; pass++)
            {
                for (int i = 0; i <= elementos.Length - 2; i++)
                {
                    if (elementos[i] > elementos[i + 1])
                    {
                        temp = elementos[i + 1];
                        elementos[i + 1] = elementos[i];
                        elementos[i] = temp;
                    }
                }
            }
        }

        public static void ShellSort(int[] elementos)
        {
            int n = elementos.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = elementos[j]; 

                    while (j - gap >= 0 && temp < elementos[j - gap]) 
                    {
                        elementos[j] = elementos[j - gap];
                        j = j - gap;
                    }

                    elementos[j] = temp;
                }
                gap = gap / 2;
            }
        }
    }
}