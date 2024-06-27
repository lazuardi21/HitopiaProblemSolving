// using System;
// using System.Collections.Generic;

// public class Solution2
// {
//     public static string IsBalanced(string brackets)
//     {
//         if (string.IsNullOrEmpty(brackets))
//             return "YES"; 

//         Dictionary<char, char> matchingBrackets = new Dictionary<char, char>
//         {
//             { '(', ')' },
//             { '{', '}' },
//             { '[', ']' }
//         };

//         Stack<char> stack = new Stack<char>();

//         foreach (char bracket in brackets)
//         {
//             if (bracket == '(' || bracket == '{' || bracket == '[')
//             {
//                 stack.Push(bracket);
//             }
//             else if (bracket == ')' || bracket == '}' || bracket == ']')
//             {
//                 if (stack.Count == 0){
//                     return "NO"; 
//                 }

//                 char top = stack.Pop();
//                 if (!matchingBrackets.ContainsKey(top) || matchingBrackets[top] != bracket)
//                 {
//                     return "NO"; 
//                 }
//             }
//         }
        
//         return stack.Count == 0 ? "YES" : "NO";
//     }

//     public static void Main()
//     {
//         string example1 = "{[()]}";
//         string example2 = "{[(])}";
//         string example3 = "{(([])[])[]}";
        

//         Console.WriteLine(IsBalanced(example1)); // Output: YES
//         Console.WriteLine(IsBalanced(example2)); // Output: NO
//         Console.WriteLine(IsBalanced(example3)); // Output: YES
//     }
// }