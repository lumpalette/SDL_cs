namespace SDL_cs;

/// <summary>
/// Standard gamepad types.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadType">here</see>.
/// </remarks>
public enum SDL_GamepadType
{
	Unknown = 0,
	Standard,
	Xbox360,
	XboxOne,
	PS3,
	PS4,
	PS5,
	NintendoSwitchPro,
	NintendoSwitchJoyconLeft,
	NintendoSwitchJoyconRight,
	NintendoSwitchJoyconPair,
	Max
}