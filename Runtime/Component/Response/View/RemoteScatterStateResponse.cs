using System;
using Framework.InteractionSystem.Config;
using UnityEngine.Events;

namespace Framework.InteractionSystem.Runtime
{
    [Serializable]
    public class RemoteScatterStateResponse
    {
        public RemoteScatterState remoteScatterState;

        public UnityEvent eventResponse;
    }
}