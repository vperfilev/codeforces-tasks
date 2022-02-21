using System;

namespace CodeforcesTasks.Tasks;

// https://leetcode.com/problems/rotate-array/
public static class ShiftArrayTask
{
    public static void Rotate(int[] nums, int k)
    {
        var arrayLen = nums.Length;
        k %= arrayLen;
        
        if (k == 0)
            return;
        
        var toRight = true;
        if (k > arrayLen / 2)
        {
            toRight = false;
            k = arrayLen - k;
        }

        var extraMem = new int[k];
        if (toRight)
        {
            Array.Copy(nums, arrayLen - k, extraMem, 0, k);
            Array.Copy(nums, 0, nums, k, arrayLen - k);
            Array.Copy(extraMem, 0, nums, 0, k);
        }
        else
        {
            Array.Copy(nums, 0, extraMem, 0, k);
            Array.Copy(nums, k, nums, 0, arrayLen - k);
            Array.Copy(extraMem, 0, nums, arrayLen - k, k);
        }
    }

    public static void Rotate2(int[] nums, int k)
    {
        k %= nums.Length;
        if (k == 0) return;
        
        Reverse(nums, 0, nums.Length - k - 1);
        Reverse(nums, nums.Length - k, nums.Length - 1);
        Reverse(nums, 0, nums.Length - 1);
    }

    private static void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
} 