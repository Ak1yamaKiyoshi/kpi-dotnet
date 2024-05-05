using System;


namespace Program {


    // Task 4
    class HexStringToIntTask
    {
        public static void Main()
        {
            Console.Write("Enter a hexadecimal string: ");
            string hexString = Console.ReadLine();

            try
            {
                int result = HexStringToIntConverter.HexStringToInt(hexString);
                Console.WriteLine($"Integer value: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // Task 11
    class SentenceWordCaseTask
    {
        public static void Main()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            try
            {
                string result = SentenceWordCaseConverter.ConvertWordsToLowerCase(sentence);
                Console.WriteLine($"Converted sentence: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    // Converter classes
    class HexStringToIntConverter
    {
        public static int HexStringToInt(string hexString)
        {
            if (string.IsNullOrEmpty(hexString))
                throw new ArgumentNullException(nameof(hexString), "Hexadecimal string cannot be null or empty.");

            int result = 0;
            foreach (char c in hexString)
            {
                if (!IsValidHexDigit(c))
                    throw new ArgumentException($"Invalid hexadecimal character: '{c}'");

                result = (result << 4) + HexDigitToInt(c);
            }

            return result;
        }

        private static bool IsValidHexDigit(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f');
        }

        private static int HexDigitToInt(char c)
        {
            if (c >= '0' && c <= '9')
                return c - '0';
            else if (c >= 'A' && c <= 'F')
                return c - 'A' + 10;
            else // c >= 'a' && c <= 'f'
                return c - 'a' + 10;
        }
    }

    class SentenceWordCaseConverter
    {
        public static string ConvertWordsToLowerCase(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                throw new ArgumentNullException(nameof(sentence), "Sentence cannot be null or empty.");

            string result = "";
            bool isWord = false;
            string currentWord = "";

            foreach (char c in sentence)
            {
                if (char.IsLetterOrDigit(c))
                {
                    isWord = true;
                    currentWord += c;
                }
                else
                {
                    if (isWord)
                    {
                        result += IsDigitOnly(currentWord) ? currentWord : currentWord.ToLower();
                        isWord = false;
                        currentWord = "";
                    }

                    result += c;
                }
            }

            // Handle the last word
            if (isWord)
                result += IsDigitOnly(currentWord) ? currentWord : currentWord.ToLower();

            return result;
        }

        private static bool IsDigitOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
    }



    class Program
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Convert hexadecimal string to integer");
                Console.WriteLine("2. Convert words in a sentence to lowercase");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HexStringToIntTask.Main();
                        break;
                    case "2":
                        SentenceWordCaseTask.Main();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}