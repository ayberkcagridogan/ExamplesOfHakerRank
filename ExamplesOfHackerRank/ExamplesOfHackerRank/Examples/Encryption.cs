using System;
namespace ExamplesOfHackerRank.Examples
{
    public class Encryption
    {
        public string GetEncryptionWord(string word)
        {
            word = word.Replace(" " , string.Empty);

            int wordLenght = word.Length;

            int column = (int)Math.Sqrt(wordLenght);

            if (!(column * column == word.Length))
            {
                column++;
            }
       
            string encryptionWord = "";

            for (int i = 0; i < column; i++)
            {
                for (int j = i ; j < word.Length; j+= column)
                {            
                    encryptionWord += word.Substring(j, 1);
                }
                encryptionWord += " ";
            }

            return encryptionWord.TrimEnd();

        }
    }
}
