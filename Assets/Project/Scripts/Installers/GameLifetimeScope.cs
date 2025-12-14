using MessagePipe;
using Project.Scripts.DTO;
using Project.Scripts.Interfaces;
using Project.Scripts.System.Test;
using Project.Scripts.System.UI;
using Project.Scripts.UI.BattlePass;
using Project.Scripts.UI.MainScreen;
using Project.Scripts.UI.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Project.Scripts.Installers
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField] private TestView _testView;
        [SerializeField] private TestView1 _testView1;
        [SerializeField] private TestView2 _testView2;
        [SerializeField] private MainScreenView _mainScreenView;
        [SerializeField] private BattlePassView _battlePassView;

        protected override void Configure(IContainerBuilder builder)
        {
            RegisterSystems(builder);
            RegisterUseCases(builder);
            RegisterViews(builder);
            RegisterPresenters(builder);
        }

        private void RegisterSystems(IContainerBuilder builder)
        {
            builder.RegisterMessagePipe();
            builder.RegisterEntryPoint<UIController>().As<IUIController>();
        }

        private void RegisterUseCases(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<ShowPopUpUseCase>(Lifetime.Singleton);
            builder.RegisterEntryPoint<HidePopUpUseCase>(Lifetime.Singleton);
        }
        
        private void RegisterViews(IContainerBuilder builder)
        {
            builder.RegisterComponentInNewPrefab(_testView, Lifetime.Scoped).As<ITestView>();
            builder.RegisterComponentInNewPrefab(_testView1, Lifetime.Scoped).As<ITestView1>();
            builder.RegisterComponentInNewPrefab(_testView2, Lifetime.Scoped).As<ITestView2>();
            builder.RegisterComponentInNewPrefab(_mainScreenView, Lifetime.Scoped).As<IMainScreenView>();
            builder.RegisterComponentInNewPrefab(_battlePassView, Lifetime.Scoped).As<IBattlePassView>();
        }
        
        private void RegisterPresenters(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<TestPresenter>(Lifetime.Scoped);
            builder.RegisterEntryPoint<TestPresenter1>(Lifetime.Scoped);
            builder.RegisterEntryPoint<TestPresenter2>(Lifetime.Scoped);
            builder.RegisterEntryPoint<MainScreenPresenter>(Lifetime.Scoped);
            builder.RegisterEntryPoint<BattlePassPresenter>(Lifetime.Scoped);
        }
    }
}