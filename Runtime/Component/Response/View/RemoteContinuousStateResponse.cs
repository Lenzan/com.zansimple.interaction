using System;
using Framework.InteractionSystem.Config;
using UnityEngine.Events;

namespace Framework.InteractionSystem.Runtime
{
    [Serializable]
    public class RemoteContinuousStateResponse
    {
        public RemoteContinuousState remoteContinuousState;

        public UnityEvent eventResponse;
    }
}