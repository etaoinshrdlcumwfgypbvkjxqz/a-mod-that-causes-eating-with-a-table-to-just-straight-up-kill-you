using Verse;

namespace Polyipseity.RimWorld.AModThatCausesEatingWithATableToJustStraightUpKillYou {
	public class EarlyModStartup : Mod {
		public EarlyModStartup(ModContentPack content) : base(content) {}
	}

	[StaticConstructorOnStartup]
	public static class ModStartup {
		public const string ID = nameof(Polyipseity.RimWorld.AModThatCausesEatingWithATableToJustStraightUpKillYou);

		static ModStartup() {}
	}
}
