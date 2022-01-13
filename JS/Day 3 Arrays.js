

/**
*   Return the second largest number in the array.
*   @param {Number[]} nums - An array of numbers.
*   @return {Number} The second largest number in the array.
**/
function getSecondLargest(nums) {
    // Complete the function
    nums = new Set(nums);
    nums = Array.from(nums);
    nums = nums.sort(function(a, b) {return a - b});
    return nums[nums.length - 2];
}

