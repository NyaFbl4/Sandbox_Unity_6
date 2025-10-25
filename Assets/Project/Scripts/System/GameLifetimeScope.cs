using MessagePipe;
using Project.Scripts;
using Project.Scripts.UI.Presenters;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<Presenter>();
        builder.Register<HelloWorldService>(Lifetime.Singleton);

        builder.RegisterMessagePipe();
    }
}
