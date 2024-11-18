using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity.UI_New.DailyChallenge;

namespace Spikethrowertower
{
    public class SpikeThrower : ModTower

    {
        public override TowerSet TowerSet => TowerSet.Primary;

        public override string BaseTower => TowerType.DartMonkey;
       

        public override int Cost => 1000;


        public override string Description => "A tower that throws spikes... not the ones from the spike factory";

        public override string DisplayName => "Spike Thrower";


        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;
            
            // +=  is add range x= multiply yatayatayata... atkmodel is how far the projectile goes towernodel is actual range
            towerModel.range += 15;
            attackModel.range += 20;

            // lower number = faster speed (cooldown)
            weaponModel.rate = 1f;

            projectileModel.pierce = 4;
            projectileModel.GetDamageModel().damage = 2;
            

               

        }
        public override string Icon => "SpikeThrower-Icon";
        public override string Portrait => "SpikeThrower-Portrait";



    }
  
}