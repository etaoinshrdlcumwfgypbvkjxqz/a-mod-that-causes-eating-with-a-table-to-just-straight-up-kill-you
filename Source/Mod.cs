using RimWorld;
using Verse;
using Verse.AI;
using HarmonyLib;

namespace Polyipseity.RimWorld.AModThatCausesEatingWithATableToJustStraightUpKillYou
{
	public class EarlyModStartup : Mod
	{
		internal static readonly Harmony HARMONY = new Harmony(ModStartup.ID);

		public EarlyModStartup(ModContentPack content) : base(content) { }
	}

	[StaticConstructorOnStartup]
	public static class ModStartup
	{
		public const string ID = nameof(Polyipseity.RimWorld.AModThatCausesEatingWithATableToJustStraightUpKillYou);

		static ModStartup()
		{
			EarlyModStartup.HARMONY.PatchAll();
			Log.Message($"[{ID}] Patches applied.");
		}
	}

	[HarmonyPatch(typeof(Toils_Ingest), nameof(Toils_Ingest.FinalizeIngest))]
	static class Patch_AddHediffOnEatingWithTable
	{
		static void Postfix(ref Toil __result, Pawn ingester)
		{
			var action = __result.initAction;
			__result.initAction = delegate
			{
				action();
				if (ingester.needs.mood.thoughts.memories.GetFirstMemoryOfDef(ThoughtDefOf.AteWithoutTable) == null)
				{
					ingester.health.AddHediff(ModDefOf.HediffDefOf.AMTCEWATTJSUKY_AteWithTable);
				}
			};
		}
	}
}
