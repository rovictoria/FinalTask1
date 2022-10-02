void PrintArray(string[] array)
{
    int i;
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }

    Console.WriteLine(array[i]);
}

string[] ElementsLengthThreeAndLessArray(string[] array)
{
    int k = 0;
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[k] = array[i];
            k++;
        }
    }
    string[] emptyResult = new string[] {"there are no such values", "try again"};
    if(newArray.Length == 0) return emptyResult;
    else return newArray;
}

//Для наглядности решила вывести сразу все варианты:
 
string[] first = new string[] { "hello", "2", "world", ":-)" };
PrintArray(first);
Console.Write($"Result: ");
PrintArray(ElementsLengthThreeAndLessArray(first));

string[] second = new string[] { "1234", "1567", "-2", "computer science" };
PrintArray(second);
Console.Write($"Result: ");

PrintArray(ElementsLengthThreeAndLessArray(second));

string[] third = new string[] { "Russia", "Denmark", "Kazan"};
PrintArray(third);
Console.Write($"Result: ");
PrintArray(ElementsLengthThreeAndLessArray(third));
