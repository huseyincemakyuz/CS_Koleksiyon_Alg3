using System;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = {'a','e','ı','i','o','ö','u','ü'};

            Console.WriteLine("Lütfen bir cümle yazınız:");
            string sentence = Console.ReadLine().ToLower();

            List<char> vowelsChars = new List<char>(){};

            for(int i=0;i<sentence.Length;i++)
            {
                if(vowels.Contains(sentence[i]))
                {
                    vowelsChars.Add(sentence[i]);
                }
            }

            Console.WriteLine("Sesli harfler:");
            foreach (char vc in vowelsChars)
            {
                Console.Write(vc+" ");
            }

            Console.WriteLine();
            Console.WriteLine("Dizinin eleman sayısı: "+vowelsChars.Count);

            
        }
    }
}