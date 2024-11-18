using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;

namespace Spikethrowertower.Upgrades.middlepath
{
    internal class Gigallista : ModUpgrade<SpikeThrower>
    {
        public override int Path => MIDDLE;

        public override int Tier => 5;

        public override int Cost => 200750;

        public override string Description => "Will gut the bloons inside out, and leave nothing behind";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;
            // Moab damage +30
            projectileModel.pierce += 100;
            projectileModel.GetDamageModel().damage += 65;
            projectileModel.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moabs",
                     8, 50, false, false));
            projectileModel.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Fortified", "Fortifieds",
                            2, 15, false, false));


        }


    }
}