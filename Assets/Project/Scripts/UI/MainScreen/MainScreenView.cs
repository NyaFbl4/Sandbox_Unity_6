using Project.Scripts.System.UI;
using Project.Scripts.UI.MainScreen;
using UnityEngine;
using UnityEngine.UIElements;

public class MainScreenView : LayoutViewBase, IMainScreenView
{
    public Button BattlePassButton { get; private set; }

    public void Awake()
    {
        base.Awake();
        
        BattlePassButton = _root.Q<Button>("bnt_battlepass");
    }
}
