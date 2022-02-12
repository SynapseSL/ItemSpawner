using Synapse.Api.Plugin;

namespace ItemSpawner
{
    [PluginInformation(
        Name = "Itemspawner",
        Author = "Dimenzio",
        Description = "A plugin to set spawnpoints of Items",
        LoadPriority = int.MinValue,
        SynapseMajor = 2,
        SynapseMinor = 0,
        SynapsePatch = 0,
        Version = "1.1.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section="ItemSpawner")]
        public static Config Config;

        public override void Load() => SynapseController.Server.Events.Round.RoundStartEvent += RoundStart;

        private void RoundStart()
        {
            foreach(var spawn in Config.Spawns)
                if(UnityEngine.Random.Range(1f,100f) <= spawn.SpawnChance)
                {
                    var item = spawn.Item.Parse();
                    item.Drop(spawn.Position.Parse().Position);
                }
        }
    }
}
