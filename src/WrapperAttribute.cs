using System;
using System.ComponentModel;

namespace SDL_cs;

/// <summary>
/// Indicates that some type is a wrapper for another type.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class WrapperAttribute : Attribute;