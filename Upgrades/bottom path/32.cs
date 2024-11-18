using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using HarmonyLib;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity;
using UnityEngine.InputSystem.XR;

namespace Spikethrowertower.Upgrades.bottom_path
{
    internal class ETS : ModUpgrade<SpikeThrower>
    {
        public override int Path => BOTTOM;

        public override int Tier => 2;

        public override int Cost => 1050;

        public override string Description => "Enhanced Targeting Systems, much bigger range, camo detection, and homing projectiles";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;




            towerModel.range += 25;
            attackModel.range += 30;
            weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.Lead;
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
            Game.instance.model.GetTowerFromId("NinjaMonkey-001").GetWeapon().projectile.GetBehavior<TrackTargetWithinTimeModel>().Duplicate<TrackTargetWithinTimeModel>();
            towerModel.GetWeapon().projectile.AddBehavior(Game.instance.model.GetTowerFromId("NinjaMonkey-001").GetWeapon().projectile.GetBehavior<TrackTargetWithinTimeModel>().Duplicate<TrackTargetWithinTimeModel>());
        }
    }
}
   