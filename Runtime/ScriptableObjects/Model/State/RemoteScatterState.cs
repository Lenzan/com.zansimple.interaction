using System;
using System.Collections.Generic;
using UnityEngine;

namespace Framework.InteractionSystem.Config
{
    [Serializable]
    public class RemoteScatterState
    {
        /// <summary>
        /// 远端 实体 ID
        /// </summary>
        [SerializeField] private string _remoteEntityId;
        
        /// <summary>
        /// 远端响应层
        /// </summary>
        [SerializeField] private string _remoteEntityLayer;
        
        /// <summary>
        /// 远端离散状态列表
        /// </summary>
        [SerializeField] private List<string> _remoteEntityStates;
        
        public string RemoteEntityId
        {
            get => _remoteEntityId;
            set => _remoteEntityId = value;
        }
        
        public string RemoteEntityLayer
        {
            get => _remoteEntityLayer;
            set => _remoteEntityLayer = value;
        }
        
        public List<string> RemoteEntityStates
        {
            get => _remoteEntityStates;
            set => _remoteEntityStates = value;
        }
    }
}