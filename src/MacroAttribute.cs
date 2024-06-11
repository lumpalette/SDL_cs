using System;
using System.ComponentModel;

namespace SDL_cs;

/// <summary>
/// Indicates that some method is defined as a macro in some SDL header.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class MacroAttribute : Attribute;