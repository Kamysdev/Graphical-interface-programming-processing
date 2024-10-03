namespace Clicker_game.Data
{
    public class CEnemy
    {
        private string name;
        private BigNumber hitPoints;
        private BigNumber gold;
        private string iconPath;

        public CEnemy(string name, BigNumber hitPoints, BigNumber gold, string iconPath)
        {
            this.name = name;
            this.hitPoints = hitPoints;
            this.gold = gold;
            this.iconPath = iconPath;
        }

        public string GetName()
        {
            return name;
        }

        public BigNumber GetHitPoints()
        {
            return hitPoints;
        }

        public BigNumber GetGold()
        {
            return gold;
        }

        public string GetIconPath()
        {
            return iconPath;
        }
    }
}
