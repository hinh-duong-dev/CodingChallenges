namespace CodingChallenges
{
    public static class RevertArray
    {
        public static int[] Revert(int[] array)
        {

            int left = 0;
            int right = array.Length - 1;

            for (int i = 0; i < array.Length/2; i++)
            {
                var temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }

            return array;
        }
    }
}
