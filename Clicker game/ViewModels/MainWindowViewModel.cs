using System;
using System.IO;
using Clicker_game.Data;
using Clicker_game.User;
using static System.Net.Mime.MediaTypeNames;

namespace Clicker_game.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private CPlayer? Player;

        private CEnemyList? EnemyList = new CEnemyList();
        
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


            //EnemyList.LoadFromJson();
        }
    }
}
