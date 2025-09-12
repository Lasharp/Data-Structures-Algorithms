namespace String_Array.Rotate_Array
{
    public class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k %= n;

            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, n - k);
        }
    }
}
