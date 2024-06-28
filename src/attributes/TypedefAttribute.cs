using System;
using System.ComponentModel;

namespace SDL_cs;

/// <summary>
/// Indicates that some type is defined as a typedef in SDL.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class TypedefAttribute : Attribute;