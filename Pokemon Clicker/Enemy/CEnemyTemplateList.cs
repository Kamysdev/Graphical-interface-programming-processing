using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Pokemon_Clicker.Enemy
{
    public class CEnemyTemplateList
    {
        public ObservableCollection<CEnemyTemplate> enemies { get; set; }

        public CEnemyTemplateList()
        {
            enemies = [];
        }

        public void AddEnemy(CEnemyTemplate enemy) { enemies.Add(enemy); }

        public CEnemyTemplate GetEnemyByName(string name)
        {
            foreach (var enemy in enemies)
            {
                if (enemy.GetName() == name)
                {
                    return enemy;
                }
            }

            return enemies[0];
        }

        public CEnemyTemplate GetEnemyByIndex(int id)
        {
            return enemies[id];
        }

        public void DeleteEnemyByName(string name)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].GetName() == name)
                {
                    try
                    {
                        enemies.Remove(enemies[i]);
                    }
                    catch (Exception ex) 
                    {
                    }
                }
            }
        }

        public void DeleteEnemyByIndex(int id)
        {
            try
            {
                enemies.Remove(enemies[id]);
            }
            catch { }
        }

        public void SaveToJson(string path)
        {
            File.WriteAllText("CEnemyTemplateList.json", JsonSerializer.Serialize(enemies));
        }

        public void LoadFromJson(string path)
        {
            JsonDocument SavedJson = JsonDocument.Parse(File.ReadAllText("CEnemyTemplateList.json"));

            enemies.Clear();

            foreach (JsonElement element in SavedJson.RootElement.EnumerateArray())
            {
                try
                {
                    enemies.Add(new CEnemyTemplate(element.GetProperty("Name").GetString(),
                        element.GetProperty("iconName").GetString(),
                        element.GetProperty("baseLife").GetInt32(),
                        element.GetProperty("lifeModifier").GetDouble(),
                        element.GetProperty("baseGold").GetInt32(),
                        element.GetProperty("goldModifier").GetDouble(),
                        element.GetProperty("spawnChance").GetDouble()));
                }
                catch
                {
                }
            }
        }
    }
}
