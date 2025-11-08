using System;
using System.Collections.Generic;
using Project.Scripts.Interfaces;
using UnityEngine;

namespace Project.Scripts.System.UI
{
    [Serializable]
    [CreateAssetMenu(fileName = "Layouts Repository", menuName = "UI/Repository")]
    public class LayoutsRepository : ScriptableObject, ILayoutRepository
    { 
        [SerializeField] private List<LayoutViewBase> _layoutViews;
        public List<LayoutViewBase> Views => _layoutViews;
    }
}