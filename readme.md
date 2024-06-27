Question 2 

Balanced Brackets Algorithm

Complexity Analysis

A. Time Complexity
    O(n): The algorithm's runtime increases linearly with the size of the input string n. This means checking a string twice as long will take roughly twice as much time.

Explanation

1. Iterating Through String: 
    The algorithm examines each character in the string exactly once using a loop (foreach
(char c in s)). This loop runs n times because 𝑛 is the string's length.

2. Operations Inside the Loop:

    Operations like pushing and popping from a stack (used to track brackets) are quick and don't slow down as the stack grows.

3. Final Check:

    After checking all characters, a quick verification ensures all opened brackets have corresponding closures. This check also runs in constant time.

B. Space Complexity

    O(n): The algorithm's memory usage grows linearly with the size of the input string n.

Explanation

1. Stack Usage:

    The algorithm employs a stack to manage open brackets. In the worst case, if all brackets are open and none are closed, the stack might hold all 𝑛 characters of the string.

2. Dictionary:

    A dictionary pairs opening and closing brackets, consuming a fixed amount of memory because it always contains the same entries (like a small list).

3. Additional Memory:

    Besides the string, the algorithm uses a bit more memory for stack operations and dictionary management, but this extra memory doesn't increase as the string lengthens.

Conclusion
This algorithm efficiently verifies if a string of brackets is balanced:

    It runs in 𝑂(𝑛) time, ensuring fast performance even with large strings.
    It uses 𝑂(𝑛) memory in the worst scenario, demonstrating efficiency.

These features make it ideal for checking balanced brackets across different string lengths and bracket types.