using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {


        string[] words = new string[3] {"Man","People","World" };
        Random rnd = new Random();
        int num = rnd.Next(1, 3);
        string secretWord = words[num];

        //test to make sure only letters
        bool wordTest = secretWord.All(Char.IsLetter);

        while (wordTest == false || secretWord.Length == 0)
        {
            Console.WriteLine("A word must contain (only) letters");
            Console.Write("Please enter a word: ");
            secretWord = Console.ReadLine();
            wordTest = secretWord.All(Char.IsLetter);
        }


        secretWord = secretWord.ToUpper();

        int lives = 5;
        int counter = -1;
        int wordLength = secretWord.Length;
        char[] secretArray = secretWord.ToCharArray();
        char[] printArray = new char[wordLength];
        char[] guessedLetters = new char[26];
        int numberStore = 0;
        bool victory = false;

        foreach (char letter in printArray)
        {
            counter++;
            printArray[counter] = '_';
        }

        while (lives > 0)
        {
            counter = -1;
            string printProgress = String.Concat(printArray);
            bool letterFound = false;
            int multiples = 0;

            if (printProgress == secretWord)
            {
                victory = true;
                break;
            }

            if (lives > 1)
            {
                Console.WriteLine("You have {0} lives!", lives);
            }
            else
            {
                Console.WriteLine("You only have {0} life left!!", lives);
            }


            Console.WriteLine("Word: " + printProgress);
            Console.Write("\n\n\n");
            Console.Write("Guess: ");
            string playerGuess = Console.ReadLine();

            //test to make sure a single letter
            bool guessTest = playerGuess.All(Char.IsLetter);

            while (guessTest == false || playerGuess.Length != 1)
            {
                Console.WriteLine("Please enter only a single letter!");
                Console.Write("Guess a letter: ");
                playerGuess = Console.ReadLine();
                guessTest = playerGuess.All(Char.IsLetter);
            }

            playerGuess = playerGuess.ToUpper();
            char playerChar = Convert.ToChar(playerGuess);

            if (guessedLetters.Contains(playerChar) == false)
            {

                guessedLetters[numberStore] = playerChar;
                numberStore++;

                foreach (char letter in secretArray)
                {
                    counter++;
                    if (letter == playerChar)
                    {
                        printArray[counter] = playerChar;
                        letterFound = true;
                        multiples++;
                    }

                }

                if (letterFound)
                {
                    Console.WriteLine("Found {0} letter {1}!", multiples, playerChar);
                }
                else
                {
                    Console.WriteLine("No letter {0}!", playerChar);
                    lives--;
                }
                Console.WriteLine(GallowView(lives));
            }
            else
            {
                Console.WriteLine("You already guessed {0}!!", playerChar);
            }


        }


        if (victory)
        {
            Console.WriteLine("\n\nThe word was: {0}", secretWord);
            Console.WriteLine("\n\nYOU WIN!!!!!!!!!!!");
        }
        else
        {
            Console.WriteLine("\n\nThe word was: {0}", secretWord);
            Console.WriteLine("\n\nYOU LOSE!!!!!!!!!");
        }

    }


    private static string GallowView(int livesLeft)
    {
        //print out the hangman

        string drawHangman = "";

        if (livesLeft < 5)
        {
            drawHangman += "--------\n";
        }
        else if (livesLeft < 4)
        {
            drawHangman += "       |\n";
        }
        else if (livesLeft < 3)
        {
            drawHangman += "       O\n";
        }
        else if (livesLeft < 2)
        {
            drawHangman += "      /|\\ \n";
        }
        else if (livesLeft == 0)
        {
            drawHangman += "      / \\ \n";
        }
         return drawHangman;
    }




}