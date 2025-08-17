namespace Comentsys.Assets.Flags;

/// <summary>
/// Helper Methods
/// </summary>
internal class Helper
{
    private static readonly Regex regex = new("#([0-9a-fA-F]{6}|[0-9a-fA-F]{3})");

    /// <summary>
    /// From Html
    /// </summary>
    /// <param name="html">Html Colour</param>
    /// <returns>Color</returns>
    internal static Color? FromHtml(string? html)
    {
        if (html == null && string.IsNullOrWhiteSpace(html))
        {
            return null;
        }
        html = html?.TrimStart('#');
        if (html?.Length == 3)
        {
            html = string.Concat(html.Select(c => new string(c, 2)));
        }
        return html?.Length == 6 && int.TryParse(html, NumberStyles.HexNumber, null, out int argb)
            ? Color.FromArgb((argb >> 16) & 0xFF, (argb >> 8) & 0xFF, argb & 0xFF)
            : null;
    }

    /// <summary>
    /// To Colors
    /// </summary>
    /// <param name="content">Content</param>
    /// <returns>Array of Colours</returns>
    internal static Color[]? ToColors(string? content) =>
        content == null || string.IsNullOrWhiteSpace(content) ? null : 
        [..
            regex.Matches(content).Cast<Match>()
            .Select(match => FromHtml(match.Value))
            .Where(color => color.HasValue)
            .Select(color => color)
            .Cast<Color>()
            .Distinct()
        ];
}
