//string [] array = new string [] {"hello", "2", "world", ";-)"};   // можно использовать готовый массив или ввести массив 
//самостоятельно с клавиатуры.

string GetUserData(string message)
{
    Console.WriteLine(message);
    string userData = Console.ReadLine()!;
    return userData;
}
string[] ResultArray(string[] array)
{
    int newLength = getNewLength(array);
    string[] result = new string[newLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}
int getNewLength(string[] array)
{
    int newLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newLength++;
        }
    }
    return newLength;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
string element = GetUserData("Введите значение");
string[] array = element.Split();
string[] result = ResultArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(result);

