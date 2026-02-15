using Project.Scripts.Models.Rewards;
using UnityEngine;

namespace Project.Scripts.Models.BattlePass
{
    public class BattlePassConfig : ScriptableObject
    {
        [SerializeField] private Reward _reward;
        
        public Reward Reward => _reward;
    }
}