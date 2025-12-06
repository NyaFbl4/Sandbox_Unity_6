using Unity.VisualScripting;
using UnityEngine;
using VContainer.Unity;

namespace Project.Scripts.UI.Presenters
{
    public class Presenter : ITickable
    {
        private readonly HelloWorldService _helloWorldService;

        public Presenter(HelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        void ITickable.Tick()
        {
            _helloWorldService.Hello();
        }
    }
}