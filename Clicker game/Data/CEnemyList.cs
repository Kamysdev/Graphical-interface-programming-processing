using System;
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
                CEnemyCollection.Add(new CEnemy(element.GetProperty("Name").ToString(),
                    new BigNumber(element.GetProperty("baseLife").ToString()), 
                    new BigNumber(element.GetProperty("baseGold").ToString()),
                    element.GetProperty("iconName").ToString()));
            }
        }

        public void NormalizeChances()
        {
            var sumValue = CEnemyCollection.Sum(enemy => enemy.GetSpawnChance());

            foreach (var valueEnemy in CEnemyCollection)
            {
                valueEnemy.SetSpawnChance(valueEnemy.GetSpawnChance() / sumValue);
            }
        }

        public CEnemy GetRandomCEnemy()
        {
            var sumValue = CEnemyCollection.Sum(enemy => enemy.GetSpawnChance());

            return CEnemyCollection[new Random().Next(Convert.ToInt32(sumValue))];
        }
    }
}

