using Cysharp.Threading.Tasks;
using UnityEngine.UIElements;

namespace Project.Scripts.Interfaces
{
    public interface ILayoutPresenter
    {
        public VisualElement RootElement { get; }
        public bool IsActive { get; }
        public UniTask ActivateAsync();
        public UniTask DeactivateAsync();
    }
}