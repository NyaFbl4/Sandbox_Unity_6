using Project.Scripts.Interfaces;
using UnityEngine.UIElements;

namespace Project.Scripts.UI.MainScreen
{
    public interface IMainScreenView : ILayoutView
    {
        public Button BattlePassButton { get; }
    }
}