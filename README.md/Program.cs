string[] array1 = { "hi", "hello", "not", "ran", "2", "good", "-x" };
string[] array2 = new string[3];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    
    int count = 0;
    for (int i = 0; i < 4; i++)
    {
    if(array1[i].Length <= 3)
        {
        int b = new Random().Next(0,array1.Length);
        array2[count] = array1[b];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);