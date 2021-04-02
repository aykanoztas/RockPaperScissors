using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlayerAnswer,GameOver;
            bool PlayAgain = true;
            int CpuAnswer,CpuScore=0,PlayerScore=0;
            while (PlayAgain == true)
            {
                CpuScore = 0;
                PlayerScore = 0;
                while (CpuScore < 3 && PlayerScore < 3)
                {
                    Random rnd = new Random();
                    CpuAnswer = rnd.Next(1, 4);
                    Console.Write("\nChoose Player; Rock,Paper,Scissors ? = ");
                    PlayerAnswer = Console.ReadLine().ToLower();
                    if (PlayerAnswer == "rock" || PlayerAnswer == "scissors" || PlayerAnswer == "paper")
                    {
                        switch (CpuAnswer)
                        {
                            case 1://Cpu Choose = Rock 
                                Console.WriteLine("Computer Choose = Rock");
                                if (PlayerAnswer == "rock")
                                {
                                    Console.WriteLine("Draw !");
                                }
                                else if (PlayerAnswer == "paper")
                                {
                                    Console.WriteLine("Player Win This Round !");
                                    PlayerScore++;
                                }
                                else if (PlayerAnswer == "scissors")
                                {
                                    Console.WriteLine("Cpu Win This Round !");
                                    CpuScore++;
                                }
                                break;
                            case 2://Cpu Choose = Paper
                                Console.WriteLine("Computer Choose = Paper");
                                if (PlayerAnswer == "rock")
                                {
                                    Console.WriteLine("Cpu Win This Round !");
                                    CpuScore++;
                                }
                                else if (PlayerAnswer == "paper")
                                {
                                    Console.WriteLine("Draw !");
                                }
                                else if (PlayerAnswer == "scissors")
                                {
                                    Console.WriteLine("Player Win This Round !");
                                    PlayerScore++;
                                }
                                break;
                            case 3://Cpu Choose = Scissors
                                Console.WriteLine("Computer Choose = Scissors");
                                if (PlayerAnswer == "rock")
                                {
                                    Console.WriteLine("Player Win This Round !");
                                    PlayerScore++;
                                }
                                else if (PlayerAnswer == "paper")
                                {
                                    Console.WriteLine("Cpu Win This Round !");
                                    CpuScore++;
                                }
                                else if (PlayerAnswer == "scissors")
                                {
                                    Console.WriteLine("Draw !");
                                }
                                break;
                            default:
                                Console.WriteLine("Error.");
                                break;
                        }
                        if (PlayerScore == 3)
                        {
                            Console.WriteLine("Player Won !!");
                        }
                        else if (CpuScore == 3)
                        {
                            Console.WriteLine("CPU Won !!");
                        }
                        else
                        {                     
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer, Please Try Again");
                    }
                }
                Console.Write("Play Again ? (y/n) =");
                GameOver = Console.ReadLine().ToLower();
                if (GameOver == "y")
                {
                    PlayAgain = true;
                }
                else if (GameOver == "n")
                {
                    PlayAgain = false;
                }
            }            
        }
    }
}
