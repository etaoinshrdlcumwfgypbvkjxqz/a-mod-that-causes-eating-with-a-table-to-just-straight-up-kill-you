using RimWorld;
using Verse;

namespace Polyipseity.RimWorld.AModThatCausesEatingWithATableToJustStraightUpKillYou
{
	public static class ModDefOf
	{
		[DefOf]
		public static class HediffDefOf
		{
			public static HediffDef AMTCEWATTJSUKY_AteWithTable = null;

			static HediffDefOf()
			{
				DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
			}
		}
	}
}
