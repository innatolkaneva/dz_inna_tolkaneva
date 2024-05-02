
string [] CreateArrayStr(int len)
{  string [] listStr = new string[len];
    for (int i = 0; i < len; i++)
{
    listStr[i] = Console.ReadLine();
}
return listStr;
}
string [] listStr = CreateArrayStr(3);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
PrintArray(listStr);