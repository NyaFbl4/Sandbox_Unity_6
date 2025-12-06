using Project.Scripts.Interfaces;
using UnityEngine.UIElements;

namespace Project.Scripts.System.Test
{
    public interface ITestView1 : ILayoutView
    {
        public Label Label { get; set; }
        public VisualElement VisualElement { get; set; }
    }
}