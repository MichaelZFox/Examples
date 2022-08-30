void Fillarrat(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
}
while(index < lenght)
{
    cillection[index] = new Random().Next(1, 10);
    index++;
}

void PrintArray(int[] collection);

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Writeline(col[position]);
        position++;
    }
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);