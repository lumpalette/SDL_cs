using System;
using System.ComponentModel;

namespace SDL_cs;

/// <summary>
/// Indicates that a <see langword="struct"/> is a union.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class UnionAttribute : Attribute;