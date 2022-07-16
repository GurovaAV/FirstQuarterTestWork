
string[] CreateArray(int size) // метод, позволяющий пользователю ввести необходимые строки в массив
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

string[] ArrayElementsSelect(string[] array1)  // метод, выбирающий элементы длиной 3 и менее символов из имеющегося массива и добавляющий их в новый массив
{
    int count = 0;
    string[] newArray = new string[array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 4)
        {
            newArray[count] = array1[i];
            count++;
        }
    }
    return newArray;
}

void ShowArray(string[] array) // метод, выводящий массив на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

Console.WriteLine("Введите размер массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(elements);
string[] newArray = ArrayElementsSelect(myArray);
ShowArray(myArray);
Console.Write("--> ");
ShowArray(newArray);

