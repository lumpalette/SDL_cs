using System;

namespace SDL3;

/// <summary>
/// <see cref="SDL_MessageBoxButtonData"/> flags.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxButtonFlags">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_MessageBoxButtonFlags : uint
{
	/// <summary>
	/// Marks the default button when return is hit.
	/// </summary>
	ReturnKeyDefault = 0x00000001u,

	/// <summary>
	/// Marks the default button when escape is hit.
	/// </summary>
	EscapeKeyDefault = 0x00000002u
}