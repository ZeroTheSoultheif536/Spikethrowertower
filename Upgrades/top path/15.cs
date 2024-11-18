using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2Cpp;

namespace Spikethrowertower.Upgrades
{
    internal class SpikeHell : ModUpgrade<SpikeThrower>

    {
        public override int Path => TOP;

        public override int Tier => 5;

        public override int Cost => 156075;

        public override string Description => "There are levels to hell... this is the last one.";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 21, 0, 90, null, false, false);

            weaponModel.rate = 0.10f;
            projectileModel.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Fortified", "Fortifieds",
                            2, 1, false, false));
            projectileModel.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moabs",
                    2, 5, false, false));
            weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
        }
    }
}
