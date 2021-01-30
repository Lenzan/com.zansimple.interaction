using Framework.InteractionSystem.Config;
using UnityEngine;

namespace Framework.InteractionSystem.Runtime
{
    public class InteractionEntity : MonoBehaviour
    {
        [ContextMenuItem("Refresh Entity Id" , "RefreshEntityId")]
        public string entityId;

        public EntityModel entityConfig;

        private void RefreshEntityId()
        {
            entityId = name;
        }
    }
}