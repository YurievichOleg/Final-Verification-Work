//**Задача**: Написать программу, которая из имеющегося массива целых чисел формирует 
//массив из четных чисел. Первоначальный массив можно ввести с клавиатуры, 
//либо сгенерировать случайным образом. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


int[] array = new int[new Random().Next(1,10)];

void FillArray(int[] col)
{
    int lenght = col.Length;
    int index = 0;
    while(index < lenght)
    {
        col[index]= new Random().Next(1,100);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
     while(position < count)
     {
        Console.WriteLine(collection[position]);
        position++;
     }
}

int[] Even(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
    }
    if(count == 0)
    {
        Console.WriteLine("Четных нет.");
    
    }
    int[] even_arr = new int [count];
    int a = 0;
    for(int j = 0; j < arr.Length; j++)
    {
        if(arr[j] % 2 == 0)
        {
            even_arr[a] = arr[j];
            a++;
        }
    }
    return even_arr;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(Even(array));