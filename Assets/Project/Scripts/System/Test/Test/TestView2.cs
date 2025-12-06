using Project.Scripts.System.UI;
using UnityEngine.UIElements;

namespace Project.Scripts.System.Test
{
    public class TestView2 : LayoutViewBase, ITestView2
    {
        public Label Label { get; set; }
        public VisualElement VisualElement { get; set; }

        public override void Awake()
        {
            base.Awake();
            
            Label = _root.Q<Label>("Label");
            VisualElement = _root.Q<VisualElement>("VisualElement");
        }
    }
}