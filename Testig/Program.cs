
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

// 4. Пишем программу.

bool Answer(int[] arrey)
{
    bool answer = WhetherArrayGrowing(arrey);
    if (answer == false)
    {
        int numberToDelete = FindNumberToDelete(arrey);
        List<int> secondArrey = DeleteNumber(arrey, numberToDelete);
        answer = WhetherDynamicArrayGrowing(secondArrey);
    }
    return answer;
}

// 3. Напишем метод по нахождению лишнего числа.

int FindNumberToDelete(int[] arrey)
{
    int deleteNumber = 0;
    bool endCicle = false;
    for (int i = 0; i < arrey.Length - 1; i++)
    {
        if (i == arrey.Length - 2 || endCicle == true)
        {
            if (i >= i + 1)
            {
                deleteNumber = i + 1;
            }
            break;
        }
        else
        {
            if (i >= i + 1)
            {
                if (i >= i + 2)
                {
                    deleteNumber = i;
                    endCicle = true;    
                }
                else deleteNumber = i + 1;
            }
        }
    }
    return deleteNumber;
}

// 2. Напишем метод по копированию массива без выбранного элемента.

List<int> DeleteNumber(int[] arrey, int deleteNumber)
{
    List<int> copyArrey = new List<int>();
    for (int i = 0; i < arrey.Length; i++)
    {
        i = arrey[i];
        if (deleteNumber != i)
        {
            copyArrey.Add(arrey[i]);
        }
    }
    return copyArrey;
}

// 1. Напишем метод по определению, возрастающий массив или нет.

bool WhetherArrayGrowing(int[] arrey)
{
    bool impressive = true;
    for (int i = 0; i < arrey.Length - 1; i++)
    {
        if (arrey[i] >= arrey[i + 1])
        {
            impressive = false;
            break;
        }
    }
    return impressive;
}

bool WhetherDynamicArrayGrowing(List<int> arrey)
{
    bool impressive = true;
    int lenght = arrey.Count;
    for (int i = 0; i < lenght - 1; i++)
    {
        if (arrey[i] >= arrey[i + 1])
        {
            impressive = false;
            break;
        }
    }
    return impressive;
}




int[] arrey = { 1, 1, 1 }; // тут лишняя 36 (условием нахождения 36 будет, что предыдущее значение >= следующего и надо удалить предыдущее значение)

Console.WriteLine(Answer(arrey));
