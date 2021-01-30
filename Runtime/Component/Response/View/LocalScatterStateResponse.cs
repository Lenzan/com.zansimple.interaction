using System;
using Framework.InteractionSystem.Config;
using UnityEngine.Events;

namespace Framework.InteractionSystem.Runtime
{
    [Serializable]
    public class LocalScatterStateResponse
    {
        public LocalScatterState state;

        public UnityEvent eventResponse;
    }
}