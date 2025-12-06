using System;
using MessagePipe;
using Project.Scripts.DTO;
using Project.Scripts.Interfaces;
using R3;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Project.Scripts.UI.UseCases
{
    public class ShowPopUpUseCase : IInitializable, IDisposable, IMessageHandler<ShowPopUpDTO>
    {
        [Inject] private readonly ISubscriber<ShowPopUpDTO> _showPopUpSubscriber;
        [Inject] private readonly IUIController _uiController;
        private CompositeDisposable  _disposable = new();
        
        public void Initialize()
        {
            _showPopUpSubscriber.Subscribe(this).AddTo(_disposable);
        }
        
        public void Handle(ShowPopUpDTO message)
        {
            Debug.Log("ShowPopUpUseCase Handle" + message.TargetPopUpType);
            _uiController.ShowPopup(message.TargetPopUpType);
        }

        public void Dispose()
        {
            _disposable.Dispose();
        }
    }
}