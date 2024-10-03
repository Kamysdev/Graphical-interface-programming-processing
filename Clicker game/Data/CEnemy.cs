namespace Clicker_game.Data
{
    public class CEnemy
    {
        private readonly string name;
        private readonly BigNumber hitPoints;
        private readonly BigNumber gold;
        private readonly string iconName;

        private double spawnChance;

        public CEnemy(string name, BigNumber hitPoints, BigNumber gold, string iconName)
        {
            this.name = name;
            this.hitPoints = hitPoints;
            this.gold = gold;
            this.iconName = iconName;

            spawnChance = 1;
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

        public string GetIconName()
        {
            return iconName;
        }

        public void SetSpawnChance(double SpawnChance)
        {
            spawnChance = SpawnChance;
        }

        public double GetSpawnChance()
        {
            return spawnChance;
        }
    }
}
