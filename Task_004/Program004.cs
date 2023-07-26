//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина 
//  которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//  коллекциями, лучше обойтись исключительно массивами.



string[] CreateArray (string arr)
{
    string[] inputArray = new string[arr.Length];
    inputArray = arr.Split(" ");
    return inputArray;
}


string[] SortArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simbol = array[i];
        if (simbol.Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            newArray[j] = simvol;
            j++;
        }
    }
    return newArray;
}
void Print(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.WriteLine("]");
}
Console.Write("Enter massive's elements throw spase >>> ");
string arr = Console.ReadLine();
string[] inputArray = CreateArray(arr);
Console.WriteLine();
Console.Write("Massive >>> ");
Print(inputArray);
Console.Write("New Massive >>> ");
Print(SortArray(inputArray));
