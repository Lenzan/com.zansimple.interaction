using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Framework.InteractionSystem.Config
{
    [Serializable]
    public class LocalScatterState
    {
        /// <summary>
        /// 响应层
        /// </summary>
        [SerializeField] private string _layer;

        /// <summary>
        /// 是否需要初始化
        /// </summary>
        [SerializeField] private bool _needInit;

        /// <summary>
        /// 循环状态
        /// </summary>
        [SerializeField] private bool _looping;
        /// <summary>
        /// 离散列表
        /// </summary>
        [SerializeField] private List<string> _stateList;
        

        public string Layer
        {
            get => _layer;
            set => _layer = value;
        }

        public bool NeedInit
        {
            get => _needInit;
            set => _needInit = value;
        }

        public bool Looping
        {
            get => _looping;
            set => _looping = value;
        }

        public List<string> StateList
        {
            get => _stateList;
            set => _stateList = value;
        }
    }
    
    
}