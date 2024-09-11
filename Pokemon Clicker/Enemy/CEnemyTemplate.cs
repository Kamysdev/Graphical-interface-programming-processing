using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Pokemon_Clicker.Enemy
{
    public class CEnemyTemplate
    {
        [JsonInclude]
        private string? name { get; set; }
        [JsonInclude]
        private string? iconName;

        [JsonInclude]
        private int baseLife;
        [JsonInclude]
        private double lifeModifier;

        [JsonInclude]
        private int baseGold;
        [JsonInclude]
        private double goldModifier;

        [JsonInclude]
        private double spawnChance;

        public CEnemyTemplate(string name, string iconName, int baseLife, double lifeModifier, int baseGold, double goldModifier, double spawnChance)
        {
            this.name = name;
            this.iconName = iconName;
            this.baseLife = baseLife;
            this.lifeModifier = lifeModifier;
            this.baseGold = baseGold;
            this.goldModifier = goldModifier;
            this.spawnChance = spawnChance;
        } 

        public string GetName() { return name; }
        public string GetIcon() { return iconName; }
        public int GetBaseLife() { return baseLife; } 
        public double GetLifeModifier() { return lifeModifier; }
        public int GetGold() {  return baseGold; }
        public double GetGoldModifier() { return goldModifier; }
        public double GetSpawnChance() { return spawnChance; }
    }
}
