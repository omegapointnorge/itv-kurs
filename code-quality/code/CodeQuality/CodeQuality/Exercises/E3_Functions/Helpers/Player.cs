namespace CodeQuality.E3_Functions
{
    public class Player
    {
        public Player(string username)
        {
            this.Username = username;
        }

        public string Username { get; internal set; }
    }
}