using Synapse.Config;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace ItemSpawner
{
    public class Config : AbstractConfigSection
    {
        [Description("The Items which should spawn each Round")]
        public List<ItemSpawn> Spawns = new List<ItemSpawn>
        {
            new ItemSpawn {Item = new SerializedItem((int)ItemType.KeycardO5,0,0,0,0,Vector3.one),Position = new SerializedMapPoint("HCZ_079", 5.290604f, -3, -6.44455f),SpawnChance = 100f},
        };
    }

    public class ItemSpawn
    {
        public SerializedMapPoint Position;

        public SerializedItem Item;

        public float SpawnChance;
    }
}
