using System;

namespace Palindrome
{
    internal class Program
    {
        public bool Palindrome(string? word) {
            if (string.IsNullOrEmpty(word)) {
                return false;
            }

            bool isPalindrome = true;
            for (int i = 0; i < word.Length; i++) {
                if (word[i] != word[word.Length - 1 - i]) {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }

        static void Main(string[] args) {
            Console.WriteLine("What word would you like to check...");
            string? word = Console.ReadLine();
            Program program = new Program();
            bool result = program.Palindrome(word);

            if (result) {
                Console.WriteLine("Word is a palindrome");
            }
            else {
                Console.WriteLine("Word is not a palindrome");
            }
        }
    }
}