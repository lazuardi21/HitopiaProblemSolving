// using System;

// public class HighestPalindrome
// {
//     public static string FindHighestPalindrome(string s, int k)
//     {
//         char[] arr = s.ToCharArray();
//         int left = 0;
//         int right = arr.Length - 1;

//         MakePalindrome(arr, left, right, k);
//         return new string(arr);
//     }

//     private static void MakePalindrome(char[] arr, int left, int right, int k)
//     {
//         if (left >= right)
//             return;

//         if (arr[left] != arr[right])
//         {
//             char maxChar = (char)Math.Max(arr[left], arr[right]);

//             if (maxChar != '9' && k > 0)
//             {
//                 arr[left] = '9';
//                 arr[right] = '9';
//                 k--;
//             }
//             else
//             {
//                 arr[left] = maxChar;
//                 arr[right] = maxChar;
//             }
//         }
//         else if (k >= 2 && arr[left] != '9')
//         {
//             arr[left] = '9';
//             arr[right] = '9';
//             k -= 2;
//         }

//         MakePalindrome(arr, left + 1, right - 1, k);
//     }

//     public static void Main()
//     {
//         Console.WriteLine(FindHighestPalindrome("A3943", 1)); 
//         Console.WriteLine(FindHighestPalindrome("53428", 1)); 
//         Console.WriteLine(FindHighestPalindrome("932239", 2));
//     }
// }
