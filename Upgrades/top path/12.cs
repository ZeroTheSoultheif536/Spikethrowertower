using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using static UnityEngine.ExpressionEvaluator;

namespace Spikethrowertower.Upgrades
{
    internal class SpeedySpikes : ModUpgrade<SpikeThrower>

    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 780;

        public override string Description => "faster atk and projectile speed";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.rate = 0.45f;
        }
    }
}
