using System;
using System.ComponentModel;

namespace SDL_cs;

/// <summary>
/// Indicates that a type is opaque in SDL.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class OpaqueAttribute : Attribute;