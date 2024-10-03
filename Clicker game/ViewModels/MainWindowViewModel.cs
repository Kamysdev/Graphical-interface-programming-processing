using System;
using System.IO;
using Clicker_game.Data;
using Clicker_game.User;
using static System.Net.Mime.MediaTypeNames;

namespace Clicker_game.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public CPlayer? Player;
        public CEnemyList? EnemyList = new CEnemyList();
        public CEnemy CurrentEnemy;

        private string _enemyName;
        public string EnemyName
        {
            get => _enemyName;
            set { _enemyName = value; OnPropertyChanged(nameof(EnemyName)); }
        }

        private string _enemyHP;
        public string EnemyHP
        {
            get => _enemyHP;
            set { _enemyHP = value; OnPropertyChanged(nameof(EnemyHP)); }
        }

        private string _goldFromEnemy;
        public string GoldFromEnemy
        {
            get => _goldFromEnemy;
            set { _goldFromEnemy = value; OnPropertyChanged(nameof(GoldFromEnemy)); }
        }

        public MainWindowViewModel()
        {
            try
            {
                ProgressLoader.LoadPlayerData(ref Player);
            }
            catch (Exception ex)
            {
                using var sw = new StreamWriter("log.txt", true);
                sw.WriteLine(System.DateTime.Now + ": " + ex.Message);
            }

            try
            {
                EnemyList.LoadFromJson();
            }
            catch (Exception ex)
            {
                using var sw = new StreamWriter("log.txt", true);
                sw.WriteLine(System.DateTime.Now + ": " + ex.Message);
            }

            CurrentEnemy = EnemyList.GetRandomCEnemy();

            EnemyName = CurrentEnemy.GetName();
            EnemyHP = CurrentEnemy.GetHitPoints().ToString();
            GoldFromEnemy = CurrentEnemy.GetGold().ToString();
        }
    }
}
