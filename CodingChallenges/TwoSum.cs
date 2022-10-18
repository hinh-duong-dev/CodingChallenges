using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    public static class TwoSum
    {
        public static int[] Find(int[] nums, int target)
        {
            var result = new int[2];

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var neededNum = target - nums[i];
                int indexOfNeedNum;

                bool isFoundNeedNum = dict.TryGetValue(neededNum, out indexOfNeedNum);

                if (isFoundNeedNum)
                {
                    result[0] = indexOfNeedNum;
                    result[1] = i;
                }

                if (!dict.ContainsValue(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return result;
        }
    }
}
