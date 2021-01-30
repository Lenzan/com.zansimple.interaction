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
        [SerializeField] private string remoteEntityId;

        /// <summary>
        /// 响应层
        /// </summary>
        [SerializeField] private string layer;
        
        /// <summary>
        /// 离散列表
        /// </summary>
        [SerializeField] private List<string> stateList;

        public string RemoteEntityId
        {
            get => remoteEntityId;
            set => remoteEntityId = value;
        }  
        
        public string Layer
        {
            get => layer;
            set => layer = value;
        }

        public List<string> StateList
        {
            get => stateList;
            set => stateList = value;
        }
    }
}