using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using CommunityToolkit.Mvvm.ComponentModel;
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

        private CEnemyTemplate _selectedEnemy;
        public CEnemyTemplate SelectedEnemy
        {
            get => _selectedEnemy;
            set 
            {
                SetProperty(ref _selectedEnemy, value);
                SelectedEnemyFieldUpdater();
            }
        }

        private string _propertyString;
        public string IconName
        {
            get => _propertyString;
            set => SetProperty(ref _propertyString, value);
        }
        public string EnemyName
        {
            get => _propertyString;
            set => SetProperty(ref _propertyString, value);
        }
        public string BaseLife
        {
            get => _propertyString;
            set => SetProperty(ref _propertyString, value);
        }
        public string LifeModifier
        {
            get => _propertyString;
            set => SetProperty(ref _propertyString, value);
        }
        public string BaseGold
        {
            get => _propertyString;
            set => SetProperty(ref _propertyString, value);
        }
        public string GoldModifier
        {
            get => _propertyString;
            set => SetProperty(ref _propertyString, value);
        }

        public MainWindowViewModel()
        {
            EnemyList = new CEnemyTemplateList();

            EnemyList.AddEnemy(new CEnemyTemplate("adsda", "a", 1, 2, 3, 14, 100));
            EnemyList.AddEnemy(new CEnemyTemplate("adsda1", "a", 1, 15, 10, 51, 1));
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

        public void Button__RemoveEnemy()
        {
            EnemyList.DeleteEnemyByName(SelectedEnemy.GetName());
        }

        protected virtual void SelectedEnemyFieldUpdater()
        {
            try
            {
                IconName = SelectedEnemy.GetIcon();
                EnemyName = SelectedEnemy.GetName();
                BaseLife = SelectedEnemy.GetBaseLife().ToString();
                LifeModifier = SelectedEnemy.GetLifeModifier().ToString();
                BaseGold = SelectedEnemy.GetGold().ToString();
                GoldModifier = SelectedEnemy.GetGoldModifier().ToString();
            }
            catch (Exception ex)
            {
                SelectedEnemy = EnemyList.GetEnemyByIndex(0);
            }
        }
    }
}
