using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;

namespace Spikethrowertower.Upgrades.NewFolder
{
    internal class MegaBallista : ModUpgrade<SpikeThrower>
    {
        public override int Path => MIDDLE;

        public override int Tier => 4;

        public override int Cost => 35000;

        public override string Description => "Bigger projectile + 25 pierce +8 damage + 25 Moab damage) ABILITY: throws big ballista at the biggest bloons on screen and deal ridiculous damage ";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.pierce += 25;
            projectileModel.GetDamageModel().damage += 12;
            projectileModel.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moabs",
                        2, 25, false, false));
            projectileModel.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Fortified", "Fortifieds",
                1 , 15, false, false));
        }



    }


}