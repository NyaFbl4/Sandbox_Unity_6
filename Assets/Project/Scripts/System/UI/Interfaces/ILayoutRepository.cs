using System.Collections.Generic;
using Project.Scripts.System.UI;

namespace Project.Scripts.Interfaces
{
    public interface ILayoutRepository
    {
        public List<LayoutViewBase> Views { get; }
    }
}