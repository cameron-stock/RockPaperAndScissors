using System;

namespace RockPaperAndScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;


            string inputUser, inputPc;
            int randomInt;


            bool playAgain = true;

            while (playAgain)
            {

                int userScore = 0;
                int pcScore = 0;





                while (userScore < 3 && pcScore < 3)
                {



                    Console.WriteLine("Choose bewtween ROCK, PAPER and SCISSORS: ");
                    inputUser = Console.ReadLine();
                    inputUser = inputUser.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputPc = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputUser == "ROCK")
                            {
                                Console.WriteLine("It's a draw!\n\n");
                            }
                            else if (inputUser == "PAPER")
                            {
                                Console.WriteLine("Player wins!\n\n");
                                userScore++;
                            }
                            else if (inputUser == "SCISSORS")
                            {
                                Console.WriteLine("Computer wins!\n\n");
                                pcScore++;
                            }
                            break;

                        case 2:
                            inputPc = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputUser == "ROCK")
                            {
                                Console.WriteLine("Computer wins!\n\n");
                                pcScore++;
                            }
                            else if (inputUser == "PAPER")
                            {
                                Console.WriteLine("It's a draw!\n\n");
                            }
                            else if (inputUser == "SCISSORS")
                            {
                                Console.WriteLine("Player wins!\n\n");
                                userScore++;
                            }
                            break;

                        case 3:
                            inputPc = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputUser == "ROCK")
                            {
                                Console.WriteLine("Player wins!\n\n");
                                userScore++;
                            }
                            else if (inputUser == "PAPER")
                            {
                                Console.WriteLine("Computer wins!\n\n");
                                pcScore++;
                            }
                            else if (inputUser == "SCISSORS")
                            {
                                Console.WriteLine("It's a draw!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;

                    }
                    Console.WriteLine("\n\nScores:\tPlayer:\t{0}\tComputer:\t{1}\t", userScore, pcScore);
                }

                if (userScore == 3)
                {
                    Console.Write("Player won!");
                }
                else if (pcScore == 3)
                {
                    Console.Write("Computer won!");

                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(Y/N)");
                string loop = Console.ReadLine();
                if (loop == "Y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "N")
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                }
                else
                {
                    Console.WriteLine("Invalid entry!");
                }

            }
            }
        }
}
