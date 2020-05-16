using System;
using System.Collections.Generic;
using Oxide.Core;
using Oxide.Core.Configuration;
using Oxide.Core.Libraries.Covalence;
using UnityEngine;
using System.Linq;

namespace Oxide.Plugins
{
    [Info("Chest shop plugin", "Yan1204", "0.1.0")]
    [Description("Creation of a box where things for sale will be stored")]
    public class ChestShop_Plugin : RustPlugin
    {
        void OnLootEntity(BasePlayer player, BaseEntity entity)
        {
            if (entity is StorageContainer)
            {
                Puts("OnLootEntity works! NAME:  " + entity.name + "   PrefabID: " + entity.prefabID);
            }
        }
    }
}
