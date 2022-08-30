void FillArray(int[] collection)
{
    int lenght = collection.Lenght;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int [10]; //new int[10] создай новый массив в которой будет 10 эллементов 

FillArray(array);
PrintArray(array);