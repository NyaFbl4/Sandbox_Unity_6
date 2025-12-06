using Cysharp.Threading.Tasks;

namespace Project.Scripts.Interfaces
{
    public interface ILayoutView
    {
        bool Visible { get; }
        UniTask ShowAsync();
        UniTask HideAsync();
        void  Hide();
        void Show();
    }
}