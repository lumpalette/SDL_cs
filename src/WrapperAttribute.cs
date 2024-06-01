using System.ComponentModel;

namespace SDL3;

/// <summary>
/// Indicates that this type is a wrapper for another type.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class WrapperAttribute : Attribute;