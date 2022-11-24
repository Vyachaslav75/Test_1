int enterNumber(string msg, string errorMsg)
{
    int number;
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}

string[] fillArray()
{
    int N = enterNumber("Введите количество элементов массива:  ", "Введите целое число");
    string[] array = new string[N];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите строку:  ");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}


void PrintArray(string[] inArray)
{
    Console.Write("['{0}", string.Join("', '", inArray) + "'] -> ");
    string res = String.Empty;
    foreach (var i in inArray)
    {
        if (i.Length < 4)
        {
            if (res.Length > 1)
            {
                res = res + ", '" + i + "'";
            }
            else
            {
                res = "'" + i + "'";
            }
        }
    }
    Console.Write(res);
}


Console.Clear();
string[] array = fillArray();
PrintArray(array);