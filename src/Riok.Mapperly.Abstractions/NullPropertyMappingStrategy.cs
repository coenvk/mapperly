namespace Riok.Mapperly.Abstractions;

/// <summary>
/// Strategies on how to handle <c>null</c> values when mapping property values.
/// </summary>
public enum NullPropertyMappingStrategy
{
    /// <summary>
    /// 
    /// </summary>
    SetOrIgnoreIfNull,

    /// <summary>
    /// 
    /// </summary>
    SetOrThrowIfNull,

    /// <summary>
    /// 
    /// </summary>
    SetOrDefaultIfNull,

    /// <summary>
    /// 
    /// </summary>
    IgnoreIfNull,

    /// <summary>
    /// 
    /// </summary>
    DefaultIfNull,
}
