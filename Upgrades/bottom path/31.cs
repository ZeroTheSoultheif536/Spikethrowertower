using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using static UnityEngine.ExpressionEvaluator;

namespace Spikethrowertower.Upgrades.bottom_path
{
    internal class LongRange : ModUpgrade<SpikeThrower>
    {
        public override int Path => BOTTOM;

        public override int Tier => 1;

        public override int Cost => 300;

        public override string Description => "Longer Range";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;




            towerModel.range += 5;
            attackModel.range += 5;
        }
    }
}
