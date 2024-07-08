using System;
using System.ComponentModel;

namespace SDL_cs;

/// <summary>
/// Indicates that a method is a <c>#define</c> macro.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class MacroAttribute : Attribute;