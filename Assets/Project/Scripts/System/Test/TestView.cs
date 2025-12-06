using Project.Scripts.System.UI;
using UnityEngine;
using UnityEngine.UIElements;

namespace Project.Scripts.System.Test
{
    public class TestView : LayoutViewBase, ITestView
    {
        public Label Label { get; set; }
        public Button Button1 { get; set; }
        public Button Button2 { get; set; }

        public void Awake()
        {
            base.Awake();
            
            Label = _root.Q<Label>("Label");
            Button1 = _root.Q<Button>("Button1");
            Button2 = _root.Q<Button>("Button2");
        }
    }
}