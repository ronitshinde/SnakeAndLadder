

namespace SnakeAndLadder
{
     public class RollsTheDie
    {
        public static void FirstTime()
        {
                Random random = new Random();
                int dice_number = random.Next(1, 7);
                Console.WriteLine(dice_number);
        }
    }
}
