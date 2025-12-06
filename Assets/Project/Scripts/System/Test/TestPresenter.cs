using System;
using MessagePipe;
using Project.Scripts.DTO;
using Project.Scripts.System.DTO;
using Project.Scripts.System.UI;
using R3;
using VContainer;
using VContainer.Unity;

namespace Project.Scripts.System.Test
{
    public class TestPresenter : LayoutPresenterBase<ITestView>, IInitializable, IDisposable
    {   
        [Inject] private readonly IPublisher<TestDTO> _publisherTestDTO; 
        [Inject] private readonly IPublisher<ShowPopUpDTO> _showPopUpDTOPublisher;
        [Inject] private readonly IPublisher<HidePopUpDTO> _hidePopUpDTOPublisher;
        
        private readonly CompositeDisposable _disposable = new();

        public void Initialize()
        {
            base.Initialize();
            
            _layoutView.Button1.clicked += OnButton1Clicked;
            _layoutView.Button2.clicked += OnButton2Clicked;

            /*_layoutView.Show();*/
        }
        
        public void Dispose()
        {
            _layoutView.Button1.clicked -= OnButton1Clicked;
            _layoutView.Button2.clicked -= OnButton2Clicked;
        
            _disposable?.Dispose();
        }

        private void OnButton1Clicked()
        {
            _layoutView.Label.text = "OnButton1Clicked";
            
            _showPopUpDTOPublisher.Publish(new ShowPopUpDTO()
            {
                TargetPopUpType = typeof(ITestPresenter1)
            });
            
            _hidePopUpDTOPublisher.Publish(new HidePopUpDTO()
            {
                TargetPopUpType = typeof(ITestPresenter2)
            });
        }

        private void OnButton2Clicked()
        {
            _layoutView.Label.text = "OnButton2Clicked";
            
            _showPopUpDTOPublisher.Publish(new ShowPopUpDTO()
            {
                TargetPopUpType = typeof(ITestPresenter2)
            });
            
            _hidePopUpDTOPublisher.Publish(new HidePopUpDTO()
            {
                TargetPopUpType = typeof(ITestPresenter1)
            });
        }
    }
}