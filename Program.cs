Console.Write($"Введите масив через пробел: ");
string[] array1 =  Console.ReadLine()!.Split(' ', ' ', ' ', '.');
string[] array2 = new string[array1.Length];

void Array1(string[] array1, string[] array2)
{
    int count = 0;
    int m = 3;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= m)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}   

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.Write($"{array[array.Length - 1]}");
}
    int m = 3;
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= m)
        {
        count++;
        }
    }
Array.Resize(ref array2, count);

try
{ Array1(array1, array2);
Console.Write("[");
PrintArray(array2);
}
catch
{
    Console.Write($"");
}
Console.WriteLine("]");