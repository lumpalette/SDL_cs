using System.ComponentModel;

namespace SDL3;

/// <summary>
/// Indicates that this type is opaque in SDL.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class OpaqueAttribute : Attribute;