using System;

class Program
{
    // Develop a solution that achieves O(log(n)) time complexity
    // Linear searches generally have O(n)
    // Binary search is preferable since it generally takes O(log(n)) time 
    public static void Main(string[] args)
    {
        // Generate a sorted array of integer pairs, and a lone integer that must be identified

        // The outlier is 7
        int[] smallArray = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 };
        // The outlier is 4
        int[] medArray = { 1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16 };
        // The outlier is 37
        int[] largeArray = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17, 18, 18, 19, 19, 20, 20, 21, 21, 22, 22, 23, 23, 24, 24, 25, 25, 26, 26, 27, 27, 28, 28, 29, 29, 30, 30, 31, 31, 32, 32, 33, 33, 34, 34, 35, 35, 36, 36, 37, 38, 38, 39, 39, 40, 40, 41, 41, 42, 42, 43, 43, 44, 44, 45, 45, 46, 46, 47, 47, 48, 48, 49, 49, 50, 50 };

        Console.WriteLine(FindUnpaired(smallArray));
        Console.WriteLine(FindUnpaired(medArray));
        Console.WriteLine(FindUnpaired(largeArray));
    }

    public static int FindUnpaired(int[] arr)
    {
        // Check if an unpaired element even exists in this array
        if (arr.Length % 2 == 0) return -1;

        // Check the first and last elements
        if (arr[0] != arr[1]) return arr[0];
        if (arr[arr.Length - 1] != arr[arr.Length - 2]) return arr[arr.Length - 1];

        int lower = 0;
        int upper = arr.Length - 1;

        while (lower <= upper)
        {
            int mid = (lower + upper) / 2;

            // Check if the mid element is the lone element
            if (mid > 0 && arr[mid] != arr[mid - 1] && mid < arr.Length - 1 && arr[mid] != arr[mid + 1])
            {
                return arr[mid];
            }

            // Determine if we should go left or right
            if (mid % 2 == 0)
            {
                if (arr[mid] == arr[mid + 1])
                {
                    lower = mid + 2;
                }
                else
                {
                    upper = mid - 1;
                }
            }
            else
            {
                if (arr[mid] == arr[mid - 1])
                {
                    lower = mid + 1;
                }
                else
                {
                    upper = mid - 2;
                }
            }
        }

        return -1;
    }
}
