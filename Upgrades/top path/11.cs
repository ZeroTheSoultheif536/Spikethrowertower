using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Unity;

namespace Spikethrowertower.Upgrades
{
    internal class FasterThrowing : ModUpgrade<SpikeThrower>
    {
        public override int Path => TOP;

        public override int Tier => 1;

        public override int Cost => 450;

        public override string Description => "faster atk speeed";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;
            
            

         
            weaponModel.rate = 0.70f;
            // ability: var ability = new Abilitymodel "whateverabilityname", "actualreadname", "description", 0 , 0 , getspritereference (refer to darkterra how to mod ep 2)
        }
       
  
            }
}
