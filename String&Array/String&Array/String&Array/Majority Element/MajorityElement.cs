namespace String_Array
{
    public class Majority_Element
    {
        public static int MajorityElement(int[] nums)
        {
            int candidate = -1;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                    count++;
                    continue;
                }

                if (nums[i] == candidate) count++;
                else count--;
            }

            return candidate;
        }
    }
}
