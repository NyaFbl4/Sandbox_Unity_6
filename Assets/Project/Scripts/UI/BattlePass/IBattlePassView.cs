using Project.Scripts.Interfaces;
using UnityEngine.UIElements;

namespace Project.Scripts.UI.BattlePass
{
    public interface IBattlePassView : ILayoutView
    {
        public Button ButtonClose { get; }
        public Button ButtonBuyBattlePass { get; }
    }
}