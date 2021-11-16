using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFacade.Classes
{
    class GameNextWord
    {
        protected Player1 _player1;

        protected Player2 _player2;

        public GameNextWord(Player1 player1, Player2 player2 )
        {
            this._player1 = player1;
            this._player2 = player2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            string result = "GameNextWord start: Player1 -> Player 2\n";
            result += this._player1.Word1();
            result += "\n";
            result += $"  Continue with alphabet: { _player1.Word1()[_player1.Word1().Length - 1]}    \n";

            result += this._player2.Word1();
            result += "\n";
            result += $"  Continue with alphabet: { _player2.Word1()[_player2.Word1().Length - 1]}    \n";

            result += this._player1.WordN();
            result += "\n";
            result += $"  Continue with alphabet: { _player1.WordN()[_player1.WordN().Length - 1]}    \n";

            result += this._player2.WordZ();
            result += "\n";
            result += $"  Continue with alphabet: { _player2.WordZ()[_player2.WordZ().Length - 1]}    \n";
            
            return result;
        }
    }
}
