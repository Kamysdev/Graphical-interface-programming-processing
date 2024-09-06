using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pokemon_Clicker.Enemy
{
    public class CEnemyTemplateList
    {
        List<CEnemyTemplate> enemies;

        public CEnemyTemplateList()
        {
            enemies = new List<CEnemyTemplate>();
        }

        public void AddEnemy(CEnemyTemplate enemy)
        {
            enemies.Add(enemy);
        }

        public void SaveToJson(string path)
        {

        }
    }

    public class CEnemytemplateListJson 
    {
        [JsonInclude]
        public List<CEnemyTemplate> enemies;
    }
}
