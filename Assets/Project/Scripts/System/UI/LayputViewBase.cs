using Project.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UIElements;
using NotImplementedException = System.NotImplementedException;

namespace Project.Scripts.System.UI
{
    [RequireComponent(typeof(UIDocument))]
    public abstract class LayoutViewBase : MonoBehaviour, ILayoutView
    {
        protected UIDocument _uiDocument;
        protected VisualElement _root;
        
        public virtual void Awake()
        {
            _uiDocument = GetComponent<UIDocument>();
            _root = _uiDocument.rootVisualElement;
            Hide();
        }

        public bool Visible
        {
            get {return _root.style.display == DisplayStyle.Flex;} 
            set{ _root.style.display = value ? DisplayStyle.Flex : DisplayStyle.None; }
        }
        
        public void Hide()
        {
            Visible = false;
        }

        public void Show()
        {
            Visible = true;
        }
    }
}