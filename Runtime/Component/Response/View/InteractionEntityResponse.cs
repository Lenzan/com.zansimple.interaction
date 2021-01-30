using System.Collections.Generic;
using Framework.InteractionSystem.Config;
using UnityEngine;

namespace Framework.InteractionSystem.Runtime
{
    [AddComponentMenu("交互模块/InteractionEntityResponse")]
    [HelpURL("https://www.baidu.com")]
    public class InteractionEntityResponse : MonoBehaviour
    {
        private InteractionEntity _entity;

        public List<LocalScatterStateResponse> localScatterStateResponses = new List<LocalScatterStateResponse>();

        public List<LocalContinuousStateResponse> localContinuousStateResponses = new List<LocalContinuousStateResponse>();

        public List<RemoteScatterStateResponse> remoteScatterStateResponses = new List<RemoteScatterStateResponse>();

        public List<RemoteContinuousStateResponse> remoteContinuousStateResponses = new List<RemoteContinuousStateResponse>();

#if UNITY_EDITOR
         
        [ContextMenu("Refresh States" )]
        private void RefreshStates()
        {
            if (_entity == null) _entity = GetComponent<InteractionEntity>();
        }
        
        [ContextMenu("Refresh States ID")]
        private void RefreshStateID()
        {
            if (_entity == null) _entity = GetComponent<InteractionEntity>();
        }
       
        
#endif
 
        private void Awake()
        {
            _entity = GetComponent<InteractionEntity>();
        }
        
    }
}