using System.Collections.Generic;
using UnityEngine;

namespace Framework.InteractionSystem.Config
{
    [CreateAssetMenu(fileName = "New Entity", menuName = "交互配置/Entity", order = 0)]
    public class EntityModel : ScriptableObject
    {
        public string name;

        [Multiline(3)]
        public string description;
        
        // 本地离散状态列表
        public List<LocalScatterState> scatterStates;
        // 本地连续状态列表
        public List<LocalContinuousState> continuousStates;
        // 远端离散状态列表
        public List<RemoteScatterState> remoteScatterStates;
        // 远端连续状态列表
        public List<RemoteContinuousState> remoteContinuousStates;
    }
}