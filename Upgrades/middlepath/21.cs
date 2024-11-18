using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Powers;
using Il2CppAssets.Scripts.Models.Towers;
using static UnityEngine.ExpressionEvaluator;

namespace Spikethrowertower.Upgrades.NewFolder
{
    internal class SharpSpikes : ModUpgrade<SpikeThrower>
    {
        public override int Path => MIDDLE;

        public override int Tier => 1;

        public override int Cost => 600;

        public override string Description => "+3 pierce +1 damage";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.pierce += 3;
            projectileModel.GetDamageModel().damage += 1;


        }

    }


}