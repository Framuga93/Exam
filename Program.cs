void PrintArray(string[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

string[] firstArray = { "Moscow", "Kaluga", "SPB" };
string[] secondArray = new string[firstArray.Length];
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        secondArray[i] = firstArray[i];
    }
}

PrintArray(secondArray);
