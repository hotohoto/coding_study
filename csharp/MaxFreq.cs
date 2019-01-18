using System;
using System.Collections.Generic;

namespace MyNameSpace
{
  public class MaxFreq
  {
    public static void Main()
    {
      Dictionary<string,int> counter = new Dictionary<string, int>();

      Console.WriteLine("종료하려면 값을 입력하지 않고 엔터만 누르세요.");
      while (true)
      {
        Console.Write("입력 값: ");
        string s = Console.ReadLine();
        if (s == "")
        {
          break;
        }
          
        if (counter.ContainsKey(s))
        {
          counter[s] += 1;
        }
        else
        {
          // counter.Add(s, 1);
          counter[s] = 1;
        }
      }
        

      int maxCount = 0;
      string maxKey = null;

      foreach(KeyValuePair<string, int> keyValue in counter)
      {
          // Console.WriteLine(keyValue.Key, keyValue.Value)
          if (maxCount < keyValue.Value)
          {
            maxCount = keyValue.Value;
            maxKey = keyValue.Key;
          } 
      }

      Console.WriteLine("제일 많이 나온 값은 {0} 이며 {1}회 입니다.", maxKey, maxCount);
      Console.ReadKey();
    }
  }
}
