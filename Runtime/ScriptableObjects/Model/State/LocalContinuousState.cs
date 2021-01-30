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
        [SerializeField]
        private string _layer;
        
        /// <summary>
        /// 状态
        /// </summary>
        [SerializeField] private string _state;


        public string Layer
        {
            get => _layer;
            set => _layer = value;
        }

        public string State
        {
            get => _state;
            set => _state = value;
        }
    }
}