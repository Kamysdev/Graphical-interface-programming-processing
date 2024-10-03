using System.Collections.ObjectModel;

namespace Clicker_game.Data
{
    public class CEnemyListTemplate
    {
        private ObservableCollection<CEnemy> CEmenyList { get; set; }

        public CEnemyListTemplate()
        {
            CEmenyList = [];
        }


    }
}

