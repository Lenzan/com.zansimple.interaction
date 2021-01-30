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
        [SerializeField] private string remoteEntityId;
        
        /// <summary>
        /// 远端响应层
        /// </summary>
        [SerializeField] private string remoteEntityLayer;
        
        /// <summary>
        /// 远端离散状态列表
        /// </summary>
        [SerializeField] private List<string> remoteEntityStates;
        
        public string RemoteEntityId
        {
            get => remoteEntityId;
            set => remoteEntityId = value;
        }
        
        public string RemoteEntityLayer
        {
            get => remoteEntityLayer;
            set => remoteEntityLayer = value;
        }
        
        public List<string> RemoteEntityStates
        {
            get => remoteEntityStates;
            set => remoteEntityStates = value;
        }
    }
}