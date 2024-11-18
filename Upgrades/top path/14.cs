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

namespace Spikethrowertower.Upgrades
{
    internal class ManyASpike : ModUpgrade<SpikeThrower>

    {
        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 20000;

        public override string Description => "9 spikes even faster + pierce, damage, and extra fortified damage.";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 9, 0, 75, null, false, false);

            weaponModel.rate = 0.20f;
            projectileModel.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Fortified", "Fortifieds",
                        1, 10, false, false));

        }
    }
}

