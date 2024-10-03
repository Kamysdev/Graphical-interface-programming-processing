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
            var savedPlayerJson = JsonDocument.Parse(File.ReadAllText("Progress.json"));

            foreach (var element in savedPlayerJson.RootElement.EnumerateArray())
            {
                loadablePlayer = new CPlayer(new BigNumber(element.GetProperty("gold").ToString()),
                    new BigNumber(element.GetProperty("damage").ToString()),
                    element.GetProperty("damageModifier").GetDouble(),
                    new BigNumber(element.GetProperty("upgradeCost").ToString()),
                    element.GetProperty("upgradeCostModifier").GetDouble(),
                    element.GetProperty("lvl").GetInt32());
            }
        }

        public static void SavePlayerData(CPlayer savablePlayer)
        {
            File.WriteAllText("", JsonSerializer.Serialize(savablePlayer));
        }
    }
    
    public class CPlayerJson(CPlayer player)
    {
        [JsonInclude] 
        private readonly string gold = player.GetGold().ToString();

        [JsonInclude] 
        private readonly string damage = player.GetDamage().ToString();

        [JsonInclude]
        private readonly double damageModifier = player.GetDamageModifier();

        [JsonInclude]
        private readonly string upgradeCost = player.GetUpgradeCost().ToString();

        [JsonInclude]
        private readonly double upgradeCostModifier = player.GetUpgradeCostModifier();

        [JsonInclude]
        private readonly int lvl = player.GetLvl();
    }
}