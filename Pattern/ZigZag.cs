using System;
using System.Text;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    PrintZigZag("manasavesalaisanamazinggirlsoawesomethatsheisawonderwomansheisachamionofthesorts", 3);
  }

  public static void PrintZigZag3(string text) {
    int rowCount = 3;

    var sbList = new StringBuilder[rowCount];

    for(int i = 0; i < rowCount; i++) {
      sbList[i] = new StringBuilder();
    }

    for(int i = 0; i < text.Length; i++) {
      if (i % 4 == 1) {
        sbList[0].Append(text[i]);
      } else {
        sbList[0].Append(" ");
      }

      if (i % 2 == 0) {
        sbList[1].Append(text[i]);
      } else {
        sbList[1].Append(" ");
      }

      if (i % 4 == 3) {
        sbList[2].Append(text[i]);
      } else {
        sbList[2].Append(" ");
      }
    }

    for(int i = 0; i < rowCount; i++) {
      Console.WriteLine(sbList[i].ToString());
    }
  }

  public static void PrintZigZag(string text, int rowCount) {
    if (rowCount < 3) {
      throw new ArgumentException("minimum number of rows is: 3");
    }

    var sbList = new StringBuilder[rowCount];
    for(int i = 0; i < rowCount; i++) {
      sbList[i] = new StringBuilder();
    }

    int j = rowCount/2;
    bool increasing = false;
    for(int i = 0; i < text.Length; i++) {
      for(int k = 0; k < rowCount; k++){
        if (k == j){
          sbList[k].Append(text[i]);
        } else {
          sbList[k].Append(" ");
        }
      }

      if (increasing) {
        j++;
        if (j == rowCount) {
          increasing = false;
          j = rowCount - 2;
        }
      } else {
        j--;
        if (j < 0) {
          increasing = true;
          j = 1;
        }
      }
    }

    for(int i = 0; i < rowCount; i++) {
      Console.WriteLine(sbList[i].ToString());
    }
  }
}