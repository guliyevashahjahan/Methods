namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.  Bir int parametr qəbul edən və o ədədə qədər bütün cüt ədədlərin cəmini ekrana yazdıran, 
             * həm return type-ı olan bir method, həm də void bir method yazırsız
              2. Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
            Misal olaraq, name = "  Code  Acacemy   " 
            deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "CodeAcademy" olmalıdır.
              3.İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın  məs .("Hello World --> "H" "W" )*/

            CalculateAndPrint(8);
            Console.WriteLine(Calculate(8));
            TrimSpaces("  Code  Academy   ");
            PrintFirstLetters("Hello World");
        }
        #region 1
        static void CalculateAndPrint(int number)
        {
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        static int Calculate(int number)
        {
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        #endregion

        #region 2
        static void TrimSpaces (string word)
        {
            string temp = "";
            for (int i = 0; i < word.Length; i++)
            { 
                if (word[i] == ' ' )
                {
                    continue;
                }
                temp += word[i];
            }
            Console.WriteLine(temp);
        }
        #endregion

        #region 3
        static void PrintFirstLetters(string sentence)
        {
            string temp = "";
            temp+= sentence[0];
            for (int i = 1; i < sentence.Length; i++)
            {
                if (sentence[i-1] == ' ')
                {
                    temp += sentence[i];
                }
            }
            foreach (var item in temp)
            {
                Console.Write($"'{item}' ");
            }
        }
        #endregion
    }
}
