using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame
{
    class Program
    {
        static void Main(string[] args) {
            /*
            string secretWord = "zapatos";
            string publicWord = "";
            string tempWord = "";
            string letter = "";
            int hp = 3;


            for (int i = 0; i < secretWord.Length; i++) {
                tempWord += "*";
            }
            publicWord = tempWord;
            Console.WriteLine(publicWord);


            while (hp > 0) {
                Console.WriteLine("HP = " + hp);
                Console.WriteLine("Ingrese una letra:");
                letter = Console.ReadLine();
                Console.Clear();

                tempWord = "";
                for (int i = 0; i < secretWord.Length; i++) {
                    if (letter == "" + secretWord[i]) {
                        tempWord += letter; //tempWord += secretWord[i];
                    }
                    else {
                        tempWord += publicWord[i];
                    }
                }

                if (publicWord == tempWord) {
                    hp--;
                }

                if (secretWord == tempWord) {
                    Console.WriteLine("YOU WIN!!");
                    break;
                }

                publicWord = tempWord;
                Console.WriteLine(publicWord);
            }

            if (hp <= 0) {
                Console.WriteLine("GAME OVER");
            }

            Console.ReadLine();
            */

            GameManager gamemanager = new GameManager();
            Board board = new Board();
            Player player = new Player();

            gamemanager.SetSecretWord("LapTop");

            while (gamemanager.isPlaying)
            {
                board.Clear();
                board.Draw(player.Life());
                board.Draw(gamemanager.publicWord);


                string letter = player.EnterWord();


                if (gamemanager.CheckLetter(letter))
                    gamemanager.UpdatePublicWord(letter);

                else
                    player.Damage();


                if (player.isDead())
                    gamemanager.isPlaying = false;

            }


            //opcion 1

            board.Clear();
            board.Draw(player.Life());

                board.Draw("GAME OVER");



            /*
            //opcion 2
            if (player.isDead())
            {
                board.Draw("GAME OVER");
                break;
            }
            */
            if (gamemanager.isWin())
                board.Draw("YOU WIN!!");



            board.Close();
        }





        
        



            




    }
}
