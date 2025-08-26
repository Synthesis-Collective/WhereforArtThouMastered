using Mutagen.Bethesda.Plugins;

namespace WhereforeArtThouMastered;

public class Settings
{
    public ModKey TargetMod { get; set; }
    public ModKey CandidateMaster { get; set; }
    public bool VerboseMode { get; set; } = false;
}