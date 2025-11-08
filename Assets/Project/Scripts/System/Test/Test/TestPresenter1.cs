using System;
using Project.Scripts.System.UI;
using R3;
using VContainer.Unity;

namespace Project.Scripts.System.Test
{
    public class TestPresenter1 : LayoutPresenterBase<ITestView1>, ITestPresenter1, 
        IInitializable, IDisposable
    {
        private readonly CompositeDisposable _disposable = new();
        
        public void Initialize()
        {
            base.Initialize();
        }
        
        public void Dispose()
        {
            _disposable?.Dispose();
        }
    }
}