using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityFramework
{
    public class GameOrg
    {
        private IGame game;

        public GameOrg(IGame game)
        {
            this.game = game;
        }

        public string GameStatus()
        {
            return game.result();
        }

        public void AddPlayer()
        {
            game.addPlayer();
        }

        public void RemovePlayer()
        {
            game.removePlayer();
        }

        public void Play()
        {
            game.play();
        }
    }
}
