
using System.Net;

namespace Assignment4
{
    class Assignment4
    {

        public static void Main(string[] args)
        {

            string texts = File.ReadAllText("D:\\assignment3.txt");
            string[] textArray = File.ReadAllLines("D:\\assignment3.txt");

            // Word Count
            int wordCount = 0;
            int sentenceCount = 0;
            foreach (string text in textArray)
            {
                wordCount += text.Split(' ').Length;
                sentenceCount += texts.Split(" [!?.:]+").Length;
            }
            Console.WriteLine("Total No. of Words:" + wordCount);
            Console.WriteLine("Total No. of Sentence:" + sentenceCount);

            //Console.WriteLine($"Total No of Line in text is {texts.Split('\r').Length}");  // total line
            //Console.WriteLine($"Total No of word in text is {texts.Split(' ').Length}"); // total word


            // No. of Vowels
            int j, textLength, vowel;
            vowel = 0;
            textLength = texts.Length;
            for (j = 0; j < textLength; j++)
            {
                if (texts[j] == 'a' || texts[j] == 'e' || texts[j] == 'i' || texts[j] == 'o' || texts[j] == 'u' || texts[j] == 'A' || texts[j] == 'E' || texts[j] == 'I' || texts[j] == 'O' || texts[j] == 'U')
                {
                    vowel++;
                }
            }
            Console.WriteLine($"Total No. of Vowels : {vowel}");


            // Special Characters
            int specialChars = System.Text.RegularExpressions.Regex.Matches(texts, "[~!@#$%^&*()_+{}:\"<>?';,]").Count;
            Console.WriteLine($"Total No. of Special Chacter: {specialChars}");
        }
    }
}
