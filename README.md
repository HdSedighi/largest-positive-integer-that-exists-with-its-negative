# Intuition
The problem asks to find the largest positive integer k such that its negative counterpart −𝑘 exists in the given integer array. A straightforward approach is to use a hash set to efficiently track the presence of each integer in the array. By using a hash set, we can easily check if a given integer k and its negative counterpart −k both exist in the array. We just need to iterate through the array, and for each positive integer k, check if −k exists in the hash set. This will allow us to efficiently find the largest positive integer k with its negative counterpart in the array.

# Approach
1. Create a hash set to store the elements from the given integer array. This allows for constant time lookups for any integer in the set.
2. Initialize a variable largestK with a value of -1 to track the largest positive integer k that has a negative counterpart in the array.
3. Iterate through each integer in the array:
If the integer is positive and its negative counterpart exists in the hash set, update largestK if the current integer is larger than the existing largestK.
4. After iterating through the array, return the value of largestK, which will be the largest positive integer k with its negative counterpart in the array, or -1 if no such integer exists.

# Complexity
- Time complexity:
The time complexity of the algorithm is O(n), where n is the length of the integer array. This is because we iterate through the array once and perform constant time operations (adding to and checking the hash set) for each element.
- Space complexity:
The space complexity of the algorithm is O(n), where n is the length of the integer array. This is because we use a hash set to store all elements from the array, and in the worst case, the hash set could contain all elements of the array.
