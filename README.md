# Week2 CSC295 Assignment

This program is written according to the following guarantees: (1) the INT array is SORTED in ASCENDING order, (2) there are NO EMPTY cells, (3) ALL except ONE integer has a pair.
The goal of this program is to achieve O(log(n)) time complexity through a binary search adaptation. I want to avoid O(n) time complexity, therefore linear search is not viable.

My program will not have the luxury of having a TARGET value to search for. Therefore, I cannot evaluate array[mid] against a TARGET to determine the direction of the search.

The first thing I want to do is catch edge cases. This is a very easy task, and even makes me hope for them to avoid having to execute the Binary Search.
By checking to see if the first and second integers are equal, or if the last and second-to-last integers are equal, we can identify if either the FIRST or LAST element is the lone integer.

Challenge 1, Midpoint: The first issue I need to address is the possibility of creating a false lone integer as a result of cutting my array in half. Luckily, checking for an ordered pair at the array's natural midpoint eliminates this confusion and allows me to spot any integers of interest. However I need to account for this array being odd-numbered.
Checking at array[(array.Length)/2] will implicitly round down, which yields the TRUE midpoint of the odd-numbered array. Is it the lone integer? If so, checking both neighboring indeces with a != comparison will return TRUE and we will have found it.

This framework for checking edge and midpoint cases can be repeated indefinitely until the lone integer is found. However this leads to the next challenge.

Challenge 2, Direction: Which way do I go if I can't compare TARGET to array[mid]? First I consider the knowns. The midpoint is not the lone integer. If I look left or right,
the subarrays are of equal length, so I cannot do it that way. The key clue is which side arr[mid]'s twin is on. The first occurence of a pair is supposed to be on an even index.
So arr[mid+1] should == arr[mid]. If not, then arr[mid] is the second occurence in its pair and the pattern was disrupted to the left.

To make a more useful generalization...
if arr[mid] == arr[mid+1], then search to the right. Set the LOWER bound to arr[mid+2] to avoid flagging a false lone integer.
if arr[mid] != arr[mid+1], then search to the left. Set the UPPER bound to arr[mid-2] and execute the search again.

This program checks midpoints, edge cases, and index positions until the lone integer is found.
