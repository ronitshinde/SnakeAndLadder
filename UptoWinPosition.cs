
namespace SnakeAndLadder
{
    public class UptoWinPosition
    {
        public static void TillHundred()
        {
            int Player_position = 0;
            int No_Play = 0;
            while (Player_position <= 100)

            {
                Random random = new Random();
                int Dice_No = random.Next(1, 7);
                Console.WriteLine("Number on dice : " + Dice_No);

                Random random1 = new Random();
                int option = random1.Next(1, 4);
                Console.WriteLine("Number of option " + option);



                if (option == 1)        //Moves ahead
                {
                    Player_position = Player_position + Dice_No;
                    Console.WriteLine("Player position moves ahead by {0} : {1}", Dice_No, Player_position);
                }

                else if (option == 2)       //Moves behind
                {
                    Player_position = Player_position - Dice_No;

                    if (Player_position < 0)
                    {
                        Player_position = 0;
                        Console.WriteLine("Player starts again from 0 position");
                    }

                    Console.WriteLine("Player position moves behind by {0} : {1}", Dice_No, Player_position);
                }

                else                   //No play
                {
                    Player_position = Player_position + No_Play;
                    Console.WriteLine("Player position remain same : " + Player_position);
                }
            }
        }
    }
}
