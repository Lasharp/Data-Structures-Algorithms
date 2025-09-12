namespace String_Array.Jump_Game
{
    public class JumpGame
    {
        public static bool CanJump(int[] nums)
        {
            int current = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= current)
                {
                    current = i;
                }
            }

            return current == 0;
        }
    }
}
