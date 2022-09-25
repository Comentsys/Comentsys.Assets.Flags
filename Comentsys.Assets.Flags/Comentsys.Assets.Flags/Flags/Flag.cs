namespace Comentsys.Assets.Flags;

/// <summary>
/// Flags from Jakob Flierl, Curated by Lipis – License: MIT License
/// </summary>
public class Flag : AssetBase<Flag>
{
    private const int width = 45;
    private const int height = 45;
    private const string folder = "Resources";
    private const string root = "Comentsys.Assets.Flags";

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="set">Flag Set</param>
    /// <param name="type">Flag Type</param>
    /// <returns>Chess Piece Path</returns>
    private static string Path(FlagSet set, FlagType type) =>
        $"{folder}.{Enum.GetName(typeof(FlagSet), set) ?? string.Empty}.{Enum.GetName(typeof(FlagType), type) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="set">Flag Set</param>
    /// <param name="type">Flag Type</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(FlagSet set, FlagType type) =>
        new(AsStream(root, Path(set, type)) ?? new MemoryStream(), height, width);
}
