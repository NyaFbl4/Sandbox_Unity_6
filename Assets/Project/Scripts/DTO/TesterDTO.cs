using System;
using MessagePipe;
using R3;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Project.Scripts.DTO
{
    public class TesterDTO : IInitializable, IDisposable, IMessageHandler<TestDTO>
    {
        [Inject] private readonly ISubscriber<TestDTO> _testerDTOSubscriber;
        
        private CompositeDisposable  _disposable = new();
        
        public void Initialize()
        {
            _testerDTOSubscriber.Subscribe(this).AddTo(_disposable);
        }

        public void Handle(TestDTO message)
        {
            Debug.Log("testerDTO "+ message.Message);
        }
        
        public void Dispose()
        {
            _disposable.Dispose();
        }
    }
}