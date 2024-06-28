using System;
using System.ComponentModel;

namespace SDL_cs;

/// <summary>
/// Indicates that some enumerator is defined as a typedef in SDL.
/// </summary>
[AttributeUsage(AttributeTargets.Enum)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class TypedefAttribute : Attribute;