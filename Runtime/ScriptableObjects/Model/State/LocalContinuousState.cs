using System;
using UnityEngine;

namespace Framework.InteractionSystem.Config
{
    [Serializable]
    public class LocalContinuousState
    {
        /// <summary>
        /// 响应层
        /// </summary>
        [SerializeField] private string layer;
        
        /// <summary>
        /// 状态
        /// </summary>
        [SerializeField] private string state;


        public string Layer
        {
            get => layer;
            set => layer = value;
        }

        public string State
        {
            get => state;
            set => state = value;
        }
    }
}