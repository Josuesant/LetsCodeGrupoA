using System;
using System.Collections.Generic;

namespace LetsCodeGrupoA.sort
{
    public static class Sort
    {
        public static int[] InsertionSort(int[] elements)
        {
            int value, previousPosition;
            for (int i = 1; i < elements.Length; i++)
            {
                value = elements[i];
                previousPosition = i - 1;

                while (previousPosition >= 0 && elements[previousPosition] > value)
                {
                    elements[previousPosition + 1] = elements[previousPosition];
                    previousPosition--;
                }

                elements[previousPosition + 1] = value;
            }
            return elements;
        }

        public static int[] QuickSort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)               
                    i++;

                while (elements[j].CompareTo(pivot) > 0)
                    j--;                

                if (i <= j)
                {
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(elements, left, j);            

            if (i < right)
                QuickSort(elements, i, right);
            
            return elements;
        }

        public static void DoMerge(int[] elements, int left, int middle, int right)
        {
            int left_end = (middle - 1);
            int tmp_pos = left;
            int subarraySize = (right - left + 1);
            int[] temp = new int[elements.Length];

            while ((left <= left_end) && (middle <= right))
            {
                if (elements[left] <= elements[middle])
                    temp[tmp_pos++] = elements[left++];
                else
                    temp[tmp_pos++] = elements[middle++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = elements[left++];

            while (middle <= right)
                temp[tmp_pos++] = elements[middle++];

            for (int i = 0; i < subarraySize; i++)
            {
                elements[right] = temp[right];
                right--;
            }
        }

        public static int[] MergeSort_Recursive(int[] elements, int left, int right)
        {
            if (right > left)
            {
                int middle = (right + left) / 2;
                MergeSort_Recursive(elements, left, middle);
                MergeSort_Recursive(elements, (middle + 1), right);

                DoMerge(elements, left, (middle + 1), right);
            }
            return elements;
        }

        public static int[] BubbleSort(int[] elements)
        {
            int nextValue;
            for (int pass = 1; pass <= elements.Length - 1; pass++)
            {
                for (int i = 0; i <= elements.Length - 2; i++)
                {
                    if (elements[i] > elements[i + 1])
                    {
                        nextValue = elements[i + 1];
                        elements[i + 1] = elements[i];
                        elements[i] = nextValue;
                    }
                }
            }
            return elements;
        }

        public static int[] ShellSort(int[] elements)
        {
            int arraySize = elements.Length;
            int gap = arraySize / 2;
            int value;

            while (gap > 0)
            {
                for (int i = 0; i + gap < arraySize; i++)
                {
                    int lastPositionGap = i + gap;

                    int firstPositionGap = lastPositionGap - gap;

                    value = elements[lastPositionGap];

                    while (firstPositionGap >= 0 && value < elements[firstPositionGap]) 
                    {
                        elements[lastPositionGap] = elements[firstPositionGap];
                        lastPositionGap = firstPositionGap;
                        firstPositionGap--;
                    }

                    elements[lastPositionGap] = value;

                }
                gap = gap / 2;
            }
            return elements;

        }
    }
}