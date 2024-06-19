using System;
using System.ComponentModel;

namespace SDL_cs;

/// <summary>
/// Indicates that some type is defined as a union in SDL.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class UnionAttribute : Attribute;