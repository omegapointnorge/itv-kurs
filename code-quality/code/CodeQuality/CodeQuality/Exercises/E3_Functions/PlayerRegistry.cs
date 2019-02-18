using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E3_Functions
{
    public class PlayerRegistry
    {
        private List<Player> Players { get; set; }

        public Player GetPlayer(string username)
        {

            var player = FindByPlayerByUsername(username);

            if (player == null)
            {
                player = new Player(username);
                Players.Add(player);
            }

            return player;

        }

        private Player FindByPlayerByUsername(string username)
        {
            return Players.FirstOrDefault(x => x.Username == username);
        }
    }
}
