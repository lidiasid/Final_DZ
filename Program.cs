//Решение задачи

void PrintArray(string[] newArray)
{
    Console.Write("[");

    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write("\"{0}\"", newArray[i]);
        if (i < newArray.Length - 1)
        {
            Console.Write(',');
        }
    }
    Console.Write("]");
}

string[] FormMass(string[] baseArray)
{
  int count = 0;
  for (int i =0; i < baseArray.Length; i++)
  {
    if (baseArray[i].Length <= 3)
    {
        count++;
    }
  }
  string[] newArray = new string[count];

  int index = 0;
  for (int i =0; i < baseArray.Length; i++)
  {
    if (baseArray[i].Length <= 3)
    {
      newArray[index] = baseArray[i];
      index++;
    }
  }
  return newArray;
}

string[] baseArray = { "cat", "!:)", "111111", "fish"};
string[] newArray = FormMass(baseArray);
PrintArray(newArray);


