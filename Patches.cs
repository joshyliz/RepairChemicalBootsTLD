using HarmonyLib;
using System;
using Il2Cpp;
using Il2CppTLD.Gear;
using UnityEngine;
using MelonLoader;

namespace RepairChemicalBootsTLD
{
  internal static class Pacthes 
  {
    [HarmonyPatch(typeof(GearItem), "Awake")]
    private static class GearItem_Awake
    {
      private const string SCRAP_LEAD_NAME = "GEAR_ScrapLead";
      private const string LEATHER = "GEAR_Leather";
      
      internal static void Postfix(GearItem __instance)
      {
        if(Utils.NormalizeName(__instance.name) == "GEAR_MinersBoots")
        {
          __instance.m_Millable = Utils.GetOrCreateComponet<Millable>(__instance.gameObject);
          __instance.m_Millable.m_CanRestoreFromWornOut = true;
          __instance.m_Millable.m_RecoveryDurationMinutes = 210;
          __instance.m_Millable.m_RepairDurationMinutes = 60;
          __instance.m_Millable.m_RepairRequiredGear = new GearItem[] { GearItem.LoadGearItemPrefab(SCRAP_LEAD_NAME), GearItem.LoadGearItemPrefab(LEATHER) };
          __instance.m_Millable.m_RepairRequiredGearUnits = new int[] { 2, 1 };
          __instance.m_Millable.m_RepairRequiredGear = new GearItem[] { GearItem.LoadGearItemPrefab(SCRAP_LEAD_NAME), GearItem.LoadGearItemPrefab(LEATHER) };
          __instance.m_Millable.m_RestoreRequiredGearUnits = new int[] { 4, 2 };
          __instance.m_Millable.m_Skill = SkillType.ToolRepair;
        }
      }
    }
  }
}
