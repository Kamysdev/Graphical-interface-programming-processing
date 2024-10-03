using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Clicker_game.Data
{
    public class CEnemyList
    {
        private ObservableCollection<CEnemy> CEnemyCollection { get; set; }

        public CEnemyList()
        {
            CEnemyCollection = [];
        }

        public void LoadFromJson()
        {
            var SavedJson = JsonDocument.Parse(File.ReadAllText("CEnemyTemplateList.json"));

            foreach (var element in SavedJson.RootElement.EnumerateArray())
            {
                try
                {
                    CEnemyCollection.Add(new CEnemy(element.GetProperty("Name").GetString(),
                        new BigNumber(element.GetProperty("baseLife").GetString()), 
                        new BigNumber(element.GetProperty("baseGold").GetString()),
                        element.GetProperty("iconName").GetString()));
                }
                catch
                {
                }
            }
        }

        public void NormalizeChances()
        {
            double sumValue = CEnemyCollection.Sum(enemy => enemy.GetSpawnChance());

            foreach (var valueEnemy in CEnemyCollection)
            {
                valueEnemy.SetSpawnChance(valueEnemy.GetSpawnChance() / sumValue);
            }
        }

        public CEnemy GetRandomCEnemy()
        {
            return null;
        }
    }
}

