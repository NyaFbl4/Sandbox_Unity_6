using Project.Scripts.Interfaces;
using UnityEngine.UIElements;

namespace Project.Scripts.System.Test
{
    public interface ITestView2 : ILayoutView
    {
        public Label Label { get; set; }
        public VisualElement VisualElement { get; set; }
    }
}