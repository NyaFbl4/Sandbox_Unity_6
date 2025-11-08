using System;
using System.Linq;
using Project.Scripts.Interfaces;
using VContainer;
using VContainer.Unity;

namespace Project.Scripts.Installers
{
    public static class LayoutsInstaller
    {
        public static void RegisterLayoutsInstaller(this IContainerBuilder builder, ILayoutRepository layoutRepository)
        {
            foreach (var view in layoutRepository.Views)
            {
                var viewType = view
                    .GetType()
                    .GetInterfaces()
                    .Where(IsLayoutViewInterface)
                    .ToArray();
                
                var result = builder.RegisterComponentInNewPrefab(view, Lifetime.Scoped).As(viewType);
            }
        }

        private static bool IsLayoutViewInterface(Type @type)
        {
            return typeof(ILayoutView).IsAssignableFrom(@type)
                && @type != typeof(ILayoutView);
        }
    }
}