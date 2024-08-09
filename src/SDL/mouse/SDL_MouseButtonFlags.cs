namespace SDL3;

/// <summary>
/// A bitmask of pressed mouse buttons, as reported by <see cref="SDL.GetMouseState(float*, float*)"/>, etc.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_MouseButtonFlags : uint
{
	LMask = 1u << (SDL_Button.Left - 1),
	MMask = 1u << (SDL_Button.Middle - 1),
	RMask = 1u << (SDL_Button.Right - 1),
	X1Mask = 1u << (SDL_Button.X1 - 1),
	X2Mask = 1u << (SDL_Button.X2 - 1)
}