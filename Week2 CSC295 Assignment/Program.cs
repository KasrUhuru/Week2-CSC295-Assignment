using System;

class Program
{
    // Develop a solution that achieves O(log(n)) time complexity
    // Linear searches generally have 0(n)
    // Binary search is preferable since it generally takes O(log(n)) time 
    public static void Main(string[] args)
    {
        // Generate a sorted array of integer pairs, and a lone integer that must be identified
        int[] sortArray = [1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9];
        FindUnpaired(sortArray);
    }

    public static int FindUnpaired(int[] arr)
    {
        // Initialize INT variable to collect target integer
        int target;

        // First, check if an unpaired element even exists in this array
        if (arr.Length % 2 == 0) { target = -1; }

        // Given that I already know this is a SORTED array, this gives me clues about how to
        // handle edge cases. I can check to see if arr[0] == arr[1], and if arr[arr.Length - 1]
        // is equal to arr[arr.Length - 2]. If either of these return FALSE, then I have found the
        // lone integer.
        if (arr[0] != arr[1]) { target = arr[0];}
        if (arr[arr.Length - 1] != arr[arr.Length -2]) { target = arr[arr.Length - 1];}

        // The indeces 

        return target;
    }

}