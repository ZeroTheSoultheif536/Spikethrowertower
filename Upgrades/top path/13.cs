using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;

namespace Spikethrowertower.Upgrades
{
    internal class quintishot : ModUpgrade<SpikeThrower>

    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 3560;

        public override string Description => "faster atk speeed and 5 projectiles";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 5, 0, 50, null, false, false);

            weaponModel.rate = 0.30f;
        }
    }
}
