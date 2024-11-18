using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Data.Bloons;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Simulation.Bloons;

namespace Spikethrowertower.Upgrades.NewFolder
{
    internal class Ballista : ModUpgrade<SpikeThrower>
    {
        public override int Path => MIDDLE;

        public override int Tier => 3;

        public override int Cost => 4500;

        public override string Description => "spike changes to ballista, + 15 pierce + 5 damage + 3 Moab damage and lead popping";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.pierce += 15;
            projectileModel.GetDamageModel().damage += 5;
            weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            
                 
        }

        

    }


}
