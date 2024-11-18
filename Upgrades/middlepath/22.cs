using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;

namespace Spikethrowertower.Upgrades.NewFolder
{
    internal class PowerfulSpikes : ModUpgrade<SpikeThrower>
    {
        public override int Path => MIDDLE;

        public override int Tier => 2;

        public override int Cost => 600;

        public override string Description => "+4 pierce +2 damage";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.pierce += 4;
            projectileModel.GetDamageModel().damage += 2;


        }

    }


}