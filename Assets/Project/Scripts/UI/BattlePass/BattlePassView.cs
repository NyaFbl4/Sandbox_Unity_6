using Project.Scripts.System.UI;
using UnityEngine.UIElements;

namespace Project.Scripts.UI.BattlePass
{
    public class BattlePassView : LayoutViewBase, IBattlePassView
    {
        public Button ButtonClose { get; private set; }
        public Button ButtonBuyBattlePass { get; private set; }

        public void Awake()
        {
            base.Awake();
            ButtonClose = _root.Q<Button>("btn_close");
            ButtonBuyBattlePass = _root.Q<Button>("buy_btn_golden_pass");
        }
    }
}