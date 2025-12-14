using System;
using MessagePipe;
using Project.Scripts.DTO;
using Project.Scripts.System.DTO;
using Project.Scripts.System.UI;
using Project.Scripts.UI.MainScreen;
using VContainer.Unity;
using R3;
using UnityEngine;
using VContainer;

namespace Project.Scripts.UI.BattlePass
{
    public class BattlePassPresenter : LayoutPresenterBase<IBattlePassView>, IBattlePassPresenter,
        IInitializable, IDisposable
    {
        [Inject] private readonly IPublisher<ShowPopUpDTO> _showPopUpPublisher;
        [Inject] private readonly IPublisher<HidePopUpDTO> _hidePopUpPublisher;
        
        private readonly CompositeDisposable _disposable = new();

        public void Initialize()
        {
            base.Initialize();
            
            /*_layoutView.Show();*/
            _layoutView.ButtonClose.clicked += ButtonClose;
            _layoutView.ButtonBuyBattlePass.clicked += ButtonBuyBattlePass;
        }

        public void Dispose()
        {
            _disposable?.Dispose();
        }

        private void ButtonClose()
        {
            _hidePopUpPublisher.Publish(new HidePopUpDTO
            {
                TargetPopUpType = typeof(IBattlePassPresenter)
            });
            
            _showPopUpPublisher.Publish(new ShowPopUpDTO
            {
                TargetPopUpType = typeof(IMainScreenPresenter)
            });
        }

        private void ButtonBuyBattlePass()
        {
            Debug.Log("ButtonBuyBattlePass");
        }
    }
}