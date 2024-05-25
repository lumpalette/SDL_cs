using System;
using System.ComponentModel;

namespace SDL3;

unsafe partial class SDL
{
	/// <summary>
	/// Indicates that a method is defined as a macro in some SDL header.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MacroAttribute : Attribute;
}