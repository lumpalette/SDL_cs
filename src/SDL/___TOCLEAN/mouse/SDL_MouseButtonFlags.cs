using System;

namespace SDL_cs;

/// <summary>
/// A bitmask of pressed mouse buttons, as reported by <see cref="SDL.GetMouseState(out float, out float)"/>, etc.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_MouseButtonFlags : uint
{
	Left = 1u << (SDL_MouseButton.Left - 1),
	Middle = 1u << (SDL_MouseButton.Middle - 1),
	Right = 1u << (SDL_MouseButton.Right - 1),
	X1 = 1u << (SDL_MouseButton.X1 - 1),
	X2 = 1u << (SDL_MouseButton.X2 - 1),
}