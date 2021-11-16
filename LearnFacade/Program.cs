using LearnFacade.Classes;
using System;

namespace LearnFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            //input word1
            Console.WriteLine("Input your word1 (player1): ");
            var word1Player1 = Console.ReadLine().checkWord();
            
            player1.word1 = word1Player1;
            player1.word1 = player1.Word1();
            var last1 = word1Player1[word1Player1.Length - 1];
            Console.WriteLine($"Continue with char: {last1}");

            Console.WriteLine("Input your word1 (player2): ");
            string word1Player2 = Console.ReadLine().checkWord();
           


            if (!word1Player2.StartsWith(last1))
            {
                Console.WriteLine("Player 2 lose;");
            }
            else 
            {
                player2.word1 = word1Player2;
                player2.word1 = player2.Word1();
                
                var last2 = word1Player2[word1Player2.Length - 1];
                Console.WriteLine($"Continue with char: {last2}");

                //input word2
                Console.WriteLine("Input your word2 (player1): ");
                string word2Player1 = Console.ReadLine().checkWord();

                if (!word2Player1.StartsWith(last2))
                {
                    Console.WriteLine("Player 1 lose;");
                }
                else 
                {
                    player1.word2 = word2Player1;
                    player1.word2 = player1.WordN();
                    
                    var last3 = word2Player1[word2Player1.Length - 1];
                    Console.WriteLine($"Continue with char: {last3}");

                    Console.WriteLine("Input your word2 (player2): ");
                    string word2Player2 = Console.ReadLine().checkWord();

                    if (!word2Player2.StartsWith(last3))
                    {
                        Console.WriteLine("Play 2 lose in round 2;");
                    }
                    else 
                    {
                        player2.word2 = word2Player2;
                        player2.word2 = player2.WordZ();
                        
                        Console.WriteLine("End Game");
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("History of the game:");
            GameNextWord gameNextWord = new GameNextWord(player1, player2);
            GameMaster.GMCode(gameNextWord);

        }
    }
    public static class Extensions
    {

        public static string checkWord(this string strWord)
        {

            if (strWord.Length ==1 && strWord.StartsWith(" ")|| strWord.Length==1||strWord.Length==0)
            {
                
                return null;
            }
            else
            {

                return strWord;
            }

        }
       
    }
}
