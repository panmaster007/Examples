﻿int[] array = { 1, 12, 31, 4, 18, 16, 17, 18 };

int n = array.Length;
int find = 31;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
