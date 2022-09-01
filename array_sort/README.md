Сортировка от минимального значения к максимальному 

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (arary[j] < array[minPosition]);
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = aray i[minPosition];
        array[minPosition] = temporary
    }
}