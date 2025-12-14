using System;
using MessagePipe;
using Project.Scripts.DTO;
using Project.Scripts.System.DTO;
using Project.Scripts.System.UI;
using Project.Scripts.UI.BattlePass;
using R3;
using VContainer;
using VContainer.Unity;


namespace Project.Scripts.UI.MainScreen
{
    public class MainScreenPresenter : LayoutPresenterBase<IMainScreenView>, IMainScreenPresenter,
        IInitializable, IDisposable
    {
        [Inject] private readonly IPublisher<ShowPopUpDTO> _showPopUpPublisher;
        [Inject] private readonly IPublisher<HidePopUpDTO> _hidePopUpPublisher;
        
        private readonly CompositeDisposable _disposable = new();

        public void Initialize()
        {
            base.Initialize();
            
            _layoutView.Show();

            _layoutView.BattlePassButton.clicked += OnBattlePassClicked;
        }

        public void Dispose()
        {
            _layoutView.BattlePassButton.clicked -= OnBattlePassClicked;
            
            _disposable?.Dispose();
        }

        private void OnBattlePassClicked()
        {
            _hidePopUpPublisher.Publish(new HidePopUpDTO
            {
                TargetPopUpType = typeof(IMainScreenPresenter)
            });
            
            _showPopUpPublisher.Publish(new ShowPopUpDTO
            {
                TargetPopUpType = typeof(IBattlePassPresenter)
            });
        }
    }
}