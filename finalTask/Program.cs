string[] array = new string[6] { "Hel", "lo", "World!", ":)", "1121212", "1124" };
int len = 3;
string[] sortArray;
Console.Clear();
PrintArray(SortWords(array, len));

/* Простой вывоод на печать при помощи String.Join
Console.WriteLine($"[{String.Join(",", SortWords(array, len))}]"); */

/* Метод сортировки введеного пользователем массива и формирование нового массива, согласно
заданным условиям */
string[] SortWords(string[] array, int len)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= len)
        {
            temp++;
        }
    }

    string[] sortArray = new string[temp];
    temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= len)
        {
            sortArray[temp++] = array[i];
        }
    }
    return sortArray;
}
