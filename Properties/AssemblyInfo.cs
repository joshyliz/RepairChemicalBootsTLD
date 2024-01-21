using MelonLoader;
using System.Reflection;

[assembly: AssemblyTitle(BuildInfo.ModName)]
[assembly: AssemblyCopyright($"Created by Joshyliz")]

[assembly: AssemblyVersion(BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(RepairChemicalBootsTLD.RepairChemicalBoots), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.ModAuthor)]

//This tells MelonLoader that the mod is only for The Long Dark.
[assembly: MelonGame("Hinterland", "TheLongDark")]

internal static class BuildInfo
{
	internal const string ModName = "Repair Chemical Boots";
	internal const string ModAuthor = "Joshyliz";
	/// <summary>
	/// Version numbers in C# are a set of 1 to 4 positive integers separated by periods.
	/// Mods typically use 3 numbers. For example: 1.2.1
	/// </summary>
	internal const string ModVersion = "1.0.0";
}
