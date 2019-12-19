using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_JumpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.CanJump(new int[] { 5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0 }));
        }
    }

    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            var lowestValidIndex = nums.Length - 1;
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= lowestValidIndex) lowestValidIndex = i;
            }
        
            return lowestValidIndex == 0;
        }
    }

    /*public class Solution
    {
        public bool CanJump(int[] nums)
        {
            var i = 0;
            while (i < nums.Length - 1)
            {
                var furthestIndex = 0;
                var nextIndex = i;
                for (var j = i + 1; j <= i + nums[i]; j++)
                {
                    var tryIndex = j + nums[j];
                    if (tryIndex >= nums.Length - 1) return true;
                    if (tryIndex > furthestIndex)
                    {
                        furthestIndex = tryIndex;
                        nextIndex = j;
                    }
                }
                if (i == nextIndex) return false;
                i = nextIndex;
            }
            return true;
        }

    }*/
