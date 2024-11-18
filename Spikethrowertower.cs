using MelonLoader;
using BTD_Mod_Helper;
using Spikethrowertower;

[assembly: MelonInfo(typeof(Spikethrowertower.Spikethrowertower), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Spikethrowertower;

public class Spikethrowertower : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Spikethrowertower>("Spike thrower loaded!");
    }
}