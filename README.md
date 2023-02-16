# FinaTaskBlock1

## Решение задачи состоит из трех этапов: ##
1. Сортировка массива, введенного пользователем, согласно заданным условиям;
2. Формирование нового массива, кторый будет включать только отсортированные эелменты;
3. Вывод массива на печать.

**Первый шаг**
Для сортировки массива объявляем пустой массив *string[] sortArray*, который в последующем заполним необходимыми элементами, удовлетворяющих условию задачи, вводим переменную *int len = 3*, которая будет отвечать за ограничение длины элементов в массиве, создаем метод *string[] SortWords(string[] array, int len)*, которому в качестве аргументов будем передовать введенный пользователем массив, а также длину элементов массива, по которой будет осуществляться сортировка. Метод по сортировке массива условно разбиваем на два этапа: 
- выполнить подсчет элементов массива, длина которых удовлетворяет условиям задачи (для этого вводим переменную *int temp = 0*, которая будет выступать в виде счетчика, далее проходимся при помощи цикла for *(int i = 0; i < array.Length; i++)* по элементам массива и проверяем условие *if (array[i].Length <= len)* , если условие удовлетворяется то увеличиваем счетчик на единицу *temp++*, если нет  - переходим к проверке следующего элемента массива);
- второй этап заключается в формировании нового массива *string[] sortArray = new string[temp]*, которому задаем длину, только что найденного значения *[temp]*. Для этого обнуляем длину массива *temp = 0*, проходимся вновь при помощи цикла for  по массиву введенного пользователем *(int i = 0; i < array.Length; i++)*, проверяем условие *if (array[i].Length <= len)*, если условие удовлетворяется, выполняем замену элементов пр помощи присваивания *sortArray[temp++] = array[i]*; проходимся по всем элементам массива и возвращаем по итогу *return sortArray*.

**Второй шаг**
Осуществляем вывод массива на печать при помощи метода *void PrintArray(string[] arr)*. Для этого в качестве аргумента метода закладываем массив (будем при выводе задавать вновь созданный массив), при помощи цикла *for (int i = 0; i < arr.Length; i++)* проходимся по массиву и при помощи тернарного оператора *i + 1 != arr.Length ? $"{arr[i]}," : $"{arr[i]}"* проверяем последний элемент массива или нет, после последнего  - запятую не ставим.