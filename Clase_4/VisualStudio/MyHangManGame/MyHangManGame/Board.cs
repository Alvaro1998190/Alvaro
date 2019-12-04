using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame
{
    class Board
    {

        public void Clear()
        {
            Console.Clear();

        }
        //() lo que esta adentro son los metodos 
        public void Draw(string line) {
            Console.WriteLine(line);


                }

        public void Close() {
            Console.WriteLine("Press Enter to Close ");
            Console.ReadLine();
        }

    }
}
