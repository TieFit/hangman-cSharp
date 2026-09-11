using System;
using System.Collections.Generic;

public class Program
{
    static List<char> guesses = new();
    static string secretWord = "apple";

    public static void Main()
    {
        while (true)
        {
            int revealedLetters = GenerateWord();

            if (revealedLetters == secretWord.Length)
            {
                Console.WriteLine("\nCongratulations, you guessed the word!");
                break;
            }

            Console.Write("\nGuess a letter: ");
            char guess = char.ToLower(Console.ReadLine()[0]);

            if (!guesses.Contains(guess))
            {
                guesses.Add(guess);
            }
            Console.WriteLine();
        }
    }

    public static int GenerateWord()
    {
        int revealedLetters = 0;

        foreach (char letter in secretWord)
        {
            if (guesses.Contains(letter))
            {
                Console.Write(letter + " ");
                revealedLetters++;
            }
            else
            {
                Console.Write("_ ");
            }
        }
        return revealedLetters;
    }
}