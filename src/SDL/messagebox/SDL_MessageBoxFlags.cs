using System;

namespace SDL3;

/// <summary>
/// <see cref="SDL_MessageBoxData"/> flags.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxFlags">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_MessageBoxFlags : uint
{
	/// <summary>
	/// Error dialog.
	/// </summary>
	Error = 0x00000010u,

	/// <summary>
	/// Warning dialog.
	/// </summary>
	Warning = 0x00000020u,

	/// <summary>
	/// Informational dialog.
	/// </summary>
	Information = 0x00000040u,

	/// <summary>
	/// Buttons placed left to right.
	/// </summary>
	ButtonsLeftToRight = 0x00000080u,

	/// <summary>
	/// Buttons placed right to left.
	/// </summary>
	ButtonsRightToLeft = 0x00000100u
}