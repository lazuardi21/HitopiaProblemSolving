// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Solution1
// {
//     public static void Main()
//     {
//         // 1
//         string inputString1 = "abbcccd";
//         List<int> intLookFor1 = new List<int> { 1, 3, 9, 8 };

//         List<string> characters1 = inputString1.Select(c => c.ToString()).ToList();
//         List<int> characterValues1 = ConvertCharactersToIntegers(characters1);
//         List<string> arrAns1 = CheckCharacterValues(characterValues1, intLookFor1);
//         Console.WriteLine("Input: " + inputString1 + ", " + string.Join(",", intLookFor1));
//         Console.WriteLine("Output: [" + string.Join(", ", arrAns1) + "]");
//         Console.WriteLine();

//         // 2
//         string inputString2 = "hello";
//         List<int> intLookFor2 = new List<int> { 8, 5, 12, 15, 3 };

//         List<string> characters2 = inputString2.Select(c => c.ToString()).ToList();
//         List<int> characterValues2 = ConvertCharactersToIntegers(characters2);
//         List<string> arrAns2 = CheckCharacterValues(characterValues2, intLookFor2);
//         Console.WriteLine("Input: " + inputString2 + ", " + string.Join(",", intLookFor2));
//         Console.WriteLine("Output: [" + string.Join(", ", arrAns2) + "]");
//         Console.WriteLine();

//         // 3
//         string inputString3 = "programming";
//         List<int> intLookFor3 = new List<int> { 18, 15, 7, 20, 3 };

//         List<string> characters3 = inputString3.Select(c => c.ToString()).ToList();
//         List<int> characterValues3 = ConvertCharactersToIntegers(characters3);
//         List<string> arrAns3 = CheckCharacterValues(characterValues3, intLookFor3);
//         Console.WriteLine("Input: " + inputString3 + ", " + string.Join(",", intLookFor3));
//         Console.WriteLine("Output: [" + string.Join(", ", arrAns3) + "]");
//     }

//     public static List<int> ConvertCharactersToIntegers(List<string> characters)
//     {
//         List<int> alpInt = new List<int>();
//         string prevStr = "";
//         string curStr = "";

//         characters.Sort();

//         foreach (string u in characters)
//         {
//             if (prevStr == u)
//             {
//                 curStr += u;
//                 int totalCurStr = GetNumberFromString(curStr);
//                 alpInt.Add(totalCurStr);
//             }
//             else
//             {
//                 alpInt.Add(GetNumberFromString(u));
//                 curStr = u;
//             }
//             prevStr = u;
//         }

//         return alpInt;
//     }

//     public static List<string> CheckCharacterValues(List<int> characterValues, List<int> intLookFor)
//     {
//         List<string> arrAns = new List<string>();

//         foreach (int a in intLookFor)
//         {
//             if (characterValues.Contains(a))
//                 arrAns.Add("Yes");
//             else
//                 arrAns.Add("No");
//         }

//         return arrAns;
//     }

//     public static int GetNumberFromString(string s)
//     {
//         int total = 0;
//         foreach (char c in s)
//         {
//             int index = char.ToUpper(c) - 64;
//             total += index;
//         }
//         return total;
//     }
// }
