using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity;

namespace Spikethrowertower.Upgrades.bottom_path;
    internal class Spears : ModUpgrade<SpikeThrower>
{
    public override int Path => BOTTOM;

    public override int Tier => 3;

    public override int Cost => 3750;

    public override string Description => "Spikes replaced with spears that stick into bloons and deal D.O.T. also slows down all non Moabs";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        var attackModel = towerModel.GetAttackModel();
        var weaponModel = towerModel.GetWeapon();
        var projectileModel = weaponModel.projectile;




        towerModel.range += 10;
       attackModel.range += 15;

        Game.instance.model.GetTowerFromId("GlueGunner-302").GetWeapon().projectile.GetBehavior<SlowModifierForTagModel>().Duplicate<SlowModifierForTagModel>();
        towerModel.GetWeapon().projectile.AddBehavior(Game.instance.model.GetTowerFromId("GlueGunner-302").GetWeapon().projectile.GetBehavior<SlowModifierForTagModel>().Duplicate<SlowModifierForTagModel>());
       

        {
        }
    }
}

