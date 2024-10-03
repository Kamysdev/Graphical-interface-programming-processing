using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Clicker_game.User;

namespace Clicker_game.Data
{
    public class ProgressLoader
    {
        public static void LoadPlayerData(ref CPlayer loadablePlayer)
        {
            var SavedPlayerJson = JsonDocument.Parse(File.ReadAllText("Progress.json"));

            foreach (var element in SavedPlayerJson.RootElement.EnumerateArray())
            {
                loadablePlayer = new CPlayer(new BigNumber(element.GetProperty("gold").ToString()),
                    new BigNumber(element.GetProperty("damage").ToString()),
                    element.GetProperty("damageModifier").GetDouble(),
                    new BigNumber(element.GetProperty("upgradeCost").ToString()),
                    element.GetProperty("upgradeCostModifier").GetDouble(),
                    element.GetProperty("lvl").GetInt32());
            }
        }
    }

    public class CPlayerJson
    {
        [JsonInclude] 
        private readonly string gold;

        [JsonInclude] 
        private readonly string damage;

        [JsonInclude]
        private readonly double damageModifier;

        [JsonInclude]
        private readonly string upgradeCost;

        [JsonInclude]
        private readonly double upgradeCostModifier;

        [JsonInclude]
        private readonly int lvl;

        public CPlayerJson(CPlayer player)
        {
            gold = player.GetGold().ToString();
            damage = player.GetDamage().ToString();
            damageModifier = player.GetDamageModifier();
        }
    }
}