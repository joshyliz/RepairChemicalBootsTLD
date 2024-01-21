using HarmonyLib;
using Il2Cpp;
using System;
using UnityEngine;

namespace RepairChemicalBootsTLD
{
  internal static class Utils
  {
    public static string? NormalizeName(string name)
    {
      if(name == null)
      {
        return null;
      }
      else 
      {
        return name.Replace("(Clone)", "").Trim();
      }
    }

    public static T? GetOrCreateComponet<T>(this GameObject? gameObject) where T : Component
    {
      if(gameObject == null)
      {
        return default;
      }

      T? result = GetComponetSafe<T>(gameObject);

      if(result == null)
      {
        result =gameObject.AddComponent<T>();
      }

      return result;
    }

    public static T? GetComponetSafe<T>(this GameObject? gameObject) where T : Component
    {
      return gameObject == null ? default : gameObject.GetComponent<T>();
    }


  }
}
