using System;
using System.Collections.Generic;
using UnityEngine;

namespace Framework.InteractionSystem.Config
{
    [Serializable]
    public class RemoteContinuousState
    {
        
        /// <summary>
        /// 远端 实体 ID
        /// </summary>
        [SerializeField] private string _remoteEntityId;

        /// <summary>
        /// 响应层
        /// </summary>
        [SerializeField] private string _layer;
        
        /// <summary>
        /// 离散列表
        /// </summary>
        [SerializeField] private List<string> _stateList;

        public string RemoteEntityId
        {
            get => _remoteEntityId;
            set => _remoteEntityId = value;
        }  
        
        public string Layer
        {
            get => _layer;
            set => _layer = value;
        }

        public List<string> StateList
        {
            get => _stateList;
            set => _stateList = value;
        }
    }
}