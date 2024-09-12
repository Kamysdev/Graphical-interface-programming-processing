﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using CommunityToolkit.Mvvm.ComponentModel;
using Pokemon_Clicker.Enemy;
using Pokemon_Clicker.Visibility;

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

        private string _iconName;
        public string IconName
        {
            get => _iconName;
            set => SetProperty(ref _iconName, value);
        }

        private string _enemyName;
        public string EnemyName
        {
            get => _enemyName;
            set => SetProperty(ref _enemyName, value);
        }
        private string _baseLife;
        public string BaseLife
        {
            get => _baseLife;
            set => SetProperty(ref _baseLife, value);
        }
        private string _lifeModifier;
        public string LifeModifier
        {
            get => _lifeModifier;
            set => SetProperty(ref _lifeModifier, value);
        }
        private string _baseGold;
        public string BaseGold
        {
            get => _baseGold;
            set => SetProperty(ref _baseGold, value);
        }
        private string _goldModifier;
        public string GoldModifier
        {
            get => _goldModifier;
            set => SetProperty(ref _goldModifier, value);
        }

        public CIcon IcIcon { get; set; } = new CIcon(100, 100, "test.png");

        public MainWindowViewModel()
        {
            EnemyList = new CEnemyTemplateList();

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
            try
            {
                EnemyList.DeleteEnemyByName(SelectedEnemy.GetName());
            }
            catch
            {
            }
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
