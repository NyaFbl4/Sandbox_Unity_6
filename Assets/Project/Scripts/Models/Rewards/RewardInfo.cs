using System;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts.Models.Rewards
{
    [Serializable]
    public class RewardInfo
    {
        [SerializeField] private RewardType _rewardType;
        [SerializeField] private string _rewardName;
        [SerializeField] private Image _rewardImage;
        
        public RewardType RewardType => _rewardType;
        public string RewardName => _rewardName;
        public Image RewardImage => _rewardImage;
    }
}