
/*int count = 0;
int count2 = 0;
int count3 = 0;
int i = 0;
bool canIncreasing = false;

while (i < array.Length)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            count++;
        }
        if (array[i] == array[j])
        {
            count2++;
        }
    }
    if (count >= 2 || count2 >= 1)
    {
        count3++;
        count = 0;
        count2 = 0;
    }
    if (count3 >= 2)
    {
        canIncreasing = false;
        break;
    }
    i++;
}
if (count3 != 2)
{
    canIncreasing = true;
}
return canIncreasing;
*/

/* Дана задача. Есть массив случайных чисел. Нужно проверить будет ли он
возрастающим если убрать только одно из значений?

Given a 0-indexed integer array nums, return true if it can be made 
strictly increasing after removing exactly one element, or false 
otherwise. If the array is already strictly increasing, return true.
*/

// 1. Напишем метод по определению, возрастающий массив или нет.

bool WhetherArrayGrowing(int[] arrey)
{
    bool impressive = true;
    for (int i = 0; i < arrey.Length - 1; i++)
    {
        if (arrey[i] >= arrey[i + 1])
        {
            impressive = false;   
        }
    }
    return impressive;
}

// 2. Напишем метод по копированию массива без выбранного элемента.

List<int> DeleteNumber(int[] arrey, int deleteNumber)
{
    List<int> copyArrey = new List<int>();
    for (int i = 0; i < arrey.Length; i++)
    {
        int num = arrey[i];
        if (deleteNumber != arrey[i])
        {
            copyArrey.Add(num);
        }
    }
    return copyArrey;
}

// 3. Напишем метод по нахождению лишнего числа.


int[] arrey = { 1, 2, 36, 3, 4, 5, 6 }; // тут лишняя 36 (условием нахождения 36 будет, что предыдущее значение >= следующего и надо удалить предыдущее значение)
int[] arrey = { 1, 2, 36, 3, 37, 57, 67 }; // тут 3 (условием нахождения 3 будет, что предыдущее значение <= следующего и надо удалить следующее значение)
int[] arrey = { 1, 2, 36, 36, 4, 5, 6 }; // тут не решаемо
int[] arrey = { 1, 1, 2, 3, 4, 5, 6 }; // тут 1
int[] arrey = { 1, 2, 3, 5, 5, 6, 4 }; // тут 4



List<int> copyArrey = DeleteNumber(arrey, 36);
Console.Write($"[{String.Join(", ", arrey)}] -> ");
Console.Write($"[{String.Join(", ", copyArrey)}]");