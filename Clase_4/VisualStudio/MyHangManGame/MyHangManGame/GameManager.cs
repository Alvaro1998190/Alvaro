using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame
{
    class GameManager
    {

        string secretWord = " zapatos ";
        public string publicWord = "";
        string tempWord = "";
        public bool isPlaying = true;


        public void SetSecretWord(string word)
        {
            secretWord = word.ToLower();


            for (int i = 0; i < secretWord.Length; i++)
            {
                publicWord += "*";


            }





        }
        // bool es para el verdadero o falso siermpre 
        public bool CheckLetter(string letter)
        {
            if (secretWord.Contains(letter))
            {
                Console.Beep();
                return true;
            }
            // else es para hacer un falso o verdadero
            else
            {
                Console.Beep(10000, 500);
                return false;
            }
        }
        public void UpdatePublicWord(string letter)
        {
            tempWord = "";
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (letter == "" + secretWord[i])
                {
                    tempWord += letter;
                }

                else
                {
                    tempWord += publicWord[i];

                }
            }
            publicWord = tempWord;





        }


        public bool isWin()
        {
            return secretWord == publicWord;


        }



    }
}
