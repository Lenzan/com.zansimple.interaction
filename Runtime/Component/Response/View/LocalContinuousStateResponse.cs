using System;
using Framework.InteractionSystem.Config;
using UnityEngine.Events;

namespace Framework.InteractionSystem.Runtime
{
    [Serializable]
    public class LocalContinuousStateResponse
    {
        public LocalContinuousState localContinuousState;

        public UnityEvent eventResponse;
    }
}