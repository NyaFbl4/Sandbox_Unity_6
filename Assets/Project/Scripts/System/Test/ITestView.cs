using Project.Scripts.Interfaces;
using UnityEngine.UIElements;

namespace Project.Scripts.System.Test
{
    public interface ITestView : ILayoutView
    {
        public Label Label { get; }
        public Button Button1 { get; }
        public Button Button2 { get; }
    }
}