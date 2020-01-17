/*
Given an integer, return reverse of that integer:
Input: 1234
Output: 4321
Input: -123
*/


using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(reversrInteger(-1234));
  }

  public static int reversrInteger(int num){
    int temp = num;
    int result = 0;
    if(num < 0)
    {
      num = -(num);
    }
    while(num > 0)
    {
      result = (result * 10) + num % 10;
      num = num / 10;
    }
    if(temp > 0)
    {
      return result;
    }
    else
    {
      return -result;
    }
  }
}