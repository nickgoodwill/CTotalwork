﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. и
//  При решении не рекомендуется пользоваться коллекциям, 
//  лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];
array(stringArray);
printA(total(stringArray));

//--------------------------------

void array(string [] stringArray)
{
  for (int i = 0; i<stringArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     stringArray[i] = Console.ReadLine();
  }
}

string [] total(string [] stringArray)
{
  int n = 0;
  for (int i = 0; i<stringArray.Length; i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0; i<stringArray.Length; i++)
  {
    if(stringArray[i].Length <=3)
    {
        rez[j] = stringArray[i];
        j++;
    }
  }
  return rez;
}
void printA(string [] stringArray)
{
    Console.Write("[");
    for (int i = 0; i<stringArray.Length - 1; i++)
    {
      Console.Write(stringArray[i] + ", ");
    }
    Console.WriteLine(stringArray[stringArray.Length -1] + "]");
}


