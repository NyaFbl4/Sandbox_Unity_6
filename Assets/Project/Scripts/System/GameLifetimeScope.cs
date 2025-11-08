using System.Collections.Generic;
using MessagePipe;
using Project.Scripts;
using Project.Scripts.System.UI;
using Project.Scripts.UI.Presenters;
using VContainer;
using VContainer.Unity;
using Project.Scripts.Installers;
using UnityEngine;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] private LayoutsRepository _layoutsRepository;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<Presenter>();
        builder.Register<HelloWorldService>(Lifetime.Singleton);

        builder.RegisterMessagePipe();
        
        RegisterPresentation(builder);
    }

    private void RegisterPresentation(IContainerBuilder builder)
    {
        builder.RegisterLayoutsInstaller(_layoutsRepository);
    }
}
