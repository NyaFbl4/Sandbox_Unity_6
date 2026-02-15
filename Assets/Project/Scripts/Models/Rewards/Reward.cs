using UnityEngine;

namespace Project.Scripts.Models.Rewards
{
    public class Reward : ScriptableObject
    {
        [SerializeField] private RewardInfo _rewardInfo;
        [SerializeField] private int _rewardAmount;
        
        public RewardInfo RewardInfo => _rewardInfo;
        public int RewardAmount => _rewardAmount;
    }
}