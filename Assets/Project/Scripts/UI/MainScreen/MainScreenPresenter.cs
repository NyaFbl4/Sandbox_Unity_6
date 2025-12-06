using System;
using Project.Scripts.System.UI;
using R3;
using VContainer.Unity;


namespace Project.Scripts.UI.MainScreen
{
    public class MainScreenPresenter : LayoutPresenterBase<IMainScreenView>, IMainScreenPresenter,
        IInitializable, IDisposable
    {
        private readonly CompositeDisposable _disposable = new();

        public void Initialize()
        {
            base.Initialize();
            
            _layoutView.Show();
        }

        public void Dispose()
        {
            _disposable?.Dispose();
        }
    }
}