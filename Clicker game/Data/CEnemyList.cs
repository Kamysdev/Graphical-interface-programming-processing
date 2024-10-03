using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace Clicker_game.Data
{
    public class CEnemyList
    {
        private ObservableCollection<CEnemy> CEmenyCollection { get; set; }

        public CEnemyList()
        {
            CEmenyCollection = [];
        }

        public void LoadFromJson()
        {
            JsonDocument SavedJson = JsonDocument.Parse(File.ReadAllText("CEnemyTemplateList.json"));

            foreach (JsonElement element in SavedJson.RootElement.EnumerateArray())
            {
                try
                {
                    CEmenyCollection.Add(new CEnemy(element.GetProperty("Name").GetString(),
                        new BigNumber(element.GetProperty("baseLife").GetString()), 
                        new BigNumber(element.GetProperty("baseGold").GetString()),
                        );
                }
                catch
                {
                }
            }
        }

        public void NormalizwChances()
        {

        }

        public CEnemy GetRandomCEnemy()
        {
            return null;
        }
    }
}

