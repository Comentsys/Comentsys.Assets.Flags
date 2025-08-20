namespace Comentsys.Assets.Flags;

/// <summary>
/// Flag Data
/// Flags by Jakob Flierl and Lipis – License: MIT License
/// </summary>
public class FlagData
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="type">Flag Type</param>
    /// <param name="name">Flag Name</param>
    /// <param name="code">Flag ISO 3166-1 alpha-2 Code</param>
    /// <param name="isIsoFlag">Is Iso Flag?</param>
    /// <param name="capital">Country Capital</param>
    /// <param name="continent">Default Icon Direction</param>
    public FlagData(FlagType type, string? name, string? code, bool? isIsoFlag, string? capital = null, string? continent = null) =>
        (Type, Name, Code, IsIsoFlag, Capital, Continent) =
        (type, name, code, isIsoFlag, capital, continent);

    /// <summary>
    /// Flag Type
    /// </summary>
    public FlagType Type { get; set; }

    /// <summary>
    /// Flag Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Flag ISO 3166-1 alpha-2 Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Is ISO Flag?
    /// </summary>
    public bool? IsIsoFlag { get; set; }

    /// <summary>
    /// Country Capital
    /// </summary>
    public string? Capital { get; set; }

    /// <summary>
    /// Country Continent
    /// </summary>
    public string? Continent { get; set; }
}
