using System;
using System.Collections.Generic;

public class PositiveCountAndNegativeSum
{
  public static void Main(string[] args)
  {
    PositiveCountAndNegativeSum ob = new PositiveCountAndNegativeSum();
    int[] array = {1,2,3,-6,-8,-3};
    ob.CountAndSum(array);
    ob.MinAndMax(array);
  }
  public void CountAndSum(int[] array)
  {
    int count = 0;
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
      if(array[i] >= 0)
      {
        count += 1;
      }
      if(array[i] < 0)
      {
        sum += array[i];
      }
    }
    Console.WriteLine("count of positive numbers:" + count);
    Console.WriteLine("sum of negative numbers:" + sum);

  }

  public void MinAndMax(int[] array)
  {
    int min = array[0];
    int max = array[0];

    for(int i = 0; i < array.Length; i++)
    {
      if(array[i] > max)
      {
        max = array[i];
      }
      if(array[i] < min)
      {
        min = array[i];
      }
    }
    Console.WriteLine("Max and min numbers in given array: " + max + "," + min);
  }
}