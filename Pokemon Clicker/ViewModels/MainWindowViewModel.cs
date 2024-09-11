using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls.Primitives;
using Pokemon_Clicker.Enemy;

namespace Pokemon_Clicker.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private CEnemyTemplateList _enemyList;
        public CEnemyTemplateList EnemyList
        {
            get => _enemyList;
            set => SetProperty(ref _enemyList, value);
        }

        public CEnemyTemplate SelectedEnemy { get; set; }

        public string IconName { get; set; } 
        public string EnemyName { get; set; }
        public string BaseLife { get; set; }
        public string LifeModifier { get; set; }
        public string BaseGold { get; set; }
        public string GoldModifier { get; set; }

        public MainWindowViewModel()
        {
            EnemyList = new CEnemyTemplateList();

            EnemyList.AddEnemy(new CEnemyTemplate("adsda", "a", 1, 1, 1, 1, 1));
            EnemyList.AddEnemy(new CEnemyTemplate("adsda", "a", 1, 1, 1, 1, 1));
        }

        public void Button__AddEnemy()
        {
            try
            {
                EnemyList.AddEnemy(new CEnemyTemplate(EnemyName, IconName, Int32.Parse(BaseLife),
                    Double.Parse(LifeModifier), Int32.Parse(BaseGold), Double.Parse(GoldModifier), 1));
            }
            catch
            {
            }
        }
    }
}
