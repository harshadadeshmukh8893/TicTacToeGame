namespace TicTacToeGame
{
    internal class Program
    {
        static int[] board = new int[9];
        static void Main(string[] args)
        {
            // int[] board = new int[9];
            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }

            int userTurn = -1;
            int SecondUser = -1;
           //Random random = new Random();

            while (checkForWinner() == 0)
            {
                //dont allow human to chose already occuipied square
                Console.WriteLine("Start the game!!");
               
                while (userTurn == -1 || board[userTurn] != 0)
                {
                    Console.WriteLine("User 1 turn...");
                    Console.WriteLine("please enter number between 0 to 8");
                    userTurn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("User 1  typed " + userTurn);
                }
                board[userTurn] = 1;

                if (isBoardFull())
                    break;

                //dont let computer pickinvalid number
                while (SecondUser == -1 || board[SecondUser] != 0)
                {
                    Console.WriteLine("Now user 2 turn...4");
                    Console.WriteLine("please enter number between 0 to 8");
                    SecondUser = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("user 2 typed " + SecondUser);


                }
                board[SecondUser] = 2;

                if (isBoardFull())
                    break;
                printboard();

            }
            Console.WriteLine(" The game is over..Player" + checkForWinner() + " won the game congratulations ");

        }

        public static bool isBoardFull()
        {
            bool isFull = true;

            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0)
                    isFull = false;
            }
            return isFull;
        }
        private static int checkForWinner()
        {
            //return 0 if nobody won return player number if they won

            //top row
            if (board[0] == board[1] && board[1] == board[2])
            {
                return board[0];
            }
            //second row
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }
            //third row
            if ((board[6] == board[7] && board[7] == board[8]))
            {
                return board[6];
            }
            //return 0;
            //1st column
            if ((board[0] == board[3] && board[3] == board[6]))
            {
                return board[0];
            }
            //second column
            if ((board[1] == board[4] && board[4] == board[7]))
            {
                return board[1];
            }
            //third column
            if ((board[2] == board[5] && board[5] == board[8]))
            {
                return board[2];
            }

            //first diagonal
            if ((board[0] == board[4] && board[4] == board[8]))
            {
                return board[0];
            }
            if ((board[2] == board[4] && board[4] == board[6]))
            {
                return board[2];
            }
            return 0;
        }

        private static void printboard()
        {
            //X and O for each square 
            //0 means unoccupied.1 is player 2 is computer

            for (int i = 0; i < 9; i++)
            {
                //  Console.WriteLine("Square" + i + "contains" + board[i]);
                if (board[i] == 0)
                {
                    Console.Write("  .  ");
                }
                if (board[i] == 1)
                {
                    Console.Write("  X  ");
                }
                if (board[i] == 2)
                {
                    Console.Write("  O  ");
                }
                //to print new line 
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}