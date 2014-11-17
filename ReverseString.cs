using System;
namespace ReadifyCompetencyPuzzles
{
    class ReverseString
    {

        char[] arrayToReverse = null;
        public static void Run()
        {
            ReverseString MyRevString = new ReverseString();
            string Input = MyRevString.ReverseSentence("cat and dog");
            Console.WriteLine(Input);
            Console.ReadLine(); // To Keep Open the Windows Console window
        }
        #region Methods
        // Reverse the Whole sentence
        public string ReverseSentence(string Words)
        {
            if (Words.Length <= 0)
                return string.Empty;
            arrayToReverse = Words.ToCharArray();
            int x = 0, y = 0;
            while (x < arrayToReverse.Length)
            {
                if (arrayToReverse[x] == ' ')
                {
                    ReverseWord(ref x, ref y);
                    y = x + 1;
                }
                x++;
            }
            ReverseWord(ref x, ref y);
            return new string(arrayToReverse);

        }
        //Reverse the word part by part
        private void ReverseWord(ref int x, ref int y)
        {
            for (int z = 0; z < (x - y); z++)
            {
                char temp = arrayToReverse[x - 1 - z];
                arrayToReverse[x - 1 - z] = arrayToReverse[y];
                arrayToReverse[y] = temp;
                y++;
            }
        }
        #endregion
    }
}